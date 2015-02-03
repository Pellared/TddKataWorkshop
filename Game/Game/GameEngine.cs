using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class GameEngine
    {
        private GameParser _parser;
        private Game _game;

        public GameEngine(Game game, GameParser gameParser)
        {
            _parser = gameParser;
            _game = game;
        }

        public string Calculate(string input)
        {
            var throws = _parser.ParseInput(input);
            foreach (var t in throws)
            {
                _game.Throw(t);
            }
            return _game.TotalScore().ToString();
        }
    }
}
