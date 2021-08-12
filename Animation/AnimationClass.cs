//https://www.dreamincode.net/forums/topic/194878-xna-animated-sprite/
//http://charas-project.net/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PixelPerfectCollision
{
    class Animate
    {
        Texture2D spriteTexture;
        float timer = 0f;
        float interval = 200f;
        int currentFrame = 1;
        int spriteWidth = 24;
        int rowHeight = 0;//24x32
        int spriteHeight = 32;
        Rectangle sourceRect;
        Vector2 position;
        Vector2 origin;

        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
        public Vector2 Origin
        {
            get { return position; }
            set { position = value; }
        }
        public Texture2D Texture
        {
            get { return spriteTexture; }
            set { spriteTexture = value; }
        }
        public Rectangle SourceRect
        {
            get { return sourceRect; }
            set { sourceRect = value; }
        }

        public Animate(Texture2D texture, int currentFrame, int spriteWidth, int spriteHeight)
        {
            this.spriteTexture = texture;
            this.currentFrame = currentFrame;
            this.spriteWidth = spriteWidth;
            this.spriteHeight = spriteHeight;
        }

        KeyboardState currentKeys;
        KeyboardState previousKeys;

        public void HandleSpriteMovement(GameTime gameTime)
        {
            previousKeys = currentKeys;
            currentKeys = Keyboard.GetState();

            sourceRect = new Rectangle(currentFrame * spriteWidth, rowHeight, spriteWidth, spriteHeight);

            if (currentKeys.GetPressedKeys().Length == 0)
            {

                if (currentFrame > 0 && currentFrame < 4)
                {
                    currentFrame = 1;
                }
            }

            //sprint

            if (currentKeys.IsKeyDown(Keys.Space))
            {
                interval = 100;
            }
            else
            {
                interval = 200;
            }



            if (currentKeys.IsKeyDown(Keys.Right) == true)
            {
                AnimateRight(gameTime);
rowHeight = 32;
            }

            if (currentKeys.IsKeyDown(Keys.Left) == true)
            {
                AnimateLeft(gameTime);
rowHeight = 96;
            }

            if (currentKeys.IsKeyDown(Keys.Down) == true)
            {
                AnimateDown(gameTime);
rowHeight = 64;
            }

            if (currentKeys.IsKeyDown(Keys.Up) == true)
            {
                AnimateUp(gameTime);
rowHeight = 0;
            }

            origin = new Vector2(sourceRect.Width / 2, sourceRect.Height / 2);
        }

        public void AnimateRight(GameTime gameTime)
        {

            if (currentKeys != previousKeys)
            {
                currentFrame = 1;
            }

            timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;


            if (timer > interval)
            {
                currentFrame++;

                if (currentFrame > 3)
                {
                    currentFrame = 0;
                }

                timer = 0f;
            }

        }

        public void AnimateUp(GameTime gameTime)
        {
            if (currentKeys != previousKeys)
            {
                currentFrame = 1;
            }

            timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (timer > interval)
            {
                currentFrame++;

                if (currentFrame > 3)
                {
                    currentFrame = 0;
                }

                timer = 0f;

            }
        }

        public void AnimateDown(GameTime gameTime)
        {
            if (currentKeys != previousKeys)
            {
                currentFrame = 1;
            }

            timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (timer > interval)
            {
                currentFrame++;

                if (currentFrame > 3)
                {
                    currentFrame = 0;
                }

                timer = 0f;

            }

        }

        public void AnimateLeft(GameTime gameTime)
        {

            if (currentKeys != previousKeys)
            {
                currentFrame = 1;
            }

            timer += (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (timer > interval)
            {
                currentFrame++;

                if (currentFrame > 3)
                {
                    currentFrame = 0;
                }

                timer = 0f;

            }

        }
    }
}
