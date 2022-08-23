using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace CardGame
{
    public class Menu
    {
        // FIELDS =================================================================================================================
        private Game1 game;
        private Texture2D background;

        private Button start;
        private Button quit;

        private int buttonWidth;
        private int buttonHeight;

        private int startHeight;
        private int marginsInBetween;



        // PROPERTIES =============================================================================================================
        public Game1 Game { get => game; set => game = value; }
        public Texture2D Background { get => background; set => background = value; }

        public int ButtonWidth { get { return buttonWidth; } set { buttonWidth = value; } }
        public int ButtonHeight { get { return buttonHeight; } set { buttonHeight = value; } }
        public int StartHeight { get { return startHeight; } set { startHeight = value; } }
        public int MarginsInBetween { get { return marginsInBetween; } set { marginsInBetween = value; } }
        public Button Start { get { return start; } set { start = value; } }
        public Button Quit { get { return quit; } set { quit = value; } }



        // CONSTRUCTOR ============================================================================================================
        public Menu(Game1 game, Texture2D background)
        {
            this.Game = game;
            this.Background = background;

            int buttonWidth = 150;
            int buttonHeight = 30;

            int startHeight = game.GraphicsManager.PreferredBackBufferHeight * 3 / 5;
            int marginsInBetween = 30;


            Start = new Button(
                game.SpriteManager.Pixel,
                game.SpriteManager.Arial16,
                new Rectangle((game.GraphicsManager.PreferredBackBufferWidth / 2) - (buttonWidth / 2),
                startHeight, buttonWidth, buttonHeight));

            Quit = new Button(
                game.SpriteManager.Pixel,
                game.SpriteManager.Arial16,
                new Rectangle((game.GraphicsManager.PreferredBackBufferWidth / 2) - (buttonWidth / 2),
                startHeight + buttonHeight + marginsInBetween, buttonWidth, buttonHeight));
        }



        // METHODS ================================================================================================================
        public virtual void Update(Game1 game)
        {

        }

        public virtual void Draw(Game1 game)
        {

        }
    }
}
