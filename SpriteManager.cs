using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace CardGame
{
    public class SpriteManager
    {
        // FIELDS =================================================================================================================
        private Game1 game1;

        // Fonts
        private SpriteFont arial16;

        // Miscellanious Sprites
        private Texture2D pixel;

        // Large Sprites/Backgrounds
        private Texture2D titleBackground;
        private Texture2D menuBackground;
        private Texture2D characterSelectBackground;

        // PROPERTIES =============================================================================================================
        // Fonts
        public SpriteFont Arial16 { get { return arial16; } set { arial16 = value; } }

        // Miscellanious Sprites
        public Texture2D Pixel { get { return pixel; } set { pixel = value; } }

        // Large Sprites/Backgrounds
        public Texture2D TitleBackground { get { return titleBackground; } set { titleBackground = value; } }
        public Texture2D MenuBackground { get { return menuBackground; } set { menuBackground = value; } }
        public Texture2D CharacterSelectBackground { get { return characterSelectBackground; } set { characterSelectBackground = value; } }

        // CONSTRUCTOR ============================================================================================================
        public SpriteManager(Game1 game1)
        {
            this.game1 = game1;
        }

        // METHODS ================================================================================================================
        /// <summary>
        /// Load the Content for Game1
        /// </summary>
        public void LoadContent()
        {
            // Fonts
            Arial16 = game1.Content.Load<SpriteFont>("Arial16");

            // Miscellanious Sprites
            Pixel = game1.Content.Load<Texture2D>("WhitePixel");

            // Large Sprites/Backgrounds
            TitleBackground = game1.Content.Load<Texture2D>("TitleBackground");
            MenuBackground = game1.Content.Load<Texture2D>("MenuBackground");
            characterSelectBackground = game1.Content.Load<Texture2D>("CharacterSelectBackground");
        }
    }
}
