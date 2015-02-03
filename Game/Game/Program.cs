using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var s = Console.ReadLine();
            // s -> X,X,X,X,X,X,X,X,X,X,X
            game.Parse(s);

        }
    }


}
