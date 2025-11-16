using System.Threading.Channels;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        private static readonly Random random =  new();

        public static List<int> LottoNumbers(int totalNumbers = 5, int maxNumber = 69)
        {
            List<int> poolOfNumbers = new();
            HashSet<int> uniqueNum = new();

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
            int bonusNumber = random.Next(1, 25);
            Console.Write("Your lottery numbera are: " + string.Join(" - ", poolOfNumbers)); Console.Write(" * Powerball (" + string.Join("- ", bonusNumber + ")\n"));
        }
    }
}