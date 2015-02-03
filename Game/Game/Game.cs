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

            foreach (var frame in frames)
            {
                result += frame.sum();
            }
            return result;
        }
    }

    public class Frame
    {
        private int firstPool;
        private int secondPool;

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