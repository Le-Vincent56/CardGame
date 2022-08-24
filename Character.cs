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
            chosenCharacter = (Characters)characterNum;
            ReadDeck(ChooseCharacterFile(chosenCharacter));
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

        private string ChooseCharacterFile(Characters chosenCharacter)
        {
            string filenameToReturn = "../../../TestDeck.txt";
            switch (chosenCharacter)
            {
                case Characters.Bella:
                    filenameToReturn = "../../../TestDeck.txt";
                    break;

                case Characters.Brody:
                    filenameToReturn = "../../../TestDeck.txt";
                    break;

                case Characters.Vincent:
                    filenameToReturn = "../../../TestDeck.txt";
                    break;

                case Characters.Maddy:
                    filenameToReturn = "../../../TestDeck.txt";
                    break;

                case Characters.Maggie:
                    filenameToReturn = "../../../TestDeck.txt";
                    break;

                case Characters.Owen:
                    filenameToReturn = "../../../TestDeck.txt";
                    break;
            }

            return filenameToReturn;
        }
    }
}
