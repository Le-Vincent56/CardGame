using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class Player
    {
        // FIELDS =================================================================================================================
        private int health;
        private string name;
        private Characters character;
        private Deck characterDeck;

        // PROPERTIES =============================================================================================================
        public int Health { get { return health; } set { health = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Characters Character { get { return character; } set { character = value; } }
        public Deck CharacterDeck { get { return characterDeck; } }

        // CONSTRUCTOR ============================================================================================================
        public Player(string name)
        {
            health = 20;
            character = Characters.None;
            this.characterDeck = null;
        }

        // METHODS ================================================================================================================
    }
}
