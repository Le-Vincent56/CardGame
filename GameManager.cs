using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame
{
    class GameManager
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
            this.game = game;
            this.gameState = GameState.Title;
        }

        // METHODS ================================================================================================================
        public void Update(Menu menu)
        {
            menu.Update(game1);
        }
    }
}
