using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace CardGame
{
    class Board
    {
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
        private int playerOneHealth;
        private int playerTwoHealth;
        private Rectangle playerOneHealthBox;
        private Rectangle playerTwoHealthBox;

        // Field - Names
        private string playerOneName;
        private string playerTwoName;
        private Rectangle playerOneNameBox;
        private Rectangle playerTwoNameBox;

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

        // Constructor


    }
}
