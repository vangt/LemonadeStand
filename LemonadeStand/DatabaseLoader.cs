using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class DatabaseLoader
    {
        SqlConnection connection;
        public DatabaseLoader()
        {
            connection = new SqlConnection("Server=TSHWMSIM;Database=LemonadeStand;Integrated Security=true");
        }

        public void LoadGame()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT Player_Name, Player_Net FROM Scores", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("Player: {0} \nTotal Net: {1}", reader.GetString(0), reader.GetString(1));
                    Console.WriteLine("+++++++++++++++++");
                }
                reader.Close();
                connection.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
