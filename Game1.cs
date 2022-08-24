using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace CardGame
{ 
    public enum Screens
    {
        Title,
        Menu,
        Lore,
        CharacterSelect,
        Game,
        Results,
        Options
    }

    public class Game1 : Game
    {
        // FIELDS =================================================================================================================
        // Managers
        private GraphicsDeviceManager graphicsManager;
        private SpriteManager spriteManager;
        private GameManager gameManager;
        private SpriteBatch spriteBatch;

        // Time Variables
        private double elapsedMilliSeconds;

        // Screens
        private Title title;
        private Menu menu;
        private CharacterSelect characterSelect;
        private Board board;

        // Keyboard and Mouse States
        private KeyboardState keyboardState;
        private MouseState mouseState;
        private KeyboardState previousKeyboardState;
        private MouseState previousMouseState;

        // Players
        private Player playerOne;
        private Player playerTwo;

        // PROPERTIES =============================================================================================================
        // Managers
        public GraphicsDeviceManager GraphicsManager { get { return graphicsManager; } set { graphicsManager = value; } }
        public GameManager GameManager { get { return gameManager; } set { gameManager = value; } }
        public SpriteManager SpriteManager { get { return spriteManager; } set { spriteManager = value; } }
        public SpriteBatch SpriteBatch { get { return spriteBatch; } set { spriteBatch = value; } }

        // Time Variables
        public double ElapsedMilliSeconds { get { return elapsedMilliSeconds; } set { elapsedMilliSeconds = value; } }

        // Screens
        public Title Title { get { return title; } set { title = value; } }
        public Menu Menu { get { return menu; } set { menu = value; } }
        public CharacterSelect CharacterSelect { get { return characterSelect; } set { characterSelect = value; } }
        public Board Board { get { return board; } set { board = value; } }

        // Keyboard and Mouse States
        public KeyboardState KeyboardState { get { return keyboardState; } set { keyboardState = value; } }
        public MouseState MouseState { get { return mouseState; } set { mouseState = value; } }
        public KeyboardState PreviousKeyboardState { get { return previousKeyboardState; } set { previousKeyboardState = value; } }
        public MouseState PreviousMouseState { get { return previousMouseState; } set { previousMouseState = value; } }

        // Players
        public Player PlayerOne { get { return playerOne; } set { playerOne = value; } }
        public Player PlayerTwo { get { return playerTwo; } set { playerTwo = value; } }

        public Game1()
        {
            graphicsManager = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // Set Window Size
            GraphicsManager.PreferredBackBufferWidth = 1920;
            GraphicsManager.PreferredBackBufferHeight = 1080;
            GraphicsManager.ApplyChanges();

            // Load Managers
            GameManager = new GameManager(this);
            SpriteManager = new SpriteManager(this);

            // Load Players
            PlayerOne = new Player("Player One");
            PlayerTwo = new Player("Player Two");

            base.Initialize();
        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);

            // Load Sprites
            SpriteManager.LoadContent();

            // Load Screens/Menu
            Menu = new Menu(this, SpriteManager.MenuBackground);
            Title = new Title(this, SpriteManager.TitleBackground, SpriteManager.Pixel, SpriteManager.Arial16);
            CharacterSelect = new CharacterSelect(this, SpriteManager.CharacterSelectBackground, PlayerOne, PlayerTwo);
            Board = new Board(this, PlayerOne, PlayerTwo);
        }

        protected override void Update(GameTime gameTime)
        {
            // Get Mouse and Keyboard Input
            KeyboardState = Keyboard.GetState();
            MouseState = Mouse.GetState();

            // FSM Based on GameScreen
            switch (GameManager.GameScreen)
            {
                case Screens.Title:
                    Title.Update();
                    break;

                case Screens.Game:
                    
                    break;

                case Screens.Lore:
                    break;

                case Screens.Options:
                    break;

                case Screens.CharacterSelect:
                    CharacterSelect.Update();
                    break;

                case Screens.Menu:
                    Menu.Update();
                    break;
            }

            // Update Mouse and Keyboard States
            PreviousKeyboardState = KeyboardState;
            PreviousMouseState = MouseState;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            SpriteBatch.Begin();

            switch (GameManager.GameScreen)
            {
                case Screens.Title:
                    Title.Draw();
                    break;

                case Screens.Game:
                    Board.Draw();
                    break;

                case Screens.Lore:
                    break;

                case Screens.Options:
                    break;

                case Screens.CharacterSelect:
                    CharacterSelect.Draw();
                    break;

                case Screens.Menu:
                    Menu.Draw();
                    break;
            }

            SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
