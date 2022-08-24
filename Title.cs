using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace CardGame
{
    public class Title
    {
        // FIELDS =================================================================================================================
        private Game1 game1;
        private Texture2D background;
        private Texture2D pixel;
        private SpriteFont font;

        private Button entryText;
        private int margins;

        // PROPERTIES =============================================================================================================
        public Game1 Game1 { get { return game1; } set { game1 = value; } }
        public Texture2D Background { get { return background; } set { background = value; } }
        public Texture2D Pixel { get { return pixel; } set { pixel = value; } }
        public SpriteFont Font { get { return font; } set { font = value; } }
        public Button EntryText { get { return entryText; } set { entryText = value; } }
        public int Margins { get { return margins; } set { margins = value; } }

        // CONSTRUCTOR ============================================================================================================
        public Title(Game1 game, Texture2D background, Texture2D pixel, SpriteFont font)
        {
            game1 = game;
            this.background = background;
            margins = 150;
            this.font = font;

            entryText = new Button(pixel, font, new Rectangle(margins, Game1.GraphicsManager.PreferredBackBufferHeight - 200, 
                Game1.GraphicsManager.PreferredBackBufferWidth - (margins * 2), 150));
        }

        // METHODS ================================================================================================================
        /// <summary>
        /// Update the Title components
        /// </summary>
        public void Update()
        {
            Keys[] pressedKeys = Game1.KeyboardState.GetPressedKeys();
            if (pressedKeys.Length != 0)
            {
                Game1.GameManager.GameScreen = Screens.Menu;
            }
        }
        
        /// <summary>
        /// Draw the Title components
        /// </summary>
        public void Draw()
        {
            Game1.SpriteBatch.Draw(background, new Rectangle(0, 0, Game1.GraphicsManager.PreferredBackBufferWidth, Game1.GraphicsManager.PreferredBackBufferHeight), null, 
                Color.White, 0, new Vector2(0, 0), SpriteEffects.FlipVertically, 0f);
            EntryText.Draw(Game1.SpriteBatch, "Press Any Key to Start", entryText.ButtonShape, Alignment.Center, Color.Transparent, Color.White);
        }
    }
}
