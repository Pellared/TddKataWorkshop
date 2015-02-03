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
            int sum = 0;
            for (var i = 0; i < rolls.Count(); i++)
            {

                if (i > 0 && i < rolls.Count() - 1 &&  i % 2 == 0)
                {
                    if (rolls[i - 2] + rolls[i - 1] == 10)
                    {
                        sum += rolls[i] * 2;

                    }
                    else
                    {

                        sum += rolls[i];
                    }
                }
                else
                {
                    sum += rolls[i];
                    
                }
            }
            return sum;
        }

        private void AddSpareBonus(IList<int> rolls)
        {
            int sum = 0;
            for (var i = 0; i < rolls.Count(); i++)
            {
                
                if (i > 0 && i % 2 == 0)
                {
                    if (rolls[i - 2] + rolls[i - 1] == 10)
                    {
                        sum += rolls[i] * 2;
                        
                    }
                    else
                    {

                        sum += rolls[i];
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