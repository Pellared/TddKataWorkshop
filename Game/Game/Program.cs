namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game();
            var input= System.Console.ReadLine();
            
            if (input != null) System.Console.WriteLine(game.ConvertToRomanNumber(StringInputParser.Parse(input)));
            System.Console.ReadKey();
        }
    }

    internal class StringInputParser
    {
        public static int Parse(string input)
        {
            var inputNumber = int.Parse(input);

            if (inputNumber < 1 || inputNumber >3000)
                throw new System.ApplicationException();

            return inputNumber;
        }
    }
}
