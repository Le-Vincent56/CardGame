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

        private Menu main;

        // PROPERTIES =============================================================================================================
        public GraphicsDeviceManager GraphicsManager { get { return graphicsManager; } set { graphicsManager = value; } }
        public GameManager GameManager { get { return gameManager; } set { gameManager = value; } }
        public SpriteManager SpriteManager { get { return spriteManager; } set { spriteManager = value; } }
        public SpriteBatch SpriteBatch { get { return spriteBatch; } set { spriteBatch = value; } }

        public Menu Main { get { return main; } set { main = value; } }

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
            Main = new Menu(this, SpriteManager.Pixel);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            SpriteBatch.Begin();

            GameManager.Draw(main);

            SpriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
