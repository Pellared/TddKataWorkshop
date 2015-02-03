using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;

namespace Game
{
    public class Game
    {
        public int Add(int first, int second)
        {
            return first + second;
        }


        public List<Frame> CreateGame(string s)
        {
            var list = new List<Frame>();

            var sw = s.Split(',').ToArray();
            foreach (var sww in sw)
            {
                list.Add(Parse(sww));
            }
            return list;
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

        internal Frame Parse(string input)
        {
            var args = input.ToCharArray();

            if (args.Length == 1)
            {
                if (args[0] == 'X')
                {
                    return new Frame(10, 0);
                }
                throw new ApplicationException("Unknown input.");
            }
            else
            {
                var a1 = args[0];
                var a2 = args[1];

                int p1 = -1;
                int p2 = -1;

                bool isp1 = int.TryParse(a1.ToString(), out p1);
                bool isp2 = int.TryParse(a2.ToString(), out p2);

                if (!isp1 && !isp2)
                {
                    if (a1 == '-' && a2 == '-')
                    {
                        return new Frame(0, 0);
                    }

                    if (a1 == '-' && a2 == '/')
                    {
                        return new Frame(0, 10);
                    }

                    throw new ApplicationException("Unknown input.");
                }
                else if (isp1 && !isp2)
                {
                    if (a2 == '-')
                    {
                        return new Frame(p1, 0);
                    }
                }
                else
                {
                    return new Frame(p1, p2);
                }
            }
            throw new ApplicationException("Unknown input.");
        }
    }

    public class Frame
    {
        protected bool Equals(Frame other)
        {
            return firstPool == other.firstPool && secondPool == other.secondPool;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Frame) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (firstPool*397) ^ secondPool;
            }
        }

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