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

        // Button Sprites
        private Texture2D buttonNormal;
        private Texture2D buttonHighlight;
        private Texture2D buttonPressed;

        // Large Sprites/Backgrounds
        private Texture2D titleBackground;
        private Texture2D menuBackground;
        private Texture2D characterSelectBackground;

        // PROPERTIES =============================================================================================================
        // Fonts
        public SpriteFont Arial16 { get { return arial16; } set { arial16 = value; } }

        // Miscellanious Sprites
        public Texture2D Pixel { get { return pixel; } set { pixel = value; } }

        // Button Sprites
        public Texture2D ButtonNormal { get { return buttonNormal; } set { buttonNormal = value; } }
        public Texture2D ButtonHighlight { get { return buttonHighlight; } set { buttonHighlight = value; } }
        public Texture2D ButtonPressed { get { return buttonPressed; } set { buttonPressed = value; } }

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

            // Button Sprites
            ButtonNormal = game1.Content.Load<Texture2D>("buttonNormal");
            ButtonHighlight = game1.Content.Load<Texture2D>("buttonHighLight");
            ButtonPressed = game1.Content.Load<Texture2D>("buttonPressed");

            // Large Sprites/Backgrounds
            TitleBackground = game1.Content.Load<Texture2D>("TitleBackground");
            MenuBackground = game1.Content.Load<Texture2D>("MenuBackground");
            characterSelectBackground = game1.Content.Load<Texture2D>("CharacterSelectBackground");
        }
    }
}
