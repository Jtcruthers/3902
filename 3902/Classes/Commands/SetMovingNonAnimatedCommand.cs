using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3902
{
    class SetMovingNonAnimatedCommand : ICommand
    {

        Game game;

        public SetMovingNonAnimatedCommand(Game game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.ChangeSprite(SpriteType.MovingNonAnimated);
        }
    }
}
