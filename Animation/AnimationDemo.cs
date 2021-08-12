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

namespace AnimationSpriteSheetDemo
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D sheet;
        AnimatedSprite sprite;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

       
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            sheet = Content.Load<Texture2D>("res_viewer");
            sprite = new AnimatedSprite(sheet, 1, 24, 32); 

            sprite.Position = new Vector2(400, 300);

        }


        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            sprite.HandleSpriteMovement(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
  
            GraphicsDevice.Clear(Color.LightBlue);

            spriteBatch.Begin();

            //spriteBatch.Draw(sprite.Texture, sprite.Position, sprite.SourceRect, Color.White, 0f, 
                //sprite.Origin, 1.0f, SpriteEffects.None, 0);
            //spriteBatch.Draw(sprite.Texture,sprite.Position,sprite.SourceRect,Color.White,0f,sprite.Origin,1.0f,SpriteEffects.None,0);
            spriteBatch.Draw(sprite.Texture, sprite.Position, sprite.SourceRect, Color.White, 0f, 
                sprite.Origin, 1.2f, SpriteEffects.None, 0);

            spriteBatch.End(); 

            base.Draw(gameTime);

        }
    }
}
