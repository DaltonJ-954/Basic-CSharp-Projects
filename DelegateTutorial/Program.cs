namespace DelegateTutorial
{

    class Program
    {
        /* A delegate in C# is a type that represents references to methods with a specific parameter list and return type. It allows methods to be
         * passed as parameters and can be used to define callback methods. Delegates are similar to function pointers in C++, but are type-safe and secure.
         * In the provided code example, the delegate keyword is used to define a delegate named LogDel that takes a string parameter and returns void.*/

        delegate void LogDel(string text);
        static void Main(string[] args)
        {
            Log log = new();

            LogDel LogTextToScreenDel, LogTextToFileDel;

            LogTextToScreenDel = new(log.LogTextToScreen);

            LogTextToFileDel = new(log.LogTextToFile);

            LogDel multiLogDel = LogTextToScreenDel + LogTextToFileDel;

            Console.WriteLine("Please enter your name: ");

            var name = Console.ReadLine();

            LogText(multiLogDel, name);

            Console.ReadKey();
        }

        static void LogText(LogDel logDel, string text)
        {
            logDel(text);
        }

        public class Log
        {
            public void LogTextToScreen(string text)
            {
                Console.WriteLine($"{DateTime.Now}: {text}");
            }

            public void LogTextToFile(string text)
            {
                using (StreamWriter sw = new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
                {
                    sw.WriteLine($"{DateTime.Now}: {text}");
                }
            }
        }
    }
}
