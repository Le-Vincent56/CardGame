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
        private Character characterType;
        private Deck characterDeck;

        // PROPERTIES =============================================================================================================
        public int Health { get { return health; } set { health = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Character CharacterType { get { return characterType; } }
        public Deck CharacterDeck { get { return characterDeck; } }

        // CONSTRUCTOR ============================================================================================================
        public Player(string name, Character characterType, Deck characterDeck)
        {
            health = 20;
            this.characterType = characterType;
            this.characterDeck = characterDeck;
        }

        // METHODS ================================================================================================================
    }
}
