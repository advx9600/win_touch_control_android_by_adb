using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchAndroidByAdb
{
    class TbConfigDataCheck
    {
        private static Command cmd = new Command();
        public static Boolean dataCheck(FormStart form, String w1, String h1, String scale1)
        {
            int w = 0;
            int h = 0;
            float scale = 0;
            try
            {
                h = int.Parse(h1);
                w = int.Parse(w1);
                scale = float.Parse(scale1);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            if (w < 100 || w > 2048)
            {
                MessageBox.Show("width must <= 2048 and >= 100");
            }
            else if (h < 100 || h > 2048)
            {
                MessageBox.Show("height must <= 2048 and >= 100");
            }
            else if (scale < 0.3 || scale > 3)
            {
                MessageBox.Show("scale must >= 0.3 and <= 3");
            }
            else
            {
                form.mWidth = w.ToString();
                form.mHeight = h.ToString();
                form.mScale = scale.ToString();
                return true;
            }

            return false;
        }

        public static void resetSize(FormStart form, PictureBox pic)
        {
            int h = int.Parse(form.mHeight);
            int w = int.Parse(form.mWidth);
            float scale = float.Parse(form.mScale);
            const int topW = 588;
            const int topH = 100;
            const int padding = 50;

            if (w * scale > topW - padding)
            {
                form.Width = (int)(w * scale) + padding;
            }
            else
            {
                form.Width = topW;
            }
            form.Height = topH + (int)(scale * h) + padding;

            pic.Width = (int)(w * scale);
            pic.Height = (int)(h * scale);
        }


        private volatile bool mIsFlash;

        public TbConfigDataCheck(PictureBox pictureBoxMain)
        {
            var t1 = new Thread(new ParameterizedThreadStart(doAction));
            t1.IsBackground = true;
            t1.Start(pictureBoxMain);
        }
        private void doAction(Object picture)
        {
            mIsFlash = true;
            PictureBox pic = (PictureBox)picture;
            const String picName = "screenshot.png";
            while (true)
            {
                Thread.Sleep(1000);
                if (mIsFlash)
                {
                    mIsFlash = false;
                    pic.Image = null;
                    String getMsg;
                    getMsg = Command.Execute("adb shell /system/bin/screencap -p /sdcard/screenshot.png", 500);
                    getMsg = Command.Execute("adb pull /sdcard/screenshot.png  " + picName, 500);
                    if (File.Exists(picName))
                    {
                        var img = Image.FromFile(picName);
                        if (img.Width > img.Height && pic.Width < pic.Height || (img.Width < img.Height && pic.Width > pic.Height))
                        {
                            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        }
                        pic.Image = img;
                        File.Delete(picName);
                    }
                    else
                    {
                        MessageBox.Show("adb may not connected");
                    }
                                        
                }
            }
        }
        public void doAction(PreviewKeyDownEventArgs e)
        {
            Boolean isFound = true;
            switch (e.KeyCode)
            {
                case Keys.Back:
                    cmd.RunCmd("adb shell input keyevent 4");
                    break;
                case Keys.Escape:
                    cmd.RunCmd("adb shell input keyevent 3");
                    break;
                case Keys.F5:
                    break;
                default:
                    isFound = false;
                    break;
            }

            if (isFound)
            {
                mIsFlash = true;
            }
        }
        private void doRightClick(String x,String y)
        {
            mIsFlash = true;
        }
        public void doAction(String x, String y)
        {
            doRightClick(x,y);
        }
        public void doAction(FormStart form, string mX1, string mY1, string mX2, string mY2)
        {
            int x1 = int.Parse(mX1);
            int x2 = int.Parse(mX2);
            int y1 = int.Parse(mY1);
            int y2 = int.Parse(mY2);

            int w = int.Parse(form.mWidth);
            int h = int.Parse(form.mHeight);
            float s = float.Parse(form.mScale);

            if (x2 < 0 || x2 > w * s || y2 < 0 || y2 > h * w)
            {
                return;
            }

            int downX = (int)(x1 / s);
            int downY = (int)(y1 / s);
            int upX = (int)(x2 / s);
            int upY = (int)(y2 / s);

            if (x1 == x2 && y1 == y2)
            {
                cmd.RunCmd("adb shell input tap  " + downX + " " + downY);
            }
            else
            {
                //MessageBox.Show("swap "+downX+" "+downY+" "+upX+" "+upY);
                cmd.RunCmd("adb shell input swipe  " + downX + " " + downY + "  " + upX + " " + upY);
            }
            mIsFlash = true;
        }
    }
}
