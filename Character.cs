using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public enum Characters
{
    None,
    Bella,
    Owen,
    Maddy,
    Maggie,
    Vincent,
    Brody
}

namespace CardGame
{
    public class Character
    {
        private List<Card> characterDeck;
        private Characters chosenCharacter;

        public Character(int characterNum)
        {
            characterDeck = new List<Card>();
            chosenCharacter = (Characters) characterNum;
            ChooseCharacter();
        }

        private void ChooseCharacter()
        {
            switch (chosenCharacter)
            {
                case Characters.Bella:

                    break;

                case Characters.Owen:
                    break;

                case Characters.Maddy:
                    break;

                case Characters.Maggie:
                    break;

                case Characters.Vincent:
                    break;

                case Characters.Brody:
                    break;
            }
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
                }
                else
                {

                }
            }
        }
    }
}
