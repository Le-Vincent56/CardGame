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
        private GraphicsDeviceManager graphicsManager;
        private SpriteManager spriteManager;
        private GameManager gameManager;
        private SpriteBatch spriteBatch;

        private Title title;
        private Menu main;

        private KeyboardState keyboardState;
        private MouseState mouseState;
        private KeyboardState previousKeyboardState;
        private MouseState previousMouseState;

        // PROPERTIES =============================================================================================================
        public GraphicsDeviceManager GraphicsManager { get { return graphicsManager; } set { graphicsManager = value; } }
        public GameManager GameManager { get { return gameManager; } set { gameManager = value; } }
        public SpriteManager SpriteManager { get { return spriteManager; } set { spriteManager = value; } }
        public SpriteBatch SpriteBatch { get { return spriteBatch; } set { spriteBatch = value; } }

        public Title Title { get { return title; } set { title = value; } }
        public Menu Main { get { return main; } set { main = value; } }

        public KeyboardState KeyboardState { get { return keyboardState; } set { keyboardState = value; } }
        public MouseState MouseState { get { return mouseState; } set { mouseState = value; } }
        public KeyboardState PreviousKeyboardState { get { return previousKeyboardState; } set { previousKeyboardState = value; } }
        public MouseState PreviousMouseState { get { return previousMouseState; } set { previousMouseState = value; } }

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

            base.Initialize();
        }

        protected override void LoadContent()
        {
            SpriteBatch = new SpriteBatch(GraphicsDevice);

            // Load Sprites
            SpriteManager.LoadContent();

            // Load Screens/Menu
            Main = new Menu(this, SpriteManager.MenuBackground);
            Title = new Title(this, SpriteManager.TitleBackground, SpriteManager.Pixel, SpriteManager.Arial16);
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
                    break;

                case Screens.Menu:
                    Main.Update();
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
                    break;

                case Screens.Lore:
                    break;

                case Screens.Options:
                    break;

                case Screens.CharacterSelect:
                    break;

                case Screens.Menu:
                    Main.Draw();
                    break;
            }

            SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
