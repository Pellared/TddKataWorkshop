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
                if (i > 0 && frames[i - 1].isStrice())
                {
                    if (frames[i].isStrice())
                    {
                        result += frames[i].sum() + 10 + frames[i+1].firstPool;
                    }
                    else
                    {
                        result += frames[i].sum() + frames[i].firstPool + frames[i].secondPool;
                    }
                }
                else if (i > 0 && frames[i - 1].isSpare())
                {
                    result += frames[i].sum() + frames[i].firstPool;
                }
                else
                {
                    result += frames[i].sum();
                }
               
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