using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Chris Cascioli
// 2/4/26
// Example of a basic monogame project
// with loading content and drawing images

namespace MonoGameBasicsDemo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Fields
        private Texture2D marioTexture;
        private Vector2 marioPosition;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            marioPosition = new Vector2(-150, -150);

			base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // The "asset" name when loading is the original
            // file name WITHOUT extension
            marioTexture = Content.Load<Texture2D>("mario");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Move mario's position a little each frame
            marioPosition.Y -= 5.0f;

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
                Color.White);

            // Step 3: End the batch
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
