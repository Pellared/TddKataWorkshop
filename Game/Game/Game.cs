using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace Game
{
    public class Game
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Result(List<Frame> frames)
        {
            int result = 0;

            var framesArray = frames.ToArray();
            for (int i = 0; i < framesArray .Length ; i++)
            {
                var bonus = 0;
                if (i > 0 && framesArray[i - 1].isSpare())
                {
                    bonus = framesArray[i].firstPool;
                }
                result += framesArray[i].sum() + bonus;
            }
            return result;

        }
    }

    public class Frame
    {
        public  int firstPool;
        public  int secondPool;

        public Frame(int i, int y)
        {
            firstPool = i;
            secondPool = y;
        }

        public int sum()
        {
            return firstPool + secondPool;
        }

        public bool isSpare()
        {
            return (firstPool + secondPool == 10) ? true : false;
        }

        public bool isStrice()
        {
            return (firstPool == 10) ? true : false;
        }
    }
}