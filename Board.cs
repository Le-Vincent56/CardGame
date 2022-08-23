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
        // Field - Sprites
        private Texture2D pixel;

        // Field - Players
        private Player playerOne;
        private Player playerTwo;

        // Field - Decks
        private Rectangle playerOneDeckSpace;
        private Rectangle playerTwoDeckSpace;

        // Field - Regions
        private Rectangle playerOneSide;
        private Rectangle playerTwoSide;
        private Rectangle playerOneHand;
        private Rectangle playerTwoHand;
        private Rectangle playerOneField;
        private Rectangle playerTwoField;

        // Field - Health
        private Rectangle playerOneHealthBox;
        private Rectangle playerTwoHealthBox;

        // Field - Names
        private Rectangle playerOneNameBox;
        private Rectangle playerTwoNameBox;

        // PROPERTIES =============================================================================================================
        // Properties - Players
        public Player PlayerOne { get { return playerOne; } set { playerOne = value; } }
        public Player PlayerTwo { get { return playerTwo; } set { playerTwo = value; } }

        // Properties - Decks
        public Rectangle PlayerOneDeckSpace { get { return playerOneDeckSpace; } set { playerOneDeckSpace = value; } }
        public Rectangle PlayerTwoDeckSpace { get { return playerTwoDeckSpace; } set { playerTwoDeckSpace = value; } }

        // Properties - Regions
        public Rectangle PlayerOneSide { get { return playerOneSide; } set { playerOneSide = value; } }
        public Rectangle PlayerTwoSide { get { return playerTwoSide; } set { playerTwoSide = value; } }
        public Rectangle PlayerOneHand { get { return playerOneHand; } set { playerOneHand = value; } }
        public Rectangle PlayerTwoHand { get { return playerTwoHand; } set { playerTwoHand = value; } }
        public Rectangle PlayerOneField { get { return playerOneField; } set { playerOneField = value; } }
        public Rectangle PlayerTwoField { get { return playerTwoField; } set { playerTwoField = value; } }

        // Properties - Health
        public Rectangle PlayerOneHealthBox { get { return playerOneHealthBox; } set { playerOneHealthBox = value; } }
        public Rectangle PlayerTwoHealthBox { get { return playerTwoHealthBox; } set { playerTwoHealthBox = value; } }

        // Properties - Names
        private Rectangle PlayerOneNameBox { get { return playerOneNameBox; } set { playerOneNameBox = value; } }
        private Rectangle PlayerTwoNameBox { get { return playerTwoNameBox; } set { playerTwoNameBox = value; } }

        // CONSTRUCTOR ============================================================================================================
        public Board(Player playerOne, Player playerTwo, int widthOfScreen, int heightOfScreen, Texture2D pixel)
        {
            // Initialize Sprites
            this.pixel = pixel;

            // Initialize Players
            this.playerOne = playerOne;
            this.playerTwo = playerTwo;

            // Create Board Spaces
            playerOneSide = new Rectangle(0, heightOfScreen / 2, widthOfScreen / 2, heightOfScreen / 2);
            playerTwoSide = new Rectangle(0, 0, widthOfScreen / 2, heightOfScreen / 2);
        }

        // METHODS ================================================================================================================
        public void Draw(SpriteBatch sb)
        {
            sb.Draw(pixel, playerOneSide, Color.Red);
            sb.Draw(pixel, playerTwoSide, Color.Blue);
        }
    }
}
