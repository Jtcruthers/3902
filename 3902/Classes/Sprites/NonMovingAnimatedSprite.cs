using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace _3902
{
    class NonMovingAnimatedSprite : ISprite
    {
        private int rows;
        private int columns;
        private int currentFrame;
        private int totalFrames;
        private Vector2 position;
        private Texture2D texture;
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; set; }

        public NonMovingAnimatedSprite(Texture2D texture, Vector2 position, int rows, int columns)
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
            if (currentFrame / 8 == totalFrames)
                currentFrame = 0;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            int width = this.texture.Width / columns;
            int height = this.texture.Height / rows;
            int row = (int)((float)(currentFrame / 8) / (float)columns);
            int column = (currentFrame / 8 % columns);

            Rectangle sourceRectangle = new Rectangle(width * column, height * row, width, height);
            Rectangle destinationRectangle = new Rectangle((int)this.position.X, (int)this.position.Y, width, height);

            spriteBatch.Draw(this.texture, destinationRectangle, sourceRectangle, Color.White);
        }
    }
}

