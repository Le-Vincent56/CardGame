using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class MinionCard : Card
    {
        // Fields
        private int health;
        private int attack;

        // Properties
        public int Health { get { return health; } set { health = value; } }
        public int Attack { get { return attack; } set { attack = value; } }

        // Constructor
        public MinionCard(string name, int manaCost, string description, int health, int attack)
            : base(name, manaCost, description)
        {
            this.health = health;
            this.attack = attack;
        }

        // Methods
        public GameObject Play(GameObject target)
        {
            if (target is MinionCard)
            {
                MinionCard tempTarget = (MinionCard)target;
                tempTarget.health -= this.attack;
                this.health -= tempTarget.attack;
                target = tempTarget;
            }
            else if (target is Player)
            {
                Player tempTarget = (Player)target;
                tempTarget.Health -= this.attack;
                target = tempTarget;
            }
            return target;
        }

    }
}
