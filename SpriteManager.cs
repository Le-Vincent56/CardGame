using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace CardGame
{
    class SpriteManager
    {
        // FIELDS =================================================================================================================
        private Game1 game1;

        // Fonts
        private SpriteFont arial16;

        // Miscellanious Sprites
        private Texture2D pixel;

        // PROPERTIES =============================================================================================================
        // Fonts
        public SpriteFont Arial16 { get { return arial16; } set { arial16 = value; } }

        // Miscellanious Sprites
        public Texture2D Pixel { get { return pixel; } set { pixel = value; } }

        // CONSTRUCTOR ============================================================================================================
        public SpriteManager(Game1 game1)
        {
            this.game1 = game1;
        }

        // METHODS ================================================================================================================
        public void LoadContent()
        {
            // Fonts
            Arial16 = game1.Content.Load<SpriteFont>("Arial16");

            // Miscellanious Sprites
            Pixel = game1.Content.Load<Texture2D>("WhitePixel");
        }
    }
}
