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
            for (int i = 0; i < frames.Count; i++)
            {
                result += ((i > 0 && frames[i - 1].isSpare())) ? frames[i].sum() + frames[i].firstPool : frames[i].sum();
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