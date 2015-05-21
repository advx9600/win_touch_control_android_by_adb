using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SQLite;
using System.IO;

namespace TouchAndroidByAdb
{
    class MySave
    {
        private const string DATABASENAME = "my_save.db";
        private const string CONNECT_STRING = "Data Source=" + DATABASENAME + ";Version=3;";

        // table name
        public const string TB_CONFIG = "tb_config";
        private SQLiteConnection conn;


        private void insertData()
        {
            System.Data.SQLite.SQLiteCommand cmd = new System.Data.SQLite.SQLiteCommand();
            string sql = "CREATE TABLE "+TB_CONFIG+"(id INTEGER PRIMARY KEY autoincrement,key varchar(50),val varchar(50))";
            cmd.CommandText = sql;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();

            {
                var list = TBConfig.getInitList();
                for (int i = 0; i < list.Count(); i++)
                {
                    var data = list.ElementAt(i);
                    sql = "insert into "+TB_CONFIG+"(key,val)values('" + data.key + "','" + data.val + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }

        }
        private void check()
        {
            if (File.Exists(DATABASENAME))
            {
                return;
            }
            SQLiteConnection.CreateFile(DATABASENAME);
            conn = new System.Data.SQLite.SQLiteConnection(CONNECT_STRING);

            conn.Open();
            insertData();
            conn.Close();

        }
        public Boolean open()
        {
            check();
            conn = new System.Data.SQLite.SQLiteConnection(CONNECT_STRING);
            conn.Open();
            return true;
        }
        public void close()
        {
            conn.Close();
        }

        public SQLiteDataReader getReader(String sql)
        {
            Console.WriteLine(sql);
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();            
            return reader;
        }

        public int exeNonQuery(String sql)
        {
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            return command.ExecuteNonQuery();
        }
    }
}
