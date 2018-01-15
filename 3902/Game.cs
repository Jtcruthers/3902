using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _3902
{
    public class Game : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        private ISprite sprite;
        private ISprite movingAnimatedSprite;
        private ISprite movingNonAnimatedSprite;
        private ISprite nonMovingAnimatedSprite;
        private ISprite nonMovingNonAnimatedSprite;
        Vector2 position;

        IController keyboardController;
        IController gamepadController;

        public Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            position = new Vector2(0, 0);

            keyboardController = new KeyboardController(this);
            gamepadController = new GamePadController(this);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            movingAnimatedSprite = new MovingAnimatedSprite(this.Content.Load<Texture2D>("images/megaman"), position, 7, 10);
            movingNonAnimatedSprite = new MovingNonAnimatedSprite(this.Content.Load<Texture2D>("images/ghost"), position);
            nonMovingAnimatedSprite = new NonMovingAnimatedSprite(this.Content.Load<Texture2D>("images/dancing"), position, 10, 8);
            nonMovingNonAnimatedSprite = new NonMovingNonAnimatedSprite(this.Content.Load<Texture2D>("images/standing"), position);
        }

        protected override void Update(GameTime gameTime)
        {
            keyboardController.Update();
            if (sprite != null)
                sprite.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            if (sprite != null)
                sprite.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public void ChangeSprite(SpriteType type)
        {
            switch(type)
            {
                case SpriteType.MovingAnimated:
                    sprite = movingAnimatedSprite;
                    break;
                case SpriteType.MovingNonAnimated:
                    sprite = movingNonAnimatedSprite;
                    break;
                case SpriteType.NonMovingAnimated:
                    sprite = nonMovingAnimatedSprite;
                    break;
                case SpriteType.NonMovingNonAnimated:
                    sprite = nonMovingNonAnimatedSprite;
                    break;
            }
        }
    }
}

public enum SpriteType
{
    MovingAnimated,
    MovingNonAnimated,
    NonMovingAnimated,
    NonMovingNonAnimated
}
