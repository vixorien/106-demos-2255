using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace MonoGame3D
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        // 3D entity
        private Model model;
        private Vector3 position;
        private Vector3 scale;
        private Vector3 pitchYawRoll;
        private Matrix worldMatrix;

        // Camera
        private float aspectRatio;
        private Vector3 camPosition;
        private Vector3 camRotation;
        private Matrix viewMatrix;
        private MouseState prevMouse;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.ApplyChanges();

            aspectRatio = (float)_graphics.PreferredBackBufferWidth /
                _graphics.PreferredBackBufferHeight;

		}

        protected override void Initialize()
        {
            // Init transform data
            position = Vector3.Zero;
            pitchYawRoll = Vector3.Zero;
            scale = Vector3.One;

            camPosition = new Vector3(0, 0, 10);
            camRotation = Vector3.Zero;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Note: When adding .obj files to the content MGCB,
            // make sure to change the "importer" to FBX
            model = Content.Load<Model>("cube");

            Texture2D texture = Content.Load<Texture2D>("crate");

            BasicEffect e = (BasicEffect)model.Meshes[0].MeshParts[0].Effect;
            e.EnableDefaultLighting();
            e.SpecularColor = Color.White.ToVector3();
            e.SpecularPower = 64;

            e.Texture = texture;
            e.TextureEnabled = true;
		}

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Get time as a float
            float t = (float)gameTime.TotalGameTime.TotalSeconds;

            // Update the entity's transformations
            //pitchYawRoll.X += 0.01f;
            //pitchYawRoll.Z += 0.01f;

            //scale = Vector3.One * (MathF.Sin(t) * 0.5f + 1);

            worldMatrix =
                Matrix.CreateScale(scale) *
                Matrix.CreateFromYawPitchRoll(pitchYawRoll.Y, pitchYawRoll.X, pitchYawRoll.Z) *
                Matrix.CreateTranslation(position);

            UpdateCamera(gameTime);

            base.Update(gameTime);
        }

        private void UpdateCamera(GameTime gt)
        {
			// Calculate rotation matrix for camera
			Matrix camRotMatrix = Matrix.CreateFromYawPitchRoll(
				camRotation.Y, camRotation.X, camRotation.Z);

			// Handle keyboard input
			KeyboardState kb = Keyboard.GetState();
            Vector3 move = Vector3.Zero;
            if (kb.IsKeyDown(Keys.W)) move.Z -= 0.1f;
			if (kb.IsKeyDown(Keys.S)) move.Z += 0.1f;
			if (kb.IsKeyDown(Keys.A)) move.X -= 0.1f;
			if (kb.IsKeyDown(Keys.D)) move.X += 0.1f;
			if (kb.IsKeyDown(Keys.X)) move.Y -= 0.1f;
			if (kb.IsKeyDown(Keys.Space)) move.Y += 0.1f;

            // Normalize if possible
            if (move != Vector3.Zero)
                move.Normalize();

            // Rotate the movement to match our rotation
            move = Vector3.TransformNormal(move, camRotMatrix);
            camPosition += move * 0.1f;

            // Mouse input for rotation
            MouseState ms = Mouse.GetState();
            if (ms.LeftButton == ButtonState.Pressed)
            {
                int xDiff = ms.X - prevMouse.X;
				int yDiff = ms.Y - prevMouse.Y;

                camRotation.X -= yDiff * 0.001f;
				camRotation.Y -= xDiff * 0.001f;
			}
            prevMouse = ms;

            // Figure out new forward vector
            Vector3 camForward = Vector3.TransformNormal(
                Vector3.Forward,
                camRotMatrix);

			// Finalize the view matrix
			viewMatrix = Matrix.CreateLookAt(
                camPosition,
                camPosition + camForward,
                Vector3.Up);

		}

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            model.Draw(
				worldMatrix,
				viewMatrix,
                Matrix.CreatePerspectiveFieldOfView(
                    MathHelper.PiOver4,
                    aspectRatio,
                    0.1f,
                    1000.0f));



			base.Draw(gameTime);
        }
    }
}
