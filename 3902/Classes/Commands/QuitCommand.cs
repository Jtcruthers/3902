using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3902
{
    class QuitCommand : ICommand
    {

        Game game;

        public QuitCommand(Game game)
        {
            this.game = game;
        }

        public void Execute()
        {
            this.game.Exit();
        }
    }
}
