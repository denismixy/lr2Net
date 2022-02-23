using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace lr2Net
{
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            MySqlConnection mySqlConnection = DBMySQLUtils.GetDBConnection("net.mysql.database.azure.com", 3306, "lr1", "denis", "2265ddeeE");
            try {
                mySqlConnection.Open();
            } catch (Exception e) {
                Console.WriteLine(e.StackTrace);
            }
            MySqlCommand command = mySqlConnection.CreateCommand();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(command));


            /* MySqlConnection mySqlConnection = DBMySQLUtils.GetDBConnection("net.mysql.database.azure.com", 3306, "lr1", "denis", "2265ddeeE");
             try {
                 mySqlConnection.Open();
             } catch (Exception e) {
                 Console.WriteLine(e.StackTrace);
             }
             MySqlCommand command = mySqlConnection.CreateCommand();
             Visit visit = new Visit();
             visit.Fio = "check";
             visit.CarBrand = "123";
             Visit newVisit = new Visit();
             newVisit.Id = 4.ToString();
             command.CommandText = QueryBuilder.DeleteVisit(newVisit);
             MySqlDataReader mySqlDataReader = command.ExecuteReader();
             string str = "";
             Console.WriteLine(mySqlDataReader.ToString());*/


        }
    }
}
