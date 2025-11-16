using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using TwentyOne;

namespace Casino.TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Who am I speaking with today?", casinoName);
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions) // The exceptions are anomalies that occur during the execution of a program.
                {
                    Console.WriteLine(exception.Id + " | ");
                    Console.WriteLine(exception.ExceptionType + " | ");
                    Console.WriteLine(exception.ExceptionMessage + " | ");
                    Console.WriteLine(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.ReadLine();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new(@"C:\Users\scall\logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error has occured. Please contact your System Administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source =(localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame;
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False;
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite;
                                        MultiSubnetFailover = False";
             
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)";

            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand commamnd = new(queryString, connection);
                commamnd.Parameters.Add("@ExceptionType", System.Data.SqlDbType.VarChar);
                commamnd.Parameters.Add("@ExceptionMessage", System.Data.SqlDbType.VarChar);
                commamnd.Parameters.Add("@TimeStamp", System.Data.SqlDbType.DateTime);

                commamnd.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                commamnd.Parameters["@ExceptionMessage"].Value = ex.Message;
                commamnd.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                commamnd.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = TwentyOneGame; 
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                        MultiSubnetFailover = False";

            string quertString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = [];

            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(quertString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }

            return Exceptions;
        }
    }
}