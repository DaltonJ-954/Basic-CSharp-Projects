using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        public static void ValidatePassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Password cannot be null or empty.");
            }

            if (password.Length < 6)
            {
                throw new ArgumentException("Password must be at least 6 characters long.");
            }
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter a password: ");
                    string? inputPassword = Console.ReadLine();

                    ValidatePassword(inputPassword);
                    Console.WriteLine("Password is valid.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}
