using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

// Chris Cascioli
// 2/9/26
// Example of text and input in MonoGame

namespace MonoGameBasicsDemo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Fields
        private Texture2D marioTexture;
        private Vector2 marioPosition;

        // Text-related fields
        // - One spritefont per font/size/style combination
        private SpriteFont font;

        // Color-related fields for random color generation
        private Color marioColor;
        private Random rng;

        // More sophisticated input usually requires
        // storing info about previous frame input
        private KeyboardState prevKB;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            marioPosition = new Vector2(-150, -150);

            rng = new Random();
            marioColor = new Color(
                rng.Next(256),
                rng.Next(256),
                rng.Next(256));

			base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // The "asset" name when loading is the original
            // file name WITHOUT extension
            marioTexture = Content.Load<Texture2D>("mario");

            // Load fonts
            font = Content.Load<SpriteFont>("Verdana24");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Grab the state of the keyboard this frame
            KeyboardState kb = Keyboard.GetState();

            // Check various keys
            Vector2 move = Vector2.Zero;
            if (kb.IsKeyDown(Keys.W))
            {
				move.Y -= 5.0f;
            }
            if (kb.IsKeyDown(Keys.S))
            {
				move.Y += 5.0f;
			}
			if (kb.IsKeyDown(Keys.A))
			{
				move.X -= 5.0f;
			}
			if (kb.IsKeyDown(Keys.D))
			{
				move.X += 5.0f;
			}

            // After all input is checked, validate
            // the movement vector
            if (move.LengthSquared() > 0)
            {
                move.Normalize();
            }

            // Apply movement
            marioPosition += move * 5;


            // Handle color changing
            if (kb.IsKeyDown(Keys.Tab) && prevKB.IsKeyUp(Keys.Tab))
            {
                marioColor = new Color(
                    rng.Next(256),
                    rng.Next(256),
                    rng.Next(256));

			}

            // Save this frame's state for next frame
            prevKB = kb;
			base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // Drawing images to the screen requires
            // the use of a "sprite batch"

            // Step 1: Begin a batch
            _spriteBatch.Begin();

            // Step 2: Draw all the things!
            
            // Draws mario at full size
            _spriteBatch.Draw(
                marioTexture,
				marioPosition,
                Color.White);

            // Draws mario within a specific rectangle
            _spriteBatch.Draw(
                marioTexture,
                new Rectangle(100, 100, 200, 200),
				marioColor);

			// Draw some text darker and offset
			_spriteBatch.DrawString(
				font,
				"Mario's Position:\n" + marioPosition,
				new Vector2(12, 12),
				Color.Black);

            // Draw the same text at the desired position
			_spriteBatch.DrawString(
                font,
                "Mario's Position:\n" + marioPosition,
                new Vector2(10, 10),
                Color.White);

            // Draw the position of the mouse cursor
            _spriteBatch.DrawString(
                font,
                "Cursor Position: " + Mouse.GetState().Position,
                new Vector2(10, 100),
                Color.White);

            // Step 3: End the batch
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
