using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class GameParser
    {
        public int[] ParseInput(string input)
        {
            string[] splittedInput = input.Split(new string[] {Environment.NewLine}, StringSplitOptions.None);
            return splittedInput.Select(n => Convert.ToInt32(n)).ToArray();
        }
    }
}
