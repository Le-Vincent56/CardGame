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
        public void Update(Menu menu)
        {
            menu.Update(game1);
        }

        public void Draw(Menu menu)
        {

        }
    }
}
