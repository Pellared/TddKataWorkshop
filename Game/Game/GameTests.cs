using System.Collections.Generic;
using System.Linq.Expressions;
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
        public void check_result_no_strice_no_spare()
        {
            var game = new Game();
            int result = game.Result(new List<int>(){1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1});
            Assert.Equal(20, result);
        }

        [Fact]
        public void check_result_with_one_spare_bonus()
        {
            var game = new Game();
            int result = game.Result(new List<int>() { 1, 9, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 });
            Assert.Equal(29, result);
        }
        
        [Fact]
        public void check_result_with_all_spare_bonus()
        {
            var game = new Game();
            int result = game.Result(new List<int>() { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 });
            Assert.Equal(150, result);
        }

        [Fact]
        public void check_result_with_frame()
        {
            var game = new Game();
            int result = game.Result2(new List<Frame>() {  new Frame(1,1), new Frame(1,3) });
            Assert.Equal(6, result);
        }
    }
}