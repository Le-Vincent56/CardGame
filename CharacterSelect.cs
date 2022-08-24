using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace CardGame
{
    public enum ChoosingPlayer
    {
        PlayerOne,
        PlayerTwo,
    }

    public class CharacterSelect
    {
        // FIELDS =================================================================================================================
        private Game1 game1;
        private Texture2D background;

        // Characters
        private Button bella;
        private Button brody;
        private Button maddy;
        private Button maggie;
        private Button owen;
        private Button vincent;

        // Back Button
        private Button back;

        // Players
        private Player playerOne;
        private Player playerTwo;
        private ChoosingPlayer choosingPlayer;

        // Regions
        private int marginsInBetween;
        private int marginsFromSides;
        private int boxWidth;
        private int boxHeight;

        // PROPERTIES =============================================================================================================
        public Game1 Game1 { get { return game1; } set { game1 = value; } }
        public Texture2D Background { get { return background; } set { background = value; } }

        // Characters
        public Button Bella { get { return bella; } set { bella = value; } }
        public Button Brody { get { return brody; } set { brody = value; } }
        public Button Maddy { get { return maddy; } set { maddy = value; } }
        public Button Maggie { get { return maggie; } set { maggie = value; } }
        public Button Owen { get { return owen; } set { owen = value; } }
        public Button Vincent { get { return vincent; } set { vincent = value; } }

        // Back Button
        public Button Back { get { return back; } set { back = value; } }

        // Players
        public Player PlayerOne { get { return playerOne; } set { playerOne = value; } }
        public Player PlayerTwo { get { return playerTwo; } set { playerTwo = value; } }
        public ChoosingPlayer ChoosingPlayer { get { return choosingPlayer; } set { choosingPlayer = value; } }

        // Regions
        public int MarginsInBetween { get { return marginsInBetween; } set { marginsInBetween = value; } }
        public int MarginsFromSides { get { return marginsFromSides; } set { marginsFromSides = value; } }
        public int BoxWidth { get { return boxWidth; } set { boxWidth = value; } }
        public int BoxHeight { get { return boxHeight; } set { boxHeight = value; } }

        // CONSTRUCTOR ============================================================================================================
        public CharacterSelect(Game1 game1, Texture2D background, Player playerOne, Player playerTwo)
        {
            this.game1 = game1;
            this.background = background;
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;
            choosingPlayer = ChoosingPlayer.PlayerOne;
            
            // Margins and Button Sizes
            marginsInBetween = game1.GraphicsManager.PreferredBackBufferWidth / 16;
            marginsFromSides = game1.GraphicsManager.PreferredBackBufferWidth / 12;
            boxWidth = (game1.GraphicsManager.PreferredBackBufferWidth - (marginsInBetween * 5) - (marginsFromSides * 2)) / 6;
            boxHeight = (game1.GraphicsManager.PreferredBackBufferHeight - (game1.GraphicsManager.PreferredBackBufferHeight / 3) - (marginsFromSides));

            // Buttons
            back = new Button(
                game1.SpriteManager.Pixel,
                game1.SpriteManager.Arial16,
                new Rectangle(marginsFromSides / 3, game1.GraphicsManager.PreferredBackBufferHeight / 24, game1.GraphicsManager.PreferredBackBufferHeight / 15, game1.GraphicsManager.PreferredBackBufferHeight / 18));

            bella = new Button(
                game1.SpriteManager.Pixel, 
                game1.SpriteManager.Arial16, 
                new Rectangle(marginsFromSides, game1.GraphicsManager.PreferredBackBufferHeight / 3, boxWidth, boxHeight));
            
            brody = new Button(
                game1.SpriteManager.Pixel, 
                game1.SpriteManager.Arial16, 
                new Rectangle(marginsFromSides + (boxWidth + marginsInBetween), game1.GraphicsManager.PreferredBackBufferHeight / 3, boxWidth, boxHeight));

            maddy = new Button(
                game1.SpriteManager.Pixel,
                game1.SpriteManager.Arial16,
                new Rectangle(marginsFromSides + ((boxWidth + marginsInBetween) * 2), game1.GraphicsManager.PreferredBackBufferHeight / 3, boxWidth, boxHeight));

            maggie = new Button(
                game1.SpriteManager.Pixel,
                game1.SpriteManager.Arial16,
                new Rectangle(marginsFromSides + ((boxWidth + marginsInBetween) * 3), game1.GraphicsManager.PreferredBackBufferHeight / 3, boxWidth, boxHeight));

            owen = new Button(
                game1.SpriteManager.Pixel,
                game1.SpriteManager.Arial16,
                new Rectangle(marginsFromSides + ((boxWidth + marginsInBetween) * 4), game1.GraphicsManager.PreferredBackBufferHeight / 3, boxWidth, boxHeight));

            vincent = new Button(
                game1.SpriteManager.Pixel,
                game1.SpriteManager.Arial16,
                new Rectangle(marginsFromSides + ((boxWidth + marginsInBetween) * 5), game1.GraphicsManager.PreferredBackBufferHeight / 3, boxWidth, boxHeight));
        }

        // METHODS ================================================================================================================
        
        /// <summary>
        /// Update the CharacterSelect components
        /// </summary>
        public void Update()
        {
            

            switch (ChoosingPlayer)
            {
                case ChoosingPlayer.PlayerOne:
                    if (back.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        game1.GameManager.GameScreen = Screens.Menu;
                    }

                    if (bella.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerOne.Character = Characters.Bella;
                        ChoosingPlayer = ChoosingPlayer.PlayerTwo;
                        
                    }

                    if (brody.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerOne.Character = Characters.Brody;
                        ChoosingPlayer = ChoosingPlayer.PlayerTwo;
                    }

                    if (maddy.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerOne.Character = Characters.Maddy;
                        ChoosingPlayer = ChoosingPlayer.PlayerTwo;
                    }

                    if (maggie.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerOne.Character = Characters.Maggie;
                        ChoosingPlayer = ChoosingPlayer.PlayerTwo;
                    }

                    if (owen.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerOne.Character = Characters.Owen;
                        ChoosingPlayer = ChoosingPlayer.PlayerTwo;
                    }

                    if (vincent.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerOne.Character = Characters.Vincent;
                        ChoosingPlayer = ChoosingPlayer.PlayerTwo;
                    }
                    break;

                case ChoosingPlayer.PlayerTwo:
                    if (back.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerOne.Character = Characters.None;
                        ChoosingPlayer = ChoosingPlayer.PlayerOne;
                    }

                    if (bella.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerTwo.Character = Characters.Bella;
                        game1.GameManager.GameScreen = Screens.Game;
                    }

                    if (brody.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerTwo.Character = Characters.Brody;
                        game1.GameManager.GameScreen = Screens.Game;
                    }

                    if (maddy.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerTwo.Character = Characters.Maddy;
                        game1.GameManager.GameScreen = Screens.Game;
                    }

                    if (maggie.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerTwo.Character = Characters.Maggie;
                        game1.GameManager.GameScreen = Screens.Game;
                    }

                    if (owen.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerTwo.Character = Characters.Owen;
                        game1.GameManager.GameScreen = Screens.Game;
                    }

                    if (vincent.Clicked(game1.MouseState, game1.PreviousMouseState))
                    {
                        PlayerTwo.Character = Characters.Vincent;
                        game1.GameManager.GameScreen = Screens.Game;
                    }
                    break;
            }
            
        }

        /// <summary>
        /// Draw the CharacterSelect components
        /// </summary>
        public void Draw()
        {
            // Draw Background
            game1.SpriteBatch.Draw(background, new Rectangle(0, 0, game1.GraphicsManager.PreferredBackBufferWidth, game1.GraphicsManager.PreferredBackBufferHeight), Color.White);

            switch (ChoosingPlayer)
            {
                case ChoosingPlayer.PlayerOne:
                    // Draw Back Button
                    if (back.MouseInBounds(Game1.MouseState))
                    {
                        back.Draw(game1.SpriteBatch, "Back", back.ButtonShape, Alignment.Center, Color.Red, Color.White);
                    }
                    else
                    {
                        back.Draw(game1.SpriteBatch, "Back", back.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Bella Button
                    if (bella.MouseInBounds(Game1.MouseState))
                    {
                        bella.Draw(game1.SpriteBatch, "Bella", bella.ButtonShape, Alignment.Center, Color.Red, Color.White);
                    }
                    else
                    {
                        bella.Draw(game1.SpriteBatch, "Bella", bella.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Brody Button
                    if (brody.MouseInBounds(Game1.MouseState))
                    {
                        brody.Draw(game1.SpriteBatch, "Brody", brody.ButtonShape, Alignment.Center, Color.Red, Color.White);
                    }
                    else
                    {
                        brody.Draw(game1.SpriteBatch, "Brody", brody.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Maddy Button
                    if (maddy.MouseInBounds(Game1.MouseState))
                    {
                        maddy.Draw(game1.SpriteBatch, "Maddy", maddy.ButtonShape, Alignment.Center, Color.Red, Color.White);
                    }
                    else
                    {
                        maddy.Draw(game1.SpriteBatch, "Maddy", maddy.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Maggie Button
                    if (maggie.MouseInBounds(Game1.MouseState))
                    {
                        maggie.Draw(game1.SpriteBatch, "Maggie", maggie.ButtonShape, Alignment.Center, Color.Red, Color.White);
                    }
                    else
                    {
                        maggie.Draw(game1.SpriteBatch, "Maggie", maggie.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Owen Button
                    if (owen.MouseInBounds(Game1.MouseState))
                    {
                        owen.Draw(game1.SpriteBatch, "Owen", owen.ButtonShape, Alignment.Center, Color.Red, Color.White);
                    }
                    else
                    {
                        owen.Draw(game1.SpriteBatch, "Owen", owen.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Vincent Button
                    if (vincent.MouseInBounds(Game1.MouseState))
                    {
                        vincent.Draw(game1.SpriteBatch, "Vincent", vincent.ButtonShape, Alignment.Center, Color.Red, Color.White);
                    }
                    else
                    {
                        vincent.Draw(game1.SpriteBatch, "Vincent", vincent.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }
                    break;

                case ChoosingPlayer.PlayerTwo:
                    // Draw Back Button
                    if (back.MouseInBounds(Game1.MouseState))
                    {
                        back.Draw(game1.SpriteBatch, "Back", back.ButtonShape, Alignment.Center, Color.Blue, Color.White);
                    }
                    else
                    {
                        back.Draw(game1.SpriteBatch, "Back", back.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Bella Button
                    if (bella.MouseInBounds(Game1.MouseState))
                    {
                        bella.Draw(game1.SpriteBatch, "Bella", bella.ButtonShape, Alignment.Center, Color.Blue, Color.White);
                    }
                    else
                    {
                        bella.Draw(game1.SpriteBatch, "Bella", bella.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Brody Button
                    if (brody.MouseInBounds(Game1.MouseState))
                    {
                        brody.Draw(game1.SpriteBatch, "Brody", brody.ButtonShape, Alignment.Center, Color.Blue, Color.White);
                    }
                    else
                    {
                        brody.Draw(game1.SpriteBatch, "Brody", brody.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Maddy Button
                    if (maddy.MouseInBounds(Game1.MouseState))
                    {
                        maddy.Draw(game1.SpriteBatch, "Maddy", maddy.ButtonShape, Alignment.Center, Color.Blue, Color.White);
                    }
                    else
                    {
                        maddy.Draw(game1.SpriteBatch, "Maddy", maddy.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Maggie Button
                    if (maggie.MouseInBounds(Game1.MouseState))
                    {
                        maggie.Draw(game1.SpriteBatch, "Maggie", maggie.ButtonShape, Alignment.Center, Color.Blue, Color.White);
                    }
                    else
                    {
                        maggie.Draw(game1.SpriteBatch, "Maggie", maggie.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Owen Button
                    if (owen.MouseInBounds(Game1.MouseState))
                    {
                        owen.Draw(game1.SpriteBatch, "Owen", owen.ButtonShape, Alignment.Center, Color.Blue, Color.White);
                    }
                    else
                    {
                        owen.Draw(game1.SpriteBatch, "Owen", owen.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }

                    // Draw Vincent Button
                    if (vincent.MouseInBounds(Game1.MouseState))
                    {
                        vincent.Draw(game1.SpriteBatch, "Vincent", vincent.ButtonShape, Alignment.Center, Color.Blue, Color.White);
                    }
                    else
                    {
                        vincent.Draw(game1.SpriteBatch, "Vincent", vincent.ButtonShape, Alignment.Center, Color.Black, Color.White);
                    }
                    break;
            }
        }

    }
}
