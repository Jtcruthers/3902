using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace _3902
{
    class GamePadController: IController
    {
        private ICommand quitCommand;
        private ICommand setMovingAnimatedCommand;
        private ICommand setMovingNonAnimatedCommand;
        private ICommand setNonMovingAnimatedCommand;
        private ICommand setNonMovingNonAnimatedCommand;
        private Game game;

        public GamePadController(Game game)
        {
            this.game = game;
            setConstructors(game);
        }

        public void Update()
        {
            GamePadState state = GamePad.GetState(PlayerIndex.One);
            if (state.Buttons.A == ButtonState.Pressed)
                setNonMovingNonAnimatedCommand.Execute();
            if (state.Buttons.B == ButtonState.Pressed)
                setNonMovingAnimatedCommand.Execute();
            if (state.Buttons.X == ButtonState.Pressed)
                setMovingNonAnimatedCommand.Execute();
            if (state.Buttons.Y == ButtonState.Pressed)
                setMovingAnimatedCommand.Execute();
            if (state.Buttons.Start == ButtonState.Pressed)
                quitCommand.Execute();
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
