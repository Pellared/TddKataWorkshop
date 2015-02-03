using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = CollectInput();
            var game = new GameEngine(new Game(), new GameParser());
            string result = game.Calculate(input);
        }

        private static string CollectInput()
        {
            while (Console.ReadKey().Key == ConsoleKey.Z)
            {
                Console.ReadLine();
            }
            return string.Empty;
        }
    }
}