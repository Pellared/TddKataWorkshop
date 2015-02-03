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
            var sum = 0;
            foreach (var item in frames)
            {
                
            }

            return sum;
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

        public int Sum()
        {
            return p1 + p2;
        }

        public bool IsPare()
        {
            if (p1 + p2 == 10) return true;
            return false;
        }

        public bool IsStrike()
        {
            if (p1 == 10) return true;
            return false;
        }
    }
}