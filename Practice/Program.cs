using System.Threading.Channels;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        private static Random random =  new Random();

        public static List<int> LottoNumbers(int totalNumbers = 6, int maxNumber = 76)
        {
            List<int> poolOfNumbers = new List<int>();
            List<int> bonusNumber = new(); 
            HashSet<int> uniqueNum = new HashSet<int>();

            while (uniqueNum.Count < totalNumbers)
            {
                int number = random.Next(1, maxNumber + 1);
                if (uniqueNum.Add(number))
                {
                    poolOfNumbers.Add(number);
                }
            }

            poolOfNumbers.Sort();
            return poolOfNumbers;  
        }

        static void Main(string[] args)
        {
            List<int> poolOfNumbers = LottoNumbers();
            int bonusNumber = random.Next(1, 20);
            Console.WriteLine("Your lottery numbera are: " + string.Join(", ", poolOfNumbers)); 
            Console.WriteLine("Your super number is:  " + string.Join(", ", bonusNumber + " -- ") + DateTime.Now);
        }
    }
}