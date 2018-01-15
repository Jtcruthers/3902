using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace _3902
{
    class MovingAnimatedSprite : ISprite
    {
        private int rows;
        private int columns;
        private int currentFrame;
        private int totalFrames;
        private Vector2 position;
        private Texture2D texture;
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; set; }

        public MovingAnimatedSprite(Texture2D texture, Vector2 position, int rows, int columns)
        {
            this.texture = texture;
            this.position = position;
            this.rows = rows;
            this.columns = columns;
            this.currentFrame = 0;
            this.totalFrames = rows * columns;
        }

        public void Update()
        {
            currentFrame++;
            if (currentFrame / 4 == totalFrames)
                currentFrame = 0;
            position.X += 10;
            if (position.X > 800)
                position.X = 0;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int width = texture.Width / columns;
            int height = texture.Height / rows;
            int row = (int)((float)(currentFrame / 4) / (float)columns);
            int column = (currentFrame / 4) % columns;

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)position.X, (int)position.Y, width, height);

            spriteBatch.Draw(texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}
