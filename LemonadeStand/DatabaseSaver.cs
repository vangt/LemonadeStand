using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class DatabaseSaver
    {
        SqlConnection connection;
        public DatabaseSaver()
        {
            connection = new SqlConnection("Server=TSHWMSIM;Database=LemonadeStand;Integrated Security=true");
        }

        public void Save(string name, double net)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand($"INSERT INTO Scores VALUES ('{playerName}', '{playerNet}')", connection);
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("Game Saved");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();
        }
    }
}
