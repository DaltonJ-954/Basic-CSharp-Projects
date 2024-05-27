using System;
using System.Linq;

namespace Sort_2DArray
{
    class Program
    {
        static int team1 = 5;
        static int team2 = 1;

        static void ArraySort2D(int[,] arrayEx)
        {
            for (int one = 0; one < team1; one++)
            {
                for (int two = 0; two < team2 - 1; two++)
                {
                    for (int three = 0; three < team2 - two - 1; three++)
                    {
                        if (arrayEx[one, three] > arrayEx[one, three + 1])
                        {
                            int organize = arrayEx[one, three];
                            arrayEx[one, three] = arrayEx[one, three + 1];
                            arrayEx[one, three + 1] = organize;
                        }
                    }
                }
            }


            for (int one = 0; one < team1; one++)
            {
                for (int two = 0; two < team2; two++)
                {
                    Console.WriteLine(arrayEx[one, two] + " ");
                }
                Console.WriteLine();
            }
        }


        public static void MichaelBubble(int[] sortThisList)
        {

            int figureOut;

            for (int i = 0; i < sortThisList.Length - 1; i++)
            {
                for (int j = 0; j < sortThisList.Length - (1 + i); j++)
                {
                    if (sortThisList[j] > sortThisList[j + 1])
                    {
                        figureOut = sortThisList[j + 1];
                        sortThisList[j + 1] = sortThisList[j];
                        sortThisList[j] = figureOut;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", sortThisList));
        }


        public static long Factorial(int number)
        {
            //base case - factorial of 0 or 1 is 1
            if (number <= 1)
            {
                return 1;
            }
            return number * Factorial(number - 1);

            Console.WriteLine("The result is: " + Factorial(number - 1));
        }


        static void Main(string[] args)
        {
            string[] movies = { "The Temptations", "Divergent Series", "Star Wars Series", "Underworld", "Pitch Black", "Chronicles of Riddick", "Wolverine" };

            foreach (string movie in movies)
            {
                if (movie == movies[3])
                {
                    Console.WriteLine(movie);
                }
            }

            Console.WriteLine("Enter in four of your favorite movies.");

            movies[0] = Console.ReadLine();
            movies[1] = Console.ReadLine();
            movies[2] = Console.ReadLine();
            movies[3] = Console.ReadLine();
            Console.ReadKey();

            double a;
            double b;
            double total;

            Console.WriteLine("Divide these numbers and return the remainder.");

            Console.WriteLine("Enter the input number 1: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the input number 2: ");
            b = Convert.ToDouble(Console.ReadLine());

            total = Divide(a, b);

            Console.WriteLine(total + " is the remaing number from the divide opration.");
            Console.ReadKey();


            static double Divide(double a, double b)
            {
                double c = a / b;
                return c;
            }


            int[,] arrayEx = { { 12, 45, 22, 19, 76, 30 }, { 54, 27, 61, 90, 75, 2 }, { 18, 5, 8, 59, 91, 37 }, { 100, 67, 43, 32, 41, 1000 }, { 1, 15, 84, 4, 49, 265 } };

            ArraySort2D(arrayEx);


            int[] sortThisList = { 21, 45, 61, 12, 5, 30, 2, 45 };

            MichaelBubble(sortThisList);
        }
    }
}
