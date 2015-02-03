using Xunit;

namespace Game
{
    public class GameTests
    {
        //[Fact]
        //public void Add_values_returns_the_sum()
        //{
        //    var game = new Game();
        //    int result = game.Add(2, 3);
        //    Assert.Equal(5, result);
        //}

        [Fact]
        public void Normal_throws_returns_sum()
        {
            var game = new Game();
            game.Throw(1);
            game.Throw(1);
            game.Throw(1);
            game.Throw(1);
            game.Throw(1);
            var result = game.TotalScore();
            Assert.Equal(5, result);
        }

        [Fact]
        public void Single_spare_returns_sum_and_bonus()
        {
            var game = new Game();
            game.Throw(9);
            game.Throw(1);
            game.Throw(5);
            game.Throw(1);
            var result = game.TotalScore();
            Assert.Equal(21, result);
        }

        [Fact]
        public void Sum_spares_only_for_frames()
        {
            var game = new Game();
            game.Throw(5);
            game.Throw(5);
            game.Throw(5);
            game.Throw(1);
            var result = game.TotalScore();
            Assert.Equal(21, result);
        }

        [Fact]
        public void Sum_with_single_strike_gives_double_bnous_twice()
        {
            var game = new Game();
            game.Throw(10);
            game.Throw(7);
            game.Throw(2);
            game.Throw(1);
            var result = game.TotalScore();
            Assert.Equal(29, result);
        }

        [Fact]
        public void Sum_with_strikes_and_spares_gives_double_bonus_and_normal_bonus()
        {
            var game = new Game();
            game.Throw(10);
            game.Throw(7);
            game.Throw(3);
            game.Throw(1);
            game.Throw(6);
            var result = game.TotalScore();
            Assert.Equal(38, result);
        }

    }
}