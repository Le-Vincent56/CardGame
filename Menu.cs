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
        private Game1 game1;
        private Texture2D background;

        private Button play;
        private Button options;
        private Button lore;
        private Button quit;

        private int buttonWidth;
        private int buttonHeight;

        private int startHeight;
        private int marginsInBetween;
        private int marginsFromSides;



        // PROPERTIES =============================================================================================================
        public Game1 Game1 { get { return game1; } set { game1 = value; } }
        public Texture2D Background { get { return background; } set { background = value; } }

        public int ButtonWidth { get { return buttonWidth; } set { buttonWidth = value; } }
        public int ButtonHeight { get { return buttonHeight; } set { buttonHeight = value; } }
        public int StartHeight { get { return startHeight; } set { startHeight = value; } }
        public int MarginsInBetween { get { return marginsInBetween; } set { marginsInBetween = value; } }
        public int MarginsFromSides { get { return marginsFromSides; } set { marginsFromSides = value; } }
        public Button Play { get { return play; } set { play = value; } }
        public Button Options { get { return options; } set { options = value; } }
        public Button Lore { get { return lore; } set { lore = value; } }
        public Button Quit { get { return quit; } set { quit = value; } }



        // CONSTRUCTOR ============================================================================================================
        public Menu(Game1 game, Texture2D background)
        {
            game1 = game;
            this.background = background;

            int buttonWidth = game.GraphicsManager.PreferredBackBufferWidth / 8;
            
            int marginsFromSides = game.GraphicsManager.PreferredBackBufferHeight / 12;

            int marginsInBetween = (game.GraphicsManager.PreferredBackBufferHeight / 24);

            int buttonHeight = ((game.GraphicsManager.PreferredBackBufferHeight / 2) - (3 * marginsInBetween) - (2 * marginsFromSides)) / 4;

            int startHeight = (game.GraphicsManager.PreferredBackBufferHeight / 2) + marginsFromSides;

            Play = new Button(
                game.SpriteManager.ButtonNormal,
                game.SpriteManager.Arial16,
                new Rectangle((game.GraphicsManager.PreferredBackBufferWidth / 2) - (buttonWidth / 2),
                startHeight, buttonWidth, buttonHeight));

            Options = new Button(
                game.SpriteManager.ButtonNormal,
                game.SpriteManager.Arial16,
                new Rectangle((game.GraphicsManager.PreferredBackBufferWidth / 2) - (buttonWidth / 2),
                startHeight + (buttonHeight + marginsInBetween), buttonWidth, buttonHeight));

            Lore = new Button(
                game.SpriteManager.ButtonNormal, 
                game.SpriteManager.Arial16, 
                new Rectangle((game.GraphicsManager.PreferredBackBufferWidth / 2) - (buttonWidth / 2), 
                startHeight + ((buttonHeight + marginsInBetween) * 2), buttonWidth, buttonHeight));

            Quit = new Button(
                game.SpriteManager.ButtonNormal,
                game.SpriteManager.Arial16,
                new Rectangle((game.GraphicsManager.PreferredBackBufferWidth / 2) - (buttonWidth / 2),
                startHeight + ((buttonHeight + marginsInBetween) * 3), buttonWidth, buttonHeight));
        }



        // METHODS ================================================================================================================
        /// <summary>
        /// Update the components of the menu
        /// </summary>
        public void Update()
        {
            if (play.Clicked(Game1.MouseState, Game1.PreviousMouseState))
            {
                Game1.GameManager.GameScreen = Screens.CharacterSelect;
            }

            if (options.Clicked(Game1.MouseState, Game1.PreviousMouseState))
            {
                Game1.GameManager.GameScreen = Screens.Options;
            }

            if (lore.Clicked(Game1.MouseState, Game1.PreviousMouseState))
            {
                Game1.GameManager.GameScreen = Screens.Lore;
            }

            if (quit.Clicked(Game1.MouseState, Game1.PreviousMouseState))
            {
                Game1.Exit();
            }
        }

        /// <summary>
        /// Draw the components of the Menu
        /// </summary>
        public void Draw()
        {
            // Draw Background
            Game1.SpriteBatch.Draw(background, new Rectangle(0, 0, Game1.GraphicsManager.PreferredBackBufferWidth, Game1.GraphicsManager.PreferredBackBufferHeight), Color.White);

            // Draw Start Button
            if (play.MouseInBounds(Game1.MouseState))
            {
                play.Draw(
                    Game1.SpriteBatch,
                    Game1.SpriteManager.ButtonHighlight,
                    "Play",
                    play.ButtonShape,
                    Alignment.Center,
                    Color.White);
            }
            else
            {
                play.Draw(
                    Game1.SpriteBatch,
                    Game1.SpriteManager.ButtonNormal,
                    "Play",
                    play.ButtonShape,
                    Alignment.Center,
                    Color.White);
            }

            // Draw Options Button
            if (options.MouseInBounds(Game1.MouseState))
            {
                options.Draw(
                    Game1.SpriteBatch,
                    Game1.SpriteManager.ButtonHighlight,
                    "Options",
                    options.ButtonShape,
                    Alignment.Center,
                    Color.White);
            }
            else
            {
                options.Draw(
                    Game1.SpriteBatch,
                    Game1.SpriteManager.ButtonNormal,
                    "Options",
                    options.ButtonShape,
                    Alignment.Center,
                    Color.White);
            }

            // Draw Lore Button
            if (lore.MouseInBounds(Game1.MouseState))
            {
                lore.Draw(
                    Game1.SpriteBatch,
                    Game1.SpriteManager.ButtonHighlight,
                    "Lore",
                    lore.ButtonShape,
                    Alignment.Center,
                    Color.White);
            }
            else
            {
                lore.Draw(
                    Game1.SpriteBatch,
                    Game1.SpriteManager.ButtonNormal,
                    "Lore",
                    lore.ButtonShape,
                    Alignment.Center,
                    Color.White);
            }

            // Draw Quit Button
            if (quit.MouseInBounds(Game1.MouseState))
            {
                quit.Draw(
                    Game1.SpriteBatch,
                    Game1.SpriteManager.ButtonHighlight,
                    "Quit",
                    quit.ButtonShape,
                    Alignment.Center,
                    Color.White);
            }
            else
            {
                quit.Draw(
                    Game1.SpriteBatch,
                    Game1.SpriteManager.ButtonNormal,
                    "Quit",
                    quit.ButtonShape,
                    Alignment.Center,
                    Color.White);
            }
        }
    }
}
