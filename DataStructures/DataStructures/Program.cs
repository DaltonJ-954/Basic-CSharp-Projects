using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] clients = new string[,] { { "Jacob", "Gregory", "Tasha", "Brianna", "Megan", "Paul"}, { "Adrianna", "Naru", "Porter", "Henry", "Wendy", "Zac"} };
            //string[,] company = new string[,] { { "TPNI", "Peske", "Facebook", "AirBNB", "Dunkin", "Localize"}, { "Starbucks", "Wendy's", "Publix", "Google", "Microsoft", "Apple"} };

            for (int i = 0; i < clients.GetLength(0); i++)
            {
                for (int j = 0; j < clients.GetLength(1); j++)
                {
                    Console.WriteLine(clients[i, j]);
                }
            }
            Console.WriteLine();

            int columnIndex = 1;

            int rowCount = clients.GetLength(0);
            int columnCount = clients.GetLength(1);

            List<string[]> clientList = new List<string[]>();
            for (int i = 0; i < rowCount; i++)
            {
                string[] row = new string[columnCount];
                for (int j = 0; j < columnCount; j++)
                {
                    row[j] = clients[i, j];
                }
                clientList.Add(row);
            }

            clientList.Sort((a, b) =>
            {
                if (double.TryParse(a[columnIndex], out double aNum) && double.TryParse(b[columnIndex], out double bNum))
                {
                    return aNum.CompareTo(bNum);
                }
                else
                {
                    return a[columnIndex].CompareTo(b[columnIndex]);
                }
            });

            string[,] sortedData = new string[rowCount, columnCount];
            for (int i = 0; i < rowCount; i++)
            {
                string[] row = clientList[i];
                for (int j = 0; j < columnCount; j++)
                {
                    sortedData[i, j] = row[j];
                }
            }
        }
    }
}
