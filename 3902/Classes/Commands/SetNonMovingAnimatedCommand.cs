using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3902
{
    class SetNonMovingAnimatedCommand : ICommand
    {

        Game game;

        public SetNonMovingAnimatedCommand(Game game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.ChangeSprite(SpriteType.NonMovingAnimated);
        }
    }
}
