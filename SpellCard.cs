using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public enum CardType
    {
        Damage,
        Buff,
        Control,
        Heal
    }

    class SpellCard : Card
    {
        // Fields 
        private CardType spellType;
        private int flexNumber;

        // Constructor        
        public SpellCard(string name, int manaCost, string description, int type, int flexNumber)
            : base(name, manaCost, description)
        {
            spellType = (CardType)type;
            this.flexNumber = flexNumber;
        }

        // Methods

        public GameObject Play(CardType type, GameObject target)
        {
            switch (type)
            {
                case CardType.Damage:
                    if (target is MinionCard)
                    {
                        MinionCard tempTarget = (MinionCard)target;
                        tempTarget.Health -= flexNumber;
                        target = tempTarget;
                    }
                    else if(target is Player)
                    {
                        Player tempPlayer = (Player)target;
                        tempPlayer.Health -= flexNumber;
                        target = tempPlayer;
                    }
                    break;

                case CardType.Buff:
                    if (target is MinionCard)
                    {
                        MinionCard tempTarget = (MinionCard)target;
                        tempTarget.Attack += flexNumber;
                        target = tempTarget;
                    }
                    break;

                case CardType.Control:

                    break;

                case CardType.Heal:
                    if (target is MinionCard)
                    {
                        MinionCard tempTarget = (MinionCard)target;
                        tempTarget.Health += flexNumber;
                        target = tempTarget;
                    }

                    break;
            }
            return target;
        }

        public void SelectTarget()
        {

        }
    }
}

