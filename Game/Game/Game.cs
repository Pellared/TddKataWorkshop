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

        public int Result2(List<Frame> frames)
        {
            throw new System.NotImplementedException();
        }
    }

    public class Frame
    {
        private string firstRoll;
        private string secondRoll;
        private int p1;
        private int p2;

        public Frame(int p1, int p2)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.p2 = p2;
        }

    }
}