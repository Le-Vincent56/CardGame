using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



namespace CardGame
{
    public class Character
    {
        private List<Card> characterDeck;
        private Characters chosenCharacter;

        public Character()
        {
            characterDeck = new List<Card>();
        }

        private void ReadDeck(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);

            string fileLine = "";
            while ((fileLine = reader.ReadLine())!= null)
            {
                string[] lineData = fileLine.Split('|');
                if (lineData[0] == "s")
                {
                    SpellCard sCard = new SpellCard(lineData[1], int.Parse(lineData[2]), lineData[3], int.Parse(lineData[4]), int.Parse(lineData[5]));
                    characterDeck.Add(sCard);
                }
                else
                {
                    MinionCard mCard = new MinionCard(lineData[1], int.Parse(lineData[2]), lineData[3], int.Parse(lineData[4]), int.Parse(lineData[5]));
                    characterDeck.Add(mCard);
                }
            }
        }
    }
}
