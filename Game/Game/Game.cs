using System.Linq;

namespace Game
{
    public class Game
    {

        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Result(int[] ints)
        {
            return ints.Sum();
        }
    }

    public class Frame
    {
        private string firstRoll;
        private string secondRoll;

    }
}