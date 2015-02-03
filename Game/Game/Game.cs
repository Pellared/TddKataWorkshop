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

        public int Result(IList<int> rolls)
        {
            AddSpareBonus(rolls);
            return rolls.Sum();
        }

        private void AddSpareBonus(IList<int> rolls)
        {
            for (var i = 0; i < rolls.Count(); i++)
            {
                if (i > 0 && i % 2 == 0)
                {
                    if (rolls[i - 2] + rolls[i - 1] == 10)
                    {
                        rolls[i] *= 2;
                    }
                }
            }
        }
    }

    public class Frame
    {
        private string firstRoll;
        private string secondRoll;

    }
}