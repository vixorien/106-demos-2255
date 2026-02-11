using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Chris Cascioli
// 2/11/26
// Example of a finite state machine

namespace FSMDemo
{
    /// <summary>
    /// Possible states for my overall game
    /// </summary>
    enum GameState
    {
        MainMenu,
        Options,
        Gameplay,
        Pause
    }

    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private SpriteFont font;

        // State tracking
        private GameState currentState;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            currentState = GameState.MainMenu;

			base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            font = Content.Load<SpriteFont>("Verdana24");
        }

        protected override void Update(GameTime gameTime)
        {
			// Grab the current keyboard state
			KeyboardState kb = Keyboard.GetState();

			// Handle all update-related work in this FSM
			switch (currentState)
			{
				case GameState.MainMenu:
					// ONLY check main menu-related work here
					if (kb.IsKeyDown(Keys.O))
					{
						// Move to the options state
						currentState = GameState.Options;
					}
					else if (kb.IsKeyDown(Keys.Enter))
					{
						// Move to the gameplay state
						currentState = GameState.Gameplay;
					}

					break;

				case GameState.Options:
					if (kb.IsKeyDown(Keys.Escape))
					{
						// Move to the main menu
						currentState = GameState.MainMenu;
					}
					break;

				case GameState.Gameplay:
					if (kb.IsKeyDown(Keys.P))
					{
						// Move to the pause screen
						currentState = GameState.Pause;
					}
					break;

				case GameState.Pause:
					if (kb.IsKeyDown(Keys.Escape))
					{
						// Move to the gameplay state
						currentState = GameState.Gameplay;
					}
					else if (kb.IsKeyDown(Keys.Q))
					{
						// Quit back to the main menu
						currentState = GameState.MainMenu;
					}
					break;
			}

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

			// Handle all state-related drawing here
			switch (currentState)
			{
				case GameState.MainMenu:
                    // "Draw" the main menu
                    _spriteBatch.DrawString(
                        font,
                        "Main Menu!\n\nPress 'O' for options\nPress 'Enter' to play",
                        new Vector2(20, 20),
                        Color.White);
					break;

				case GameState.Options:
					// "Draw" the options screen
					_spriteBatch.DrawString(
						font,
						"Options!\n\nPress 'Escape' to go back",
						new Vector2(20, 20),
						Color.White);
					break;

				case GameState.Gameplay:
					// "Draw" the game
					_spriteBatch.DrawString(
						font,
						"The game!\n\nPress 'P' to pause",
						new Vector2(20, 20),
						Color.White);
					break;

				case GameState.Pause:
					// "Draw" the game
					_spriteBatch.DrawString(
						font,
						"Paused!\n\nPress 'Escape' to unpause\nPress 'Q' to quit",
						new Vector2(20, 20),
						Color.White);
					break;
			}

            _spriteBatch.End();

			base.Draw(gameTime);
        }
	}
}
