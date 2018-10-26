using System.Windows.Forms;

namespace GraphOpatateDemo
{
    partial class GraphDemo
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.file_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.input_item = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog_input = new System.Windows.Forms.OpenFileDialog();
            this.button_RL_reverse = new System.Windows.Forms.Button();
            this.button_turnLeft = new System.Windows.Forms.Button();
            this.button_turnRight = new System.Windows.Forms.Button();
            this.button_UD_reverse = new System.Windows.Forms.Button();
            this.button_resetImg = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Graylize_radioButton = new System.Windows.Forms.RadioButton();
            this.label_R = new System.Windows.Forms.Label();
            this.trackBar_R = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel_RGB = new System.Windows.Forms.TableLayoutPanel();
            this.label_B = new System.Windows.Forms.Label();
            this.trackBar_G = new System.Windows.Forms.TrackBar();
            this.label_G = new System.Windows.Forms.Label();
            this.textBox_R = new System.Windows.Forms.TextBox();
            this.trackBar_B = new System.Windows.Forms.TrackBar();
            this.textBox_G = new System.Windows.Forms.TextBox();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.table_funditional_method = new System.Windows.Forms.TableLayoutPanel();
            this.button_save = new System.Windows.Forms.Button();
            this.rotation_box = new System.Windows.Forms.TextBox();
            this.label_angleOfRotation = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).BeginInit();
            this.tableLayoutPanel_RGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).BeginInit();
            this.table_funditional_method.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_menu_item});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(641, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // file_menu_item
            // 
            this.file_menu_item.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.input_item});
            this.file_menu_item.Name = "file_menu_item";
            this.file_menu_item.Size = new System.Drawing.Size(43, 24);
            this.file_menu_item.Text = "file";
            // 
            // input_item
            // 
            this.input_item.Name = "input_item";
            this.input_item.Size = new System.Drawing.Size(122, 26);
            this.input_item.Text = "input";
            this.input_item.Click += new System.EventHandler(this.input_item_Click);
            // 
            // openFileDialog_input
            // 
            this.openFileDialog_input.FileName = "openFileDialog1";
            // 
            // button_RL_reverse
            // 
            this.button_RL_reverse.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.button_RL_reverse.Location = new System.Drawing.Point(87, 3);
            this.button_RL_reverse.Name = "button_RL_reverse";
            this.button_RL_reverse.Size = new System.Drawing.Size(75, 40);
            this.button_RL_reverse.TabIndex = 2;
            this.button_RL_reverse.Text = "⇆";
            this.button_RL_reverse.UseVisualStyleBackColor = true;
            this.button_RL_reverse.Click += new System.EventHandler(this.button_RL_reverse_Click);
            // 
            // button_turnLeft
            // 
            this.button_turnLeft.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.button_turnLeft.Location = new System.Drawing.Point(87, 56);
            this.button_turnLeft.Name = "button_turnLeft";
            this.button_turnLeft.Size = new System.Drawing.Size(75, 40);
            this.button_turnLeft.TabIndex = 3;
            this.button_turnLeft.Text = "↺";
            this.button_turnLeft.UseVisualStyleBackColor = true;
            this.button_turnLeft.Click += new System.EventHandler(this.button_turnLeft_Click);
            // 
            // button_turnRight
            // 
            this.button_turnRight.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.button_turnRight.Location = new System.Drawing.Point(3, 56);
            this.button_turnRight.Name = "button_turnRight";
            this.button_turnRight.Size = new System.Drawing.Size(78, 40);
            this.button_turnRight.TabIndex = 4;
            this.button_turnRight.Text = "↻";
            this.button_turnRight.UseVisualStyleBackColor = true;
            this.button_turnRight.Click += new System.EventHandler(this.button_turnRight_Click);
            // 
            // button_UD_reverse
            // 
            this.button_UD_reverse.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.button_UD_reverse.Location = new System.Drawing.Point(3, 3);
            this.button_UD_reverse.Name = "button_UD_reverse";
            this.button_UD_reverse.Size = new System.Drawing.Size(78, 40);
            this.button_UD_reverse.TabIndex = 5;
            this.button_UD_reverse.Text = "⇅";
            this.button_UD_reverse.UseVisualStyleBackColor = true;
            this.button_UD_reverse.Click += new System.EventHandler(this.button_UD_reverse_Click);
            // 
            // button_resetImg
            // 
            this.button_resetImg.Location = new System.Drawing.Point(3, 109);
            this.button_resetImg.Name = "button_resetImg";
            this.button_resetImg.Size = new System.Drawing.Size(78, 40);
            this.button_resetImg.TabIndex = 6;
            this.button_resetImg.Text = "reset";
            this.button_resetImg.UseVisualStyleBackColor = true;
            this.button_resetImg.Click += new System.EventHandler(this.button_resetImg_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(240, 51);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(379, 438);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // Graylize_radioButton
            // 
            this.Graylize_radioButton.AutoSize = true;
            this.Graylize_radioButton.Location = new System.Drawing.Point(15, 51);
            this.Graylize_radioButton.Name = "Graylize_radioButton";
            this.Graylize_radioButton.Size = new System.Drawing.Size(109, 31);
            this.Graylize_radioButton.TabIndex = 9;
            this.Graylize_radioButton.Text = "Graylize";
            this.Graylize_radioButton.UseVisualStyleBackColor = true;
            this.Graylize_radioButton.Click += new System.EventHandler(this.Graylize_radioButton_Click);
            // 
            // label_R
            // 
            this.label_R.AutoSize = true;
            this.label_R.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label_R.Location = new System.Drawing.Point(3, 0);
            this.label_R.Name = "label_R";
            this.label_R.Size = new System.Drawing.Size(26, 27);
            this.label_R.TabIndex = 10;
            this.label_R.Text = "R";
            // 
            // trackBar_R
            // 
            this.trackBar_R.Location = new System.Drawing.Point(35, 3);
            this.trackBar_R.Maximum = 100;
            this.trackBar_R.Minimum = -100;
            this.trackBar_R.Name = "trackBar_R";
            this.trackBar_R.Size = new System.Drawing.Size(119, 52);
            this.trackBar_R.TabIndex = 11;
            this.trackBar_R.Scroll += new System.EventHandler(this.trackBar_R_Scroll);
            // 
            // tableLayoutPanel_RGB
            // 
            this.tableLayoutPanel_RGB.ColumnCount = 3;
            this.tableLayoutPanel_RGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.07895F));
            this.tableLayoutPanel_RGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.92105F));
            this.tableLayoutPanel_RGB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel_RGB.Controls.Add(this.label_B, 0, 2);
            this.tableLayoutPanel_RGB.Controls.Add(this.trackBar_G, 1, 1);
            this.tableLayoutPanel_RGB.Controls.Add(this.label_R, 0, 0);
            this.tableLayoutPanel_RGB.Controls.Add(this.label_G, 0, 1);
            this.tableLayoutPanel_RGB.Controls.Add(this.trackBar_R, 1, 0);
            this.tableLayoutPanel_RGB.Controls.Add(this.textBox_R, 2, 0);
            this.tableLayoutPanel_RGB.Controls.Add(this.trackBar_B, 1, 2);
            this.tableLayoutPanel_RGB.Controls.Add(this.textBox_G, 2, 1);
            this.tableLayoutPanel_RGB.Controls.Add(this.textBox_B, 2, 2);
            this.tableLayoutPanel_RGB.Location = new System.Drawing.Point(12, 329);
            this.tableLayoutPanel_RGB.Name = "tableLayoutPanel_RGB";
            this.tableLayoutPanel_RGB.RowCount = 3;
            this.tableLayoutPanel_RGB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_RGB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_RGB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel_RGB.Size = new System.Drawing.Size(222, 160);
            this.tableLayoutPanel_RGB.TabIndex = 14;
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label_B.Location = new System.Drawing.Point(3, 116);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(26, 27);
            this.label_B.TabIndex = 16;
            this.label_B.Text = "B";
            // 
            // trackBar_G
            // 
            this.trackBar_G.Location = new System.Drawing.Point(35, 61);
            this.trackBar_G.Maximum = 100;
            this.trackBar_G.Minimum = -100;
            this.trackBar_G.Name = "trackBar_G";
            this.trackBar_G.Size = new System.Drawing.Size(119, 52);
            this.trackBar_G.TabIndex = 14;
            this.trackBar_G.Scroll += new System.EventHandler(this.trackBar_G_Scroll);
            // 
            // label_G
            // 
            this.label_G.AutoSize = true;
            this.label_G.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.label_G.Location = new System.Drawing.Point(3, 58);
            this.label_G.Name = "label_G";
            this.label_G.Size = new System.Drawing.Size(26, 27);
            this.label_G.TabIndex = 13;
            this.label_G.Text = "G";
            // 
            // textBox_R
            // 
            this.textBox_R.Location = new System.Drawing.Point(174, 3);
            this.textBox_R.Name = "textBox_R";
            this.textBox_R.ReadOnly = true;
            this.textBox_R.Size = new System.Drawing.Size(41, 34);
            this.textBox_R.TabIndex = 12;
            // 
            // trackBar_B
            // 
            this.trackBar_B.Location = new System.Drawing.Point(35, 119);
            this.trackBar_B.Maximum = 100;
            this.trackBar_B.Minimum = -100;
            this.trackBar_B.Name = "trackBar_B";
            this.trackBar_B.Size = new System.Drawing.Size(119, 38);
            this.trackBar_B.TabIndex = 15;
            this.trackBar_B.Scroll += new System.EventHandler(this.trackBar_B_Scroll);
            // 
            // textBox_G
            // 
            this.textBox_G.Location = new System.Drawing.Point(174, 61);
            this.textBox_G.Name = "textBox_G";
            this.textBox_G.ReadOnly = true;
            this.textBox_G.Size = new System.Drawing.Size(41, 34);
            this.textBox_G.TabIndex = 17;
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(174, 119);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.ReadOnly = true;
            this.textBox_B.Size = new System.Drawing.Size(42, 34);
            this.textBox_B.TabIndex = 18;
            // 
            // table_funditional_method
            // 
            this.table_funditional_method.ColumnCount = 2;
            this.table_funditional_method.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.96774F));
            this.table_funditional_method.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.03226F));
            this.table_funditional_method.Controls.Add(this.button_UD_reverse, 0, 0);
            this.table_funditional_method.Controls.Add(this.button_RL_reverse, 1, 0);
            this.table_funditional_method.Controls.Add(this.button_turnRight, 0, 1);
            this.table_funditional_method.Controls.Add(this.button_turnLeft, 1, 1);
            this.table_funditional_method.Controls.Add(this.button_save, 1, 2);
            this.table_funditional_method.Controls.Add(this.button_resetImg, 0, 2);
            this.table_funditional_method.Location = new System.Drawing.Point(12, 96);
            this.table_funditional_method.Name = "table_funditional_method";
            this.table_funditional_method.RowCount = 3;
            this.table_funditional_method.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_funditional_method.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_funditional_method.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.table_funditional_method.Size = new System.Drawing.Size(165, 153);
            this.table_funditional_method.TabIndex = 15;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(87, 109);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 40);
            this.button_save.TabIndex = 16;
            this.button_save.Text = "save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // rotation_box
            // 
            this.rotation_box.Location = new System.Drawing.Point(164, 280);
            this.rotation_box.Name = "rotation_box";
            this.rotation_box.Size = new System.Drawing.Size(51, 34);
            this.rotation_box.TabIndex = 16;
            this.rotation_box.KeyUp += new KeyEventHandler(this.rotation_box_TextChanged);
            // 
            // label_angleOfRotation
            // 
            this.label_angleOfRotation.AutoSize = true;
            this.label_angleOfRotation.Location = new System.Drawing.Point(7, 280);
            this.label_angleOfRotation.Name = "label_angleOfRotation";
            this.label_angleOfRotation.Size = new System.Drawing.Size(156, 27);
            this.label_angleOfRotation.TabIndex = 17;
            this.label_angleOfRotation.Text = "Rotation angle:";
            // 
            // GraphDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 554);
            this.Controls.Add(this.label_angleOfRotation);
            this.Controls.Add(this.rotation_box);
            this.Controls.Add(this.table_funditional_method);
            this.Controls.Add(this.tableLayoutPanel_RGB);
            this.Controls.Add(this.Graylize_radioButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GraphDemo";
            this.Text = "Graph Demo";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_R)).EndInit();
            this.tableLayoutPanel_RGB.ResumeLayout(false);
            this.tableLayoutPanel_RGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_B)).EndInit();
            this.table_funditional_method.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem file_menu_item;
        private System.Windows.Forms.ToolStripMenuItem input_item;
        private System.Windows.Forms.OpenFileDialog openFileDialog_input;
        private System.Windows.Forms.Button button_RL_reverse;
        private System.Windows.Forms.Button button_turnLeft;
        private System.Windows.Forms.Button button_turnRight;
        private System.Windows.Forms.Button button_UD_reverse;
        private System.Windows.Forms.Button button_resetImg;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton Graylize_radioButton;
        private System.Windows.Forms.Label label_R;
        private System.Windows.Forms.TrackBar trackBar_R;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_RGB;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.TrackBar trackBar_G;
        private System.Windows.Forms.Label label_G;
        private System.Windows.Forms.TextBox textBox_R;
        private System.Windows.Forms.TrackBar trackBar_B;
        private System.Windows.Forms.TextBox textBox_G;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.TableLayoutPanel table_funditional_method;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.TextBox rotation_box;
        private System.Windows.Forms.Label label_angleOfRotation;
    }
}

