using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class Player
    {
        // Fields
        private int health;
        private string name;
        private Character characterType;
        private Deck characterDeck;

        // Properties
        public int Health { get { return health; } set { health = value; } }
        public string Name { get { return name; } set { name = value; } }
        public Character CharacterType { get { return characterType; } }
        public Deck CharacterDeck { get { return characterDeck; } }
    }
}
