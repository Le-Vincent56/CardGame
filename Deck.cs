using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace CardGame
{
    public class Deck
    {
        private List<Card> deck;
        private Vector2 centerPos;

        public int DeckCount { get { return deck.Count; } }

        public Deck(GraphicsDeviceManager graphics)
        {
            deck = new List<Card>();
            centerPos = new Vector2(graphics.PreferredBackBufferWidth - 100, graphics.PreferredBackBufferHeight - 100);
            FillDeck();
        }

        private void Draw()
        {

        }

        private void FillDeck()
        {

        }
    }
}
