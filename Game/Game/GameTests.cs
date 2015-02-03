using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Game
{
    public class GameTests
    {
        [Fact]
        public void Add_values_returns_the_sum()
        {
            var game = new Game();
            int result = game.Add(2, 3);
            Assert.Equal(5, result);
        }


        [Fact]
        public void with_no_spare()
        {
            var game = new Game();
            int result = game.Result(new List<Frame>(){new Frame(1,4), new Frame(3,5)});
            Assert.Equal(13, result);
        }


        [Fact]
        public void with_one_spare()
        {
            var game = new Game();
            int result = game.Result(new List<Frame>() { new Frame(1, 9), new Frame(3, 5) });
            Assert.Equal(21, result);
        }

        [Fact]
        public void IsGameSumCalculatedProperlyIfFirstFrameIsStrike()
        {
            var game = new Game();
            int result = game.Result(new List<Frame>() { new Frame(10, 0), new Frame(3, 5) });
            Assert.Equal(26, result);
        }

          [Fact]
        public void IsGameSumCalculatedProperlyIfFirstAndSecondFrameIsStrike()
        {
            var game = new Game();
            int result = game.Result(new List<Frame>() { new Frame(10, 0), new Frame(10, 0), new Frame(4, 5) });
              var firstStrikeScore = 10 + 10 + 4;
              var secondStrikeScore = 10 + 4 + 5;
              var thirdFrameScore = 4+5;
            Assert.Equal(firstStrikeScore + secondStrikeScore + thirdFrameScore , result);
        }

        [Fact]
        public void AcceptanceWithMix()
        {
            var game = new Game();

            var input = new List<Frame>()
            {
                new Frame(0, 10),
                new Frame(1, 9),
                new Frame(2, 3),
                new Frame(10, 0),
                new Frame(2, 3),
                new Frame(2, 3),
                new Frame(2, 3),
                new Frame(2, 3),
                new Frame(2, 8),
                new Frame(10, 0),
                new Frame(5, 5)
            };

            var expected = new[]
            {
                10 + 1,
                1 + 9 + 2,
                2 + 3,
                10 + 2 + 3,
                2 + 3,
                2 + 3,
                2 + 3,
                2 + 3,
                2 + 8 + 10,
                10 + 5 + 5
            };

            int result = game.Result(input);
            Assert.Equal(expected.Sum(), result);

        }

        [Fact]
        public void parseOneFrame()
        {
            var game = new Game();
            Frame result = game.Parse("X");
            Assert.Equal(result, new Frame(10,0));
        }
        [Fact]
        public void parseOneFrame1()
        {
            var game = new Game();
            Frame result = game.Parse("9-");
            Assert.Equal(result, new Frame(9, 0));
        }
        [Fact]
        public void parseOneFrame2()
        {
            var game = new Game();
            Frame result = game.Parse("--");
            Assert.Equal(result, new Frame(0, 0));
        }
        [Fact]
        public void parseOneFrame3()
        {
            var game = new Game();
            Frame result = game.Parse("-/");
            Assert.Equal(result, new Frame(0, 10));
        }
        [Fact]
        public void parseOneFrame4()
        {
            var game = new Game();
            Frame result = game.Parse("12");
            Assert.Equal(result, new Frame(1, 2));
        }
    
    }

    
}