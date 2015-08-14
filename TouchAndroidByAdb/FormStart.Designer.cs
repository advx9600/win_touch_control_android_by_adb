namespace TouchAndroidByAdb
{
    partial class FormStart
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.buttonOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxScale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.btn_save_pic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(472, 4);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "ok";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "height";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(223, 6);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(65, 21);
            this.textBoxHeight.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "width";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(46, 6);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(65, 21);
            this.textBoxWidth.TabIndex = 4;
            // 
            // textBoxScale
            // 
            this.textBoxScale.Location = new System.Drawing.Point(381, 6);
            this.textBoxScale.Name = "textBoxScale";
            this.textBoxScale.Size = new System.Drawing.Size(65, 21);
            this.textBoxScale.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "scale";
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMain.Location = new System.Drawing.Point(15, 89);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(524, 247);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 7;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseDown);
            this.pictureBoxMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMain_MouseUp);
            this.pictureBoxMain.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBoxMain_PreviewKeyDown);
            // 
            // textBoxY
            // 
            this.textBoxY.Enabled = false;
            this.textBoxY.Location = new System.Drawing.Point(138, 33);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(40, 21);
            this.textBoxY.TabIndex = 8;
            // 
            // textBoxX
            // 
            this.textBoxX.Enabled = false;
            this.textBoxX.Location = new System.Drawing.Point(70, 33);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(41, 21);
            this.textBoxX.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_save_pic);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxX2);
            this.panel1.Controls.Add(this.textBoxY2);
            this.panel1.Controls.Add(this.textBoxHeight);
            this.panel1.Controls.Add(this.textBoxX);
            this.panel1.Controls.Add(this.buttonOK);
            this.panel1.Controls.Add(this.textBoxY);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxScale);
            this.panel1.Controls.Add(this.textBoxWidth);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 65);
            this.panel1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "down";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "up";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Enabled = false;
            this.textBoxX2.Location = new System.Drawing.Point(235, 33);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(41, 21);
            this.textBoxX2.TabIndex = 11;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Enabled = false;
            this.textBoxY2.Location = new System.Drawing.Point(303, 33);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(40, 21);
            this.textBoxY2.TabIndex = 10;
            // 
            // btn_save_pic
            // 
            this.btn_save_pic.Location = new System.Drawing.Point(400, 33);
            this.btn_save_pic.Name = "btn_save_pic";
            this.btn_save_pic.Size = new System.Drawing.Size(75, 23);
            this.btn_save_pic.TabIndex = 14;
            this.btn_save_pic.Text = "save pic";
            this.btn_save_pic.UseVisualStyleBackColor = true;
            this.btn_save_pic.Click += new System.EventHandler(this.btn_save_pic_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 363);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.Load += new System.EventHandler(this.FormStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Button btn_save_pic;
    }
}

