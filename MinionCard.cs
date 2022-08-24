using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class MinionCard : Card
    {
        // Fields
        private int health;

        // Properties
        public int Health { get { return health; } set { health = value; } }

        // Constructor
        public MinionCard(string name, int manaCost, string description)
            : base(name, manaCost, description)
        {

        }

        // Methods


    }
}
