using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchAndroidByAdb
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }


        public String mWidth;
        public String mHeight;
        public String mScale;
        private TbConfigDataCheck mTbCheck;

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (!TbConfigDataCheck.dataCheck(this, textBoxWidth.Text.ToString(), textBoxHeight.Text.ToString(), textBoxScale.Text.ToString()))
            {
                return;
            }

            TBConfig.setWidth(mWidth);
            TBConfig.setHeight(mHeight);
            TBConfig.setScale(mScale);
            resetSize();

        }

        private void resetSize()
        {
            TbConfigDataCheck.resetSize(this, pictureBoxMain);
        }
        private void FormStart_Load(object sender, EventArgs e)
        {
            mHeight = textBoxHeight.Text = TBConfig.getHeight();
            mWidth = textBoxWidth.Text = TBConfig.getWidth();
            mScale = textBoxScale.Text = TBConfig.getScale();

            resetSize();

            mTbCheck = new TbConfigDataCheck(pictureBoxMain);
        }

        private string mX1;
        private string mX2;
        private String mY1;
        private String mY2;
        private void pictureBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            mX1 = textBoxX.Text = e.X + "";
            mY1 = textBoxY.Text = e.Y + "";
            if (!pictureBoxMain.Focused)
                pictureBoxMain.Focus();
        }
        private void pictureBoxMain_MouseUp(object sender, MouseEventArgs e)
        {
            mX2 = textBoxX2.Text = e.X + "";
            mY2 = textBoxY2.Text = e.Y + "";
            if (e.Button == MouseButtons.Right)
            {
                mTbCheck.doAction(mX2, mY2);
            }
            else
            {                
                mTbCheck.doAction(this, mX1, mY1, mX2, mY2);
            }
        }

        private void pictureBoxMain_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            mTbCheck.doAction(e);
        }

        private void btn_save_pic_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "*.jpg,*.jpeg,*.bmp,*.png|*.jpg,*.jpeg,*.bmp,*.png";
            saveFile.InitialDirectory = TBConfig.getPreSaveDir();
            if (saveFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String fileName = saveFile.FileName;
                this.pictureBoxMain.Image.Save(fileName); 
                TBConfig.setPreSaveDir(Path.GetDirectoryName(fileName));
            }
        }
    }
}
