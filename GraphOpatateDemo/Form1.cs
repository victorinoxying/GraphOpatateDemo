using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphOpatateDemo
{
    public partial class GraphDemo : Form
    {
        public GraphDemo()
        {
            InitializeComponent();
        }

        private Bitmap originImag;
        private Bitmap currentImag;
        private string input_Filepath;
        private string output_Filepath;
        enum reverse_type
        {
            straight,
            vertical
        };


        private void button_resetImg_Click(object sender, EventArgs e)
        {
            if (originImag == null)
                return;

            pictureBox.Image = originImag;
            Rectangle rect = new Rectangle(0, 0, originImag.Width, originImag.Height);
            currentImag = originImag.Clone(rect, originImag.PixelFormat);
            IsGraylize_radioButton_checked = false;
            Graylize_radioButton.Checked = IsGraylize_radioButton_checked;
            setBlue(0);
            setGreen(0);
            setRed(0);
            rotation_box.Text = "";
        }

        /// <summary>
        /// 按照逆时针角度旋转图片
        /// </summary>
        /// <param name="imag"></param>
        /// <param name="angle"></param>
        /// <returns>image</returns>
        public Bitmap operate_img_by_angle(Bitmap imag, float angle)
        {
            angle = angle % 360;            //弧度转换  
            double radian = angle * Math.PI / 180.0;
            double cos = Math.Cos(radian);
            double sin = Math.Sin(radian);
            //原图的宽和高  
            int width = imag.Width;
            int height = imag.Height;
            int changeWidth = (int)(Math.Max(Math.Abs(width * cos - height * sin), Math.Abs(width * cos + height * sin)));
            int changeHeight = (int)(Math.Max(Math.Abs(width * sin - height * cos), Math.Abs(width * sin + height * cos)));
            //目标位图
            Bitmap dsImage = new Bitmap(changeWidth, changeHeight);
            Graphics graph = Graphics.FromImage(dsImage);
            graph.InterpolationMode = InterpolationMode.Bilinear;
            graph.SmoothingMode = SmoothingMode.HighQuality;
            //计算偏移量  
            Point Offset = new Point((changeWidth - width) / 2, (changeHeight - height) / 2);
            //构造图像显示区域：让图像的中心与窗口的中心点一致  
            Rectangle rect = new Rectangle(Offset.X, Offset.Y, width, height);
            Point center = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
            graph.TranslateTransform(center.X, center.Y);
            graph.RotateTransform(360 - angle);
            //恢复图像在水平和垂直方向的平移  
            graph.TranslateTransform(-center.X, -center.Y);
            graph.DrawImage(imag, rect);
            //重至绘图的所有变换  
            graph.ResetTransform();
            graph.Save();
            graph.Dispose();
            return dsImage;
        }

        private void input_item_Click(object sender, EventArgs e)
        {
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Multiselect = false;
            fDialog.Title = "请选择一幅图像";
            fDialog.Filter = "图片文件(*.png, *.jpg, *.jpeg, *.bmp) | *.png; *.jpg; *.jpeg; *.bmp";
            if (fDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            input_Filepath = fDialog.FileName;
            FileStream filestream = File.OpenRead(input_Filepath);
            Image img = Image.FromStream(filestream);
            filestream.Close();
            try
            {
                originImag = new Bitmap(img);
                currentImag = new Bitmap(img);
                pictureBox.Image = originImag;
            }
            catch (Exception exp)
            {
                //抛出异常  
                MessageBox.Show(exp.Message);
            }

        }

        private void button_turnRight_Click(object sender, EventArgs e)
        {
            if (currentImag == null)
                return;
            Bitmap img_temp = operate_img_by_angle(currentImag, 270);
            this.pictureBox.Image = img_temp;
            currentImag = img_temp;

        }

        private void button_turnLeft_Click(object sender, EventArgs e)
        {
            if (currentImag == null)
                return;
            Bitmap img_temp = operate_img_by_angle(currentImag, 90);
            this.pictureBox.Image = img_temp;
            currentImag = img_temp;
        }

        private void button_UD_reverse_Click(object sender, EventArgs e)
        {
            if (currentImag == null)
                return;
            operate_img_reverse(currentImag, reverse_type.vertical);
            pictureBox.Image = currentImag;
        }

        private void button_RL_reverse_Click(object sender, EventArgs e)
        {
            if (currentImag == null)
                return;
            operate_img_reverse(currentImag, reverse_type.straight);
            pictureBox.Image = currentImag;
        }

        /// <summary>
        /// 按rgb数值处理bitmap图片
        /// </summary>
        /// <param name="imag">输入一个bitmap格式的图片</param>
        /// <param name="red">R值</param>
        /// <param name="green">G值</param>
        /// <param name="blue">B值</param>
        private void operate_img_By_RGB(Bitmap imag,int red, int green, int blue)
        {
            Rectangle rect = new Rectangle(0, 0, imag.Width, imag.Height);
            BitmapData bmpdata = imag.LockBits(rect, ImageLockMode.ReadWrite, imag.PixelFormat);
            IntPtr ptr = bmpdata.Scan0;
            int bytes = bmpdata.Height * bmpdata.Stride;
            byte[] Rgb_array = new byte[bytes];
            Marshal.Copy(ptr, Rgb_array, 0, bytes);
            double redPercent = red / 100.0;
            double greenPercent = green / 100.0;
            double bluePercent = blue / 100.0;
            
            for (int i = 0; i < Rgb_array.Length; i += 4)
            {
                if (redPercent <= 0)
                {
                    Rgb_array[i + 2] = (byte)(Rgb_array[i + 2] * (1.0 + redPercent));
                }
                else
                {
                    Rgb_array[i + 2] = (byte)(255.0 - (1.0 - redPercent) * Rgb_array[i + 2]);
                }
                if (greenPercent <= 0)
                {
                    Rgb_array[i + 1] = (byte)(Rgb_array[i + 1] * (1.0 + greenPercent));
                }
                else
                {
                    Rgb_array[i + 1] = (byte)(255.0 - (1.0 - greenPercent) * Rgb_array[i + 1]);
                }
                if (bluePercent <= 0)
                {
                    Rgb_array[i] = (byte)(Rgb_array[i] * (1.0 + bluePercent));
                }
                else
                {
                    Rgb_array[i] = (byte)(255.0 - (1.0 - bluePercent) * Rgb_array[i]);
                }

            }
            Marshal.Copy(Rgb_array, 0, ptr, bytes);
            imag.UnlockBits(bmpdata);
        }

        /// <summary>
        /// 灰度化函数
        /// </summary>
        /// <param name="imag">输入一个Bitmap格式的图片</param>
        private void operate_img_Graylize(Bitmap imag)
        {
            Rectangle rect = new Rectangle(0, 0, imag.Width, imag.Height);
            BitmapData bmpdata = imag.LockBits(rect, ImageLockMode.ReadWrite, imag.PixelFormat);
            IntPtr ptr = bmpdata.Scan0;
            int bytes = bmpdata.Height * bmpdata.Stride;
            byte[] Rgb_array = new byte[bytes];
            Marshal.Copy(ptr, Rgb_array, 0, bytes);
            double temp = 0;
            for (int i = 0; i < Rgb_array.Length; i += 4)
            {
                //加权处理
                temp = Rgb_array[i + 2] * 0.299 + Rgb_array[i + 1] * 0.587 + Rgb_array[i] * 0.114;
                Rgb_array[i] = Rgb_array[i + 1] = Rgb_array[i + 2] = (byte)temp;
            }
            Marshal.Copy(Rgb_array, 0, ptr, bytes);
            imag.UnlockBits(bmpdata);
        }

        /// <summary>
        /// 内存法法处理翻转
        /// </summary>
        /// <param name="imag"></param>
        /// <param name="type"></param>
        private void operate_img_reverse(Bitmap imag, reverse_type type)
        {
            Rectangle rect = new Rectangle(0, 0, imag.Width, imag.Height);
            BitmapData bmpData = imag.LockBits(rect, ImageLockMode.ReadWrite, imag.PixelFormat);
            int width = bmpData.Width;
            int height = bmpData.Height;
            int bytes = bmpData.Stride * height;
            byte[] Rgb_array = new byte[bytes];
            IntPtr ptr = bmpData.Scan0;
            Marshal.Copy(ptr, Rgb_array, 0, bytes);
            int stride = bmpData.Stride;
            if (type == reverse_type.straight)
            {
                for (int i = 0; i < stride / 2; i += 4)
                {
                    //遍历每一列，交换对应行，例如交换第一列和最后一列的 rgb值
                    for (int j = 0; j < height; j++)
                    {
                        swap(ref Rgb_array[j * stride + i], ref Rgb_array[(j + 1) * stride - 4 - i]);
                        swap(ref Rgb_array[j * stride + i + 1], ref Rgb_array[(j + 1) * stride - 4 - i + 1]);
                        swap(ref Rgb_array[j * stride + i + 2], ref Rgb_array[(j + 1) * stride - 4 - i + 2]);
                        swap(ref Rgb_array[j * stride + i + 3], ref Rgb_array[(j + 1) * stride - 4 - i + 3]);
                    }
                }
            }
            if (type == reverse_type.vertical)
            {
                for (int i = 0; i < stride; i += 4)
                {
                    for (int j = 0; j < height/2; j++)
                    {
                        swap(ref Rgb_array[j * stride + i], ref Rgb_array[(height - j-1) * stride + i]);
                        swap(ref Rgb_array[j * stride + i + 1], ref Rgb_array[(height - j-1) * stride + i + 1]);
                        swap(ref Rgb_array[j * stride + i + 2], ref Rgb_array[(height - j-1) * stride + i + 2]);
                        swap(ref Rgb_array[j * stride + i + 3], ref Rgb_array[(height - j-1) * stride + i + 3]);
                    }
                }
            }
            Marshal.Copy(Rgb_array, 0, ptr, bytes);
            imag.UnlockBits(bmpData);
        }

        /// <summary>
        /// 交换函数
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        void swap(ref byte first, ref byte second)
        {
            byte temp = first;
            first = second;
            second = temp;
        }


        /// <summary>
        /// 灰度化和去灰度化radiobutton  
        /// </summary>
        private bool IsGraylize_radioButton_checked = false;
        private Bitmap tempImag_unGraylize;
        bool set_unGraylize = false;
        private void Graylize_radioButton_Click(object sender, EventArgs e)
        {
            if (currentImag == null)
                return;
            if (!set_unGraylize)
            {
                Rectangle rect = new Rectangle(0, 0, currentImag.Width, currentImag.Height);
                tempImag_unGraylize = currentImag.Clone(rect, currentImag.PixelFormat);
                set_unGraylize = true;
            }
            if (!IsGraylize_radioButton_checked)
            {
                operate_img_Graylize(currentImag);
                pictureBox.Image = currentImag;
            }
            if (IsGraylize_radioButton_checked)
            {
                Rectangle rect = new Rectangle(0, 0, currentImag.Width, currentImag.Height);
                currentImag = tempImag_unGraylize.Clone(rect, tempImag_unGraylize.PixelFormat);
                pictureBox.Image = currentImag;
            }

            IsGraylize_radioButton_checked = !IsGraylize_radioButton_checked;
            Graylize_radioButton.Checked = IsGraylize_radioButton_checked;
        }

        private void trackBar_R_Scroll(object sender, EventArgs e)
        {
            setRed(trackBar_R.Value);
        }

        private void trackBar_G_Scroll(object sender, EventArgs e)
        {
            int num = trackBar_G.Value;
            setGreen(trackBar_G.Value);
        }

        private void trackBar_B_Scroll(object sender, EventArgs e)
        {
            setBlue(trackBar_B.Value);
        }


        void setGreen(int key)
        {
            if (currentImag == null)
            {
                return;
            }
            Rectangle rect = new Rectangle(0, 0, currentImag.Width, currentImag.Height);
            Bitmap Rgb_tempImag = currentImag.Clone(rect, currentImag.PixelFormat);
            trackBar_G.Value = key;
            textBox_G.Text = key.ToString();
            operate_img_By_RGB(Rgb_tempImag, trackBar_R.Value, trackBar_G.Value, trackBar_B.Value);
            pictureBox.Image = Rgb_tempImag;
        }
        void setBlue(int key)
        {
            if (currentImag == null)
            {
                return;
            }
            Rectangle rect = new Rectangle(0, 0, currentImag.Width, currentImag.Height);
            Bitmap Rgb_tempImag = currentImag.Clone(rect, currentImag.PixelFormat);
            trackBar_B.Value = key;
            textBox_B.Text = key.ToString();
            operate_img_By_RGB(Rgb_tempImag, trackBar_R.Value, trackBar_G.Value, trackBar_B.Value);
            pictureBox.Image = Rgb_tempImag;
        }
        void setRed(int key)
        {
            if (currentImag == null)
            {
                return;
            }
            Rectangle rect = new Rectangle(0, 0, currentImag.Width, currentImag.Height);
            Bitmap Rgb_tempImag = currentImag.Clone(rect, currentImag.PixelFormat);
            trackBar_R.Value = key;
            textBox_R.Text = key.ToString();
            operate_img_By_RGB(Rgb_tempImag, trackBar_R.Value, trackBar_G.Value, trackBar_B.Value);
            pictureBox.Image = Rgb_tempImag;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            bool isSave = true;
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Title = "图片保存";
            saveImageDialog.Filter = @"jpeg|*.jpg|bmp|*.bmp|png|*.png";

            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                output_Filepath = saveImageDialog.FileName.ToString();

                if (output_Filepath != "" && output_Filepath != null)
                {
                    string fileExtName = output_Filepath.Substring(output_Filepath.LastIndexOf(".") + 1).ToString();

                    ImageFormat imgformat = null;

                    if (fileExtName != "")
                    {
                        switch (fileExtName)
                        {
                            case "jpg":
                                imgformat = ImageFormat.Jpeg;
                                break;
                            case "bmp":
                                imgformat = ImageFormat.Bmp;
                                break;
                            case "png":
                                imgformat = ImageFormat.Gif;
                                break;
                            default:
                                MessageBox.Show("只能存取为: jpg,bmp,png 格式");
                                isSave = false;
                                break;
                        }

                    }

                    //默认保存为png格式  
                    if (imgformat == null)
                    {
                        imgformat = ImageFormat.Jpeg;
                    }

                    if (isSave)
                    {
                        try
                        {
                            pictureBox.Image.Save(output_Filepath, imgformat);
                        }
                        catch
                        {
                            MessageBox.Show("保存失败,你还没有截取过图片或已经清空图片!");
                        }
                    }

                }

            }
        }

        //正则表达式来判断一个字符串是否为数字
        public static bool IsNumeric(string strNumber)
        {
            Regex IsInt = new Regex("^-?\\d+$");
            Regex IsFloat = new Regex("^(-?\\d+)(\\.\\d+)?$");
            return IsInt.IsMatch(strNumber) || IsFloat.IsMatch(strNumber);

        }

        private void rotation_box_TextChanged(object sender,KeyEventArgs e)
        {
            if (currentImag == null)
                return;
            if(e.KeyCode == Keys.Control || e.KeyCode == Keys.Enter)
            {
                bool isnumber = IsNumeric(rotation_box.Text);
                if (isnumber)
                {
                    float angle = (float)Convert.ToDouble(rotation_box.Text);
                    rotation_box.Text += "°";
                    Bitmap img_temp = operate_img_by_angle(currentImag, angle);
                    pictureBox.Image = img_temp;
                    currentImag = img_temp;
                    
                }
                else
                {
                    MessageBox.Show("please input a number");
                }
            }
           
        }
    }
}
