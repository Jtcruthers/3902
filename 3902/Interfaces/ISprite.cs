﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _3902
{
    public interface ISprite
    {
        Vector2 Position { get; set; }
        void Update();
        void Draw(SpriteBatch spriteBatch);
    }

}
