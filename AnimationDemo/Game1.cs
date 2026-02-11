using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

// Chris Cascioli
// 2/11/26
// Demo of sprite sheet animation

namespace AnimationDemo
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // Sprite sheet data
        private Texture2D marioTexture;
        private int framesInSpriteSheet;
        private int widthOfFrame;
        private int heightOfFrame;

        // Animation variables
        private int currentFrame;
        private float fps;
        private float secondsPerFrame;
        private float timeSinceAnimationFrameIncrement;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // Set up animation vars
            currentFrame = 1;
            fps = 3.333f;
            secondsPerFrame = 1.0f / fps;
            timeSinceAnimationFrameIncrement = 0;


			base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Handle assets
            marioTexture = Content.Load<Texture2D>("MarioSpriteSheet");
            framesInSpriteSheet = 4; // Matches this exact sprite sheet
            heightOfFrame = marioTexture.Height;
            widthOfFrame = marioTexture.Width / framesInSpriteSheet;
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Add to our time "counter"
            timeSinceAnimationFrameIncrement += (float)gameTime.ElapsedGameTime.TotalSeconds;
			if (timeSinceAnimationFrameIncrement >= secondsPerFrame)
            {
				// Move to the next frame
				currentFrame++;
                timeSinceAnimationFrameIncrement -= secondsPerFrame;
			}

            // Loop back to frame 1
            if (currentFrame >= framesInSpriteSheet)
                currentFrame = 1;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            _spriteBatch.Draw(
                marioTexture,
                new Rectangle(100, 100, widthOfFrame * 3, heightOfFrame * 3),
                new Rectangle(currentFrame * widthOfFrame, 0, widthOfFrame, heightOfFrame),
                Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
