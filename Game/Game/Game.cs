namespace Game
{
    public class Game
    {

        public string ConvertToRomanNumber(int i)
        {
            return ConvertBasicNumbers(i);
        }

        private  string ConvertBasicNumbers(int number)
        {
            switch (number)
            {
                case 1:
                    return "I";
                case 5:
                    return "V";
                case 10:
                    return "X";
                case 50:
                    return "L";
                case 100:
                    return "C";
                case 500:
                    return "D";
                case 1000:
                    return "M";
                default:
                    throw new System.ApplicationException(string.Format("Unknown number to convert: '{0}'.", number));
            }
        }
    }
}