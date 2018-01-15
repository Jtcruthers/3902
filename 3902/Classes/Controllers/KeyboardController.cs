using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace _3902
{
    class KeyboardController : IController
    {
        private ICommand quitCommand;
        private ICommand setMovingAnimatedCommand;
        private ICommand setMovingNonAnimatedCommand;
        private ICommand setNonMovingAnimatedCommand;
        private ICommand setNonMovingNonAnimatedCommand;
        private Game game;

        public KeyboardController(Game game)
        {
            this.game = game;
            setConstructors(game);
        }

        public void Update()
        {
            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.Q))
                quitCommand.Execute();
            if (state.IsKeyDown(Keys.W))
                setNonMovingNonAnimatedCommand.Execute();
            if (state.IsKeyDown(Keys.E))
                setNonMovingAnimatedCommand.Execute();
            if (state.IsKeyDown(Keys.R))
                setMovingNonAnimatedCommand.Execute();
            if (state.IsKeyDown(Keys.T))
                setMovingAnimatedCommand.Execute();
        }

        private void setConstructors(Game game)
        {
            quitCommand = new QuitCommand(game);
            setMovingAnimatedCommand = new SetMovingAnimatedCommand(game);
            setMovingNonAnimatedCommand = new SetMovingNonAnimatedCommand(game);
            setNonMovingAnimatedCommand = new SetNonMovingAnimatedCommand(game);
            setNonMovingNonAnimatedCommand = new SetNonMovingNonAnimatedCommand(game);
        }
    }
}
