using System.Linq;

namespace Game
{
    public class Game
    {
        private int[] dividers = { 1000, 500, 100, 50, 10, 5, 1 };
        private System.Collections.Generic.Dictionary<int, string> _numberConvertions = new System.Collections.Generic.Dictionary<int, string>() { { 1, "I" }, { 5, "V" }, { 10, "X" }, { 50, "L" }, { 100, "C" }, { 500, "D" }, { 1000, "M" } };


        public string ConvertToRomanNumber(int input)
        {
            var result = "";
            if (_numberConvertions.ContainsKey(input))
                return _numberConvertions[input];

            result = ConvertComplexNumber(input);
            return result;

        }

        private string ConvertComplexNumber(int input)
        {
            string result = "";
            var divider = dividers.First(x => input/x >= 1);

            if (divider*3 >= input)
            {
                for (int j = 0; j < (int) input/divider; j++)
                    result += _numberConvertions[divider];

            }
            else
            {
                result = _numberConvertions[divider] + _numberConvertions[dividers.ToList().IndexOf(divider) - 1];
            }

            if (input % divider > 0)
            {
                result += ConvertComplexNumber(input % divider);
            }

            return result;
        }
    }
}
