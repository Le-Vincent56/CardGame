using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    public class GameManager
    {
        // FIELDS =================================================================================================================
        private Game1 game1;
        private Screens gameScreen;
        private Screens previousScreen;

        // PROPERTIES =============================================================================================================
        public Screens GameScreen { get { return gameScreen; } set { gameScreen = value; } }
        public Screens PreviousScreen { get { return previousScreen; } set { previousScreen = value; } }

        // CONSTRUCTOR ============================================================================================================
        public GameManager(Game1 game)
        {
            this.game1 = game;
            this.gameScreen = Screens.Title;
        }

        // METHODS ================================================================================================================
        /// <summary>
        /// Update the Game
        /// </summary>
        public void Update()
        {
            switch (gameScreen)
            {
                case Screens.Title:
                    break;

                case Screens.Menu:
                    break;

                case Screens.Lore:
                    break;

                case Screens.CharacterSelect:
                    break;

                case Screens.Game:
                    break;

                case Screens.Results:
                    break;
                    
                case Screens.Options:
                    break;
            }
        }

        /// <summary>
        /// Draw the Game
        /// </summary>
        public void Draw()
        {
            switch (gameScreen)
            {
                case Screens.Title:
                    break;

                case Screens.Game:
                    break;

                case Screens.Lore:
                    break;

                case Screens.Options:
                    break;

                case Screens.CharacterSelect:
                    break;

                case Screens.Menu:
                    break;
            }
        }
    }
}
