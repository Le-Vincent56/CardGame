using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Card
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

        // FIELDS =================================================================================================================
        protected string name;
        protected int manaCost;
        protected string description;

        // PROPERTIES =============================================================================================================
        public string Name { get { return name; } }
        public int ManaCost { get { return manaCost; } set { manaCost = value; } }
        public string Description { get { return description; } }

        // CONSTRUCTOR ============================================================================================================
        public Card(string name, int manaCost, string description)
        {
            this.name = name;
            this.manaCost = manaCost;
            this.description = description;
        }

        // METHODS ================================================================================================================
        public void Play()
        {

        }

        public void Discard()
        {

        }
    }
}
