
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

namespace PixelPerfectCollision
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        Vector2 position;
        SpriteBatch spriteBatch;
        Texture2D sprite1, sprite2;
        KeyboardState keys;
        Color playerColor = Color.White;
        float moveSpeed = 100f;
        Rectangle player, enemy;

        private bool PixelCollision(Texture2D sprite1, Texture2D sprite2, Rectangle player, Rectangle enemy)
        {
            Color[] colorData1 = new Color[sprite1.Width * sprite1.Height];
            Color[] colorData2 = new Color[sprite2.Width * sprite2.Height];
            sprite1.GetData<Color>(colorData1);
            sprite2.GetData<Color>(colorData2);

            int top, bottom, left, right;

            top = Math.Max(player.Top, enemy.Top);
            bottom = Math.Min(player.Bottom, enemy.Bottom);
            left = Math.Max(player.Left, enemy.Left);
            right = Math.Min(player.Right, enemy.Right);

            for (int y = top; y < bottom; y++)
            {
                for (int x = left; x < right; x++)
                {
                    Color A = colorData1[(y - player.Top) * (player.Width) + (x - player.Left)];
                    Color B = colorData2[(y - enemy.Top) * (enemy.Width) + (x - enemy.Left)];

                    if (A.A != 0 && B.A != 0)
                        return true;
                }
            }
            return false;
        }


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            IsMouseVisible = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            sprite1 = Content.Load<Texture2D>("down2");
            sprite2 = Content.Load<Texture2D>("dragon");
            enemy = new Rectangle(100, 100, sprite2.Width, sprite2.Height);
        }

        protected override void UnloadContent()
        {

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            keys = Keyboard.GetState();

            if (keys.IsKeyDown(Keys.Right))
            {
                position.X += moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (keys.IsKeyDown(Keys.Left))
            {
                position.X -= moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (keys.IsKeyDown(Keys.Up))
            {
                position.Y -= moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (keys.IsKeyDown(Keys.Down))
            {
                position.Y += moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }

            player = new Rectangle((int)position.X, (int)position.Y, sprite1.Width, sprite1.Height);

            if (player.Intersects(enemy))
            {
                if (PixelCollision(sprite1, sprite2, player, enemy))
                {
                    playerColor = Color.Red;
                }
                else
                {
                    playerColor = Color.White;
                }
            }
            else
            {
                playerColor = Color.White;
            }


            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            spriteBatch.Draw(sprite2, new Vector2(100, 100), Color.White);
            spriteBatch.Draw(sprite1, position, playerColor);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}




