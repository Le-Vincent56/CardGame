using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class Card
    {
        // Fields
        protected string name;
        protected int manaCost;
        protected string description;

        // Properties
        public string Name { get { return name; } }
        public int ManaCost { get { return manaCost; } set { manaCost = value; } }
        public string Description { get { return description; } }

        // Methods
        public void Play()
        {

        }

        public void Discard()
        {

        }
    }
}
