using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Rental_Luxury_Cars.Form1;
using System.Windows.Forms;

namespace Rental_Luxury_Cars
{
    public class dataH
    {
        public static string ConStr { get; set; }
        public static string nameUser { get; set; }
        public static string curVal0 { get; set; }
        public static string keyName { get; set; }
        public static BindingSource bs1 { get; set; }
        public static BindingSource bs2 { get; set; }

        public static DataTable myfunDt(string commandString)
        {
            DataTable dt = new DataTable();

            ConStr = "server = 127.0.0.1; port = 3306; database = carsrental;" + "user = marko; password = 7722; charset = cp1251;";

            using (MySqlConnection con = new MySqlConnection(dataH.ConStr))
            {
                MySqlCommand cmd = new MySqlCommand(commandString, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dt.Load(dr);
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to connect to SQL server! \nCheck for internet availability...",
                        ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        }
    }
}
