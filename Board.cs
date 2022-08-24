using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CardGame
{
    public class Board
    {
        // FIELDS =================================================================================================================
        private Game1 game1;

        // Players
        private Player playerOne;
        private Player playerTwo;

        // Decks
        private Rectangle playerOneDeckSpace;
        private Rectangle playerTwoDeckSpace;

        // Regions
        private Rectangle playerOneSide;
        private Rectangle playerTwoSide;
        private Rectangle playerOneHand;
        private Rectangle playerTwoHand;
        private Rectangle playerOneField;
        private Rectangle playerTwoField;

        // Health
        private Rectangle playerOneHealthBox;
        private Rectangle playerTwoHealthBox;

        // Names
        private Button playerOneNameBox;
        private Button playerTwoNameBox;

        // PROPERTIES =============================================================================================================
        // Players
        public Player PlayerOne { get { return playerOne; } set { playerOne = value; } }
        public Player PlayerTwo { get { return playerTwo; } set { playerTwo = value; } }

        // Decks
        public Rectangle PlayerOneDeckSpace { get { return playerOneDeckSpace; } set { playerOneDeckSpace = value; } }
        public Rectangle PlayerTwoDeckSpace { get { return playerTwoDeckSpace; } set { playerTwoDeckSpace = value; } }

        // Regions
        public Rectangle PlayerOneSide { get { return playerOneSide; } set { playerOneSide = value; } }
        public Rectangle PlayerTwoSide { get { return playerTwoSide; } set { playerTwoSide = value; } }
        public Rectangle PlayerOneHand { get { return playerOneHand; } set { playerOneHand = value; } }
        public Rectangle PlayerTwoHand { get { return playerTwoHand; } set { playerTwoHand = value; } }
        public Rectangle PlayerOneField { get { return playerOneField; } set { playerOneField = value; } }
        public Rectangle PlayerTwoField { get { return playerTwoField; } set { playerTwoField = value; } }

        // Health
        public Rectangle PlayerOneHealthBox { get { return playerOneHealthBox; } set { playerOneHealthBox = value; } }
        public Rectangle PlayerTwoHealthBox { get { return playerTwoHealthBox; } set { playerTwoHealthBox = value; } }

        // Names
        public Button PlayerOneNameBox { get { return playerOneNameBox; } set { playerOneNameBox = value; } }
        public Button PlayerTwoNameBox { get { return playerTwoNameBox; } set { playerTwoNameBox = value; } }

        // CONSTRUCTOR ============================================================================================================
        public Board(Game1 game1, Player playerOne, Player playerTwo)
        {
            this.game1 = game1;

            // Initialize Players
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;

            // Create Board Spaces
            // Player One Side
            playerOneSide = new Rectangle(
                0, 
                game1.GraphicsManager.PreferredBackBufferHeight / 2, 
                game1.GraphicsManager.PreferredBackBufferWidth, 
                game1.GraphicsManager.PreferredBackBufferHeight / 2);

            playerOneHand = new Rectangle(
                0,
                game1.GraphicsManager.PreferredBackBufferHeight - (game1.GraphicsManager.PreferredBackBufferHeight / 6),
                game1.GraphicsManager.PreferredBackBufferWidth,
                game1.GraphicsManager.PreferredBackBufferHeight / 6);

            playerOneField = new Rectangle(
                0,
                game1.GraphicsManager.PreferredBackBufferHeight / 2,
                game1.GraphicsManager.PreferredBackBufferWidth,
                playerOneSide.Height - playerOneHand.Height);

            playerOneDeckSpace = new Rectangle(
                game1.GraphicsManager.PreferredBackBufferWidth / 14, 
                (game1.GraphicsManager.PreferredBackBufferHeight / 2) + (playerOneField.Height / 6), 
                playerOneField.Width / 9,
                playerOneField.Height - ((playerOneField.Height / 6) * 2));

            PlayerOneNameBox = new Button(
                game1.SpriteManager.Pixel,
                game1.SpriteManager.Arial16,
                new Rectangle(
                    0,
                    game1.GraphicsManager.PreferredBackBufferHeight - playerOneHand.Height,
                    playerOneHand.Width / 9,
                    playerOneHand.Height));

            // Player Two Side
            playerTwoSide = new Rectangle(
                0, 
                0, 
                game1.GraphicsManager.PreferredBackBufferWidth, 
                game1.GraphicsManager.PreferredBackBufferHeight / 2);

            playerTwoHand = new Rectangle(
                0,
                0,
                game1.GraphicsManager.PreferredBackBufferWidth,
                game1.GraphicsManager.PreferredBackBufferHeight / 6);

            playerTwoField = new Rectangle(
                0,
                playerTwoHand.Height,
                game1.GraphicsManager.PreferredBackBufferWidth,
                playerTwoSide.Height - playerTwoHand.Height);

            playerTwoDeckSpace = new Rectangle(
                game1.GraphicsManager.PreferredBackBufferWidth - (game1.GraphicsManager.PreferredBackBufferWidth / 14) - playerTwoField.Width / 9,
                playerTwoHand.Height + (playerOneField.Height / 6),
                playerTwoField.Width / 9,
                playerTwoField.Height - ((playerTwoField.Height / 6) * 2));

            PlayerTwoNameBox = new Button(
                game1.SpriteManager.Pixel,
                game1.SpriteManager.Arial16,
                new Rectangle(
                    game1.GraphicsManager.PreferredBackBufferWidth - (playerTwoHand.Width / 9),
                    0,
                    playerTwoHand.Width / 9,
                    playerTwoHand.Height));


        }

        // METHODS ================================================================================================================
        /// <summary>
        /// Draw the board
        /// </summary>
        /// <param name="sb">The SpriteBatch</param>
        public void Draw()
        {
            

            // Draw Player One Side
            if (playerOneSide.Contains(game1.MouseState.X, game1.MouseState.Y) &&
                !playerOneHand.Contains(game1.MouseState.X, game1.MouseState.Y) &&
                !playerOneField.Contains(game1.MouseState.X, game1.MouseState.Y) && 
                !playerOneDeckSpace.Contains(game1.MouseState.X, game1.MouseState.Y))
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerOneSide, Color.Red);
            } else
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerOneSide, Color.White);
            }

            if (playerOneHand.Contains(game1.MouseState.X, game1.MouseState.Y) &&
                !playerOneField.Contains(game1.MouseState.X, game1.MouseState.Y) && 
                !playerOneDeckSpace.Contains(game1.MouseState.X, game1.MouseState.Y))
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerOneHand, Color.Red);
            }
            else
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerOneHand, Color.White);
            }

            if (playerOneField.Contains(game1.MouseState.X, game1.MouseState.Y) && 
                !playerOneDeckSpace.Contains(game1.MouseState.X, game1.MouseState.Y))
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerOneField, Color.Red);
            }
            else
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerOneField, Color.White);
            }

            if(playerOneDeckSpace.Contains(game1.MouseState.X, game1.MouseState.Y))
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerOneDeckSpace, Color.Green);
            } else
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerOneDeckSpace, Color.White);
            }

            // Draw Player Two Field
            if (playerTwoSide.Contains(game1.MouseState.X, game1.MouseState.Y) &&
                !playerTwoHand.Contains(game1.MouseState.X, game1.MouseState.Y) &&
                !playerTwoField.Contains(game1.MouseState.X, game1.MouseState.Y) &&
                !playerTwoDeckSpace.Contains(game1.MouseState.X, game1.MouseState.Y))
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerTwoSide, Color.Blue);
            }
            else
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerTwoSide, Color.White);
            }

            if (playerTwoHand.Contains(game1.MouseState.X, game1.MouseState.Y) &&
                !playerTwoField.Contains(game1.MouseState.X, game1.MouseState.Y) &&
                !playerTwoDeckSpace.Contains(game1.MouseState.X, game1.MouseState.Y))
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerTwoHand, Color.Blue);
            }
            else
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerTwoHand, Color.White);
            }

            if (playerTwoField.Contains(game1.MouseState.X, game1.MouseState.Y) &&
                !playerTwoDeckSpace.Contains(game1.MouseState.X, game1.MouseState.Y))
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerTwoField, Color.Blue);
            }
            else
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerTwoField, Color.White);
            }

            if (playerTwoDeckSpace.Contains(game1.MouseState.X, game1.MouseState.Y))
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerTwoDeckSpace, Color.Green);
            }
            else
            {
                game1.SpriteBatch.Draw(game1.SpriteManager.Pixel, playerTwoDeckSpace, Color.White);
            }

            playerOneNameBox.Draw(game1.SpriteBatch, playerOne.Character.ToString() + ": " + playerOne.Health.ToString(), playerOneNameBox.Position, Alignment.Center, Color.Black, Color.White);
            playerTwoNameBox.Draw(game1.SpriteBatch, playerTwo.Character.ToString() + ": " + playerTwo.Health.ToString(), playerTwoNameBox.Position, Alignment.Center, Color.Black, Color.White);

        }
    }
}
