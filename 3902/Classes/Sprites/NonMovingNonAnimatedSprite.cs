﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace _3902
{
    class NonMovingNonAnimatedSprite : ISprite
    {
        private Vector2 position;
        private Texture2D texture;
        public Vector2 Position { get; set; }
        public Texture2D Texture { get; set; }

        public NonMovingNonAnimatedSprite(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
        }

        public void Update()
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position);
        }
    }
}

