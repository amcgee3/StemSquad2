using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stem_Squad_Gaming_Fanatics2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

        public static SQLiteConnection connect()
        {
            SQLiteConnection conn;
            string connect = @"Data Source = C:\\Users\\amcge\\source\\repos\\Stem_Squad_Gaming_Fanatics2\\HATCH_2025.db";
            conn = new SQLiteConnection(connect);

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return conn;

        }
    }
}
