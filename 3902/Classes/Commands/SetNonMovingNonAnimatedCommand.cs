using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3902
{
    class SetNonMovingNonAnimatedCommand : ICommand
    {

        Game game;

        public SetNonMovingNonAnimatedCommand(Game game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.ChangeSprite(SpriteType.NonMovingNonAnimated);
        }
    }
}
