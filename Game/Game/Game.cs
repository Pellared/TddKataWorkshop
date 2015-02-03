using System;
using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Game
    {
        private List<int> _throws = new List<int>();

        public int TotalScore()
        {
            var total = 0;
            for (int i = 0; i < _throws.Count; i++)
            {
                total += _throws[i];
                if (i > 1)
                {
                    if (IsSpare(_throws[i - 2], _throws[i - 1]) && i%2 == 0)
                        total += _throws[i];
                    if (IsStrike(_throws[i - 2]))
                        total += _throws[i] + _throws[i - 1];
                }

            }
            return total;
        }

        public void Throw(int score)
        {
            _throws.Add(score);
        }

        private bool IsSpare(int first, int second)
        {
            return first + second == 10;
        }

        private bool IsStrike(int first)
        {
            return first == 10;
        }
    }
}