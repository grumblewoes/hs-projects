
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Rocket_Collision
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Rectangle asteroidRec, rocketRec, rocketRec1, rocketRec2;
        Texture2D asteroidPic, rocketPic;
        Color recColor = Color.White;
        KeyboardState keyboard;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            asteroidRec = new Rectangle(100, 100, 100, 100);
            rocketRec = new Rectangle(600, 100, 200, 100);
            rocketRec1 = new Rectangle(600, 130, 200, 50);
            rocketRec2 = new Rectangle(715, 100, 55, 100);
            asteroidPic = Content.Load<Texture2D>("Asteroid");
            rocketPic = Content.Load<Texture2D>("Rocket");

            base.Initialize();
        } //creates recs and gives initial values

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            asteroidPic = Content.Load<Texture2D>("Asteroid");
            rocketPic = Content.Load<Texture2D>("Rocket");
        } //loads content for pics


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            keyboard = Keyboard.GetState();
           #region asteroid
            if (keyboard.IsKeyDown(Keys.W))
                asteroidRec.Y--;
            if (keyboard.IsKeyDown(Keys.A))
                asteroidRec.X--; 
            if (keyboard.IsKeyDown(Keys.S))
                asteroidRec.Y++;
            if (keyboard.IsKeyDown(Keys.D))
                asteroidRec.X++;
           #endregion
           #region rocket
            if (keyboard.IsKeyDown(Keys.Up))
            {
                rocketRec.Y--;
                rocketRec1.Y--;
                rocketRec2.Y--;
        }
            if (keyboard.IsKeyDown(Keys.Left))
            {
                rocketRec.X--;
                rocketRec1.X--;
                rocketRec2.X--;
        }
            if (keyboard.IsKeyDown(Keys.Down))
            {
                rocketRec.Y++;
                rocketRec1.Y++;
                rocketRec2.Y++;
        }
            if (keyboard.IsKeyDown(Keys.Right))
            {
                rocketRec.X++;
                rocketRec1.X++;
                rocketRec2.X++;
            }
           #endregion
           #region collision

            if (asteroidRec.Intersects(rocketRec1) || asteroidRec.Intersects(rocketRec2))
                recColor = Color.Red;
            else
                recColor = Color.White;

            #endregion
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(asteroidPic, asteroidRec, recColor);
            spriteBatch.Draw(rocketPic, rocketRec, recColor);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}



