using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace CardGame
{
    class Deck
    {
        private List<card> Deck;
        private Vector2 position;

        public int DeckCount { get { value = Deck.Count; } }
    }
}
