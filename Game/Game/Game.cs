using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Game
    {

        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Result(IEnumerable<int> rolls)
        {
            return rolls.Sum();
        }
    }

    public class Frame
    {
        private string firstRoll;
        private string secondRoll;

    }
}