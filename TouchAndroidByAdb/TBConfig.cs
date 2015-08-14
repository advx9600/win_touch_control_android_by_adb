using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchAndroidByAdb
{

    class TBConfig
    {
        public const String SEG_WIDTH = "width";
        public const String SEG_HEIGHT = "height";
        public const String SEG_SCALE = "scale";
        public const String SEG_PRE_SAVE_DIR = "pre_save_dir";
        public static List<Data> getInitList()
        {
            List<Data> list = new List<Data>();

            list.Add(new Data(SEG_WIDTH, "1024"));
            list.Add(new Data(SEG_HEIGHT, "600"));
            list.Add(new Data(SEG_SCALE, "1"));
            list.Add(new Data(SEG_PRE_SAVE_DIR, ""));
            return list;
        }
        public class Data
        {
            public String key;
            public String val;
            public Data(String key, String val)
            {
                this.key = key;
                this.val = val;
            }
        }

        public static void setFiled(String field, String val)
        {
            MySave db = new MySave();            
            db.open();
            db.exeNonQuery("update "+MySave.TB_CONFIG+" set val = '"+val+"' where key='"+field+"'");
            db.close();
        }
        public static String getFiled(String field)
        {
            MySave db = new MySave();
            db.open();
            var reader = db.getReader("select val from " + MySave.TB_CONFIG + " where key='" + field + "'");
            String val = "";
            if (reader.Read())
                val = reader.GetString(0);
            reader.Close();
            db.close();
            return val;
        }

        public static String getHeight()
        {
            return getFiled(SEG_HEIGHT);
        }
        public static void setHeight(String val)
        {
            setFiled(SEG_HEIGHT, val);
        }

        public static String getWidth()
        {
            return getFiled(SEG_WIDTH);
        }
        public static void setWidth(String val)
        {
            setFiled(SEG_WIDTH, val);
        }
        public static String getScale()
        {
            return getFiled(SEG_SCALE);
        }
        public static void setScale(String val)
        {
            setFiled(SEG_SCALE, val);
        }
        public static void setPreSaveDir(String val)
        {
            setFiled(SEG_PRE_SAVE_DIR, val);
        }
        public static String getPreSaveDir()
        {
            return getFiled(SEG_PRE_SAVE_DIR);
        }
    }
}
