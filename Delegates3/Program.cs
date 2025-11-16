namespace Delegates3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> africanCountries = new List<string>();
            string input = "";

            Console.WriteLine("Enter an African country here (type quit to end):");

            while (true)
            {
                Console.WriteLine("Country: ");
                input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                if (!string.IsNullOrWhiteSpace(input))
                {
                    africanCountries.Add(input);
                    Console.WriteLine("Added: " + input + "");
                }
                else
                {
                    Console.WriteLine("Please enter a valid country.");
                }
            }

            Console.WriteLine("\nYou have entered the following African countries:");
            foreach (string country in africanCountries)
            {
                Console.WriteLine(country);
            }

            if (africanCountries.Count >= 5)
            {
                africanCountries.Sort();
                Console.WriteLine("\nHere are the countries sorted alphabetically:");
                foreach (string country in africanCountries)
                {
                    Console.WriteLine(country);
                }
            }
            else
            {
                Console.WriteLine("\nYou need to enter at least 5 countries to see them sorted.");
            }
        }
    }
}
