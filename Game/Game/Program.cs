namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var input= System.Console.ReadLine();
            if (input != null) System.Console.WriteLine(game.ConvertToRomanNumber(int.Parse(input)));
            System.Console.ReadKey();
        }
    }
}
