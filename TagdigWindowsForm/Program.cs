using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace TagdigWindowsForm
{
    static class Program
    {
        public static UjTag ujTag = null;
        public static TagModositas tagModositas = null;
        public static UjBefizetes ujBefizetes = null;
        public static BefizetesLekerdezes befizetesLekerdezes = null;
        public static Form1 nyito = null;
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;

        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();

            }
            catch(MySqlException ex) 
            {
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ujTag = new UjTag();
            tagModositas = new TagModositas();
            ujBefizetes = new UjBefizetes();
            befizetesLekerdezes = new BefizetesLekerdezes();
            nyito = new Form1();
            Application.Run(nyito);
        }
    }
}
