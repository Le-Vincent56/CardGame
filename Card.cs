using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class Card
    {
        public enum CardType
        {
            Vincent,
            Brody,
            Maddy,
            Owen,
            Maggie,
            Bella
        }

        // Fields
        protected string name;
        protected int manaCost;
        protected string description;

        // Properties
        public string Name { get { return name; } }
        public int ManaCost { get { return manaCost; } set { manaCost = value; } }
        public string Description { get { return description; } }

        // Constructor
        public Card(string name, int manaCost, string description)
        {
            this.name = name;
            this.manaCost = manaCost;
            this.description = description;
        }

        // Methods
        public void Play()
        {

        }

        public void Discard()
        {

        }
    }
}
