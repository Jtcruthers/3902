using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3902
{
    class SetMovingAnimatedCommand : ICommand
    {

        Game game;

        public SetMovingAnimatedCommand(Game game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.ChangeSprite(SpriteType.MovingAnimated);
        }
    }
}
