using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class Card : GameObject
    { 
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

        public void SelectTarget()
        {

        }
    }
}
