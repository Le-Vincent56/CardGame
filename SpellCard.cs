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
        private void CheckSpellType(CardType type)
        {
            switch (type)
            {
                case CardType.Damage:

                    break;

                case CardType.Buff:

                    break;

                case CardType.Control:

                    break;

                case CardType.Heal:

                    break;
            }
        }

        public void Play(CardType type, )
        {

            switch (type)
            {
                case CardType.Damage:
                    if (target is MinionCard)
                    {
                        (MinionCard)target
                    }
                    break;

                case CardType.Buff:

                    break;

                case CardType.Control:

                    break;

                case CardType.Heal:

                    break;
            }
        }

        public void SelectTarget()
        {

        }
    }
}

