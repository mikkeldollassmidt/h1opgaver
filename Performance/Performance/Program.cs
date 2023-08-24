using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading;

namespace Performance
{
    internal class Program
    {
        // Public file path string
        public static string fileNamePath = "C:\\Performance\\performanceTable.txt";

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("- MENU -\r\n1. Create a million random numbers between 0 - 9999.\r\n2. Show table.\r\n3. Drop table.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        RandomNumberCreate();
                        break;
                    case ConsoleKey.D2:
                        ShowPerformanceTable();
                        break;
                    case ConsoleKey.D3:
                        DropTable();
                        break;
                    default:
                        Console.SetCursorPosition(20, 13);
                        Console.WriteLine("Prøv en anden tast.");
                        Thread.Sleep(500);
                        continue;
                }

            }
        }
        static void DropTable()
        {
            // Method drops table
            Console.Clear();
            string dropPerformanceTable = "DROP TABLE PerformanceTable";

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(dropPerformanceTable, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Table dropped. Press any button to go back.");
            Console.ReadLine();
            Main();
        }
        static void PopulateTextFile(string path)
        {
            // Method writes a list of a million random numbers between 0-9999
            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 1000000; i++)
            {
                sb.Append($"{i + 1}, {random.Next(0, 10000)} \r\n");
            }

            File.AppendAllText(fileNamePath, sb.ToString());

            Console.WriteLine("Text file populated. ");
        }
        static void CreateTextFile(string path)
        {
            // Creates a file if the txt file isn¨t created yet.
            if (!File.Exists(fileNamePath))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("");
                }

                Console.WriteLine("Text file created or extant. ");
            }
        }
        static void RandomNumberCreate()
        {
            // Brain method.Creates, deletes and populates. This method binds everything together.
            Console.Clear();
            Console.WriteLine("Creating numbers.. press enter to complete");

            string captureRandomNumbersWithSyntax = "";

            bool whileCreateFileOrDelete = true;

            while (whileCreateFileOrDelete)
            {
                if (File.Exists(fileNamePath))
                {
                    File.Delete(fileNamePath);
                    CreateTextFile(fileNamePath);
                    whileCreateFileOrDelete = true;
                }
                else
                {
                    CreateTextFile(fileNamePath);
                    PopulateTextFile(fileNamePath);
                    whileCreateFileOrDelete = false;
                }
            }

            Console.Clear();
            Console.WriteLine("Done.");
            Console.ReadLine();
            Main();
        }
        static void ShowPerformanceTable()
        {
            // Showing the table
            Console.Clear();
            string showTableString = $"SELECT * FROM PerformanceTable";

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(showTableString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                Console.SetCursorPosition(8,0);
                Console.WriteLine("ID:     randomNumbers:");
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}",
                        reader[0], reader[1]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any button to go back.");
            Console.ReadLine();
            Main();
        }
        /*static void WriteToDatabase()
        {
            string captureTextFileContent = File.ReadAllText(fileNamePath);

            string queryString = $"INSERT INTO PerformanceTable VALUES " + captureTextFileContent;

            SqlConnection connection = GetConnection();
            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine("\t{0}\t{1}\t{3}",
                        reader[0], reader[1], reader[2]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }*/
        static SqlConnection GetConnection()
        {
            // Connects to database.
            return new SqlConnection("Server=localhost;Database=Performance;Trusted_Connection = True");
        }
    }
}
