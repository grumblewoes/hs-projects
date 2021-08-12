
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace TextBox
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Rectangle textBox;
        Texture2D debugColor;
        SpriteFont font;
        string text;
        String parsedText;
        String typedText;
        double typedTextLength;
        int delayInMilliseconds;
        bool isDoneDrawing;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }


        protected override void Initialize()
        {
            textBox = new Rectangle(20, 255, 760, 210);
            base.Initialize();
        }


        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            debugColor = Content.Load<Texture2D>("Pixel");
            font = Content.Load<SpriteFont>("font");
            text = "Crowley, you can't do 90 miles per hour in central London! You'll get us killed! Well -- inconveniently discorporated...";
            parsedText = parseText(text);
            delayInMilliseconds = 50;
            isDoneDrawing = false;
            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (!isDoneDrawing)
            {
                if (delayInMilliseconds == 0)
                {
                    typedText = parsedText;
                    isDoneDrawing = true;
                }
                else if (typedTextLength < parsedText.Length)
                {
                    typedTextLength = typedTextLength + gameTime.ElapsedGameTime.TotalMilliseconds / delayInMilliseconds;
//typedtextlength = "as time goes on, the length increases with elapsedGameTime, and the delay is 50 ms, so you can increase the length of the total string every 50 ms"
-> "once you finished typing out the whole thing, you're done and can make a button to click continue or something"

                    if (typedTextLength >= parsedText.Length)
                    {
                        typedTextLength = parsedText.Length;
                        isDoneDrawing = true;
                    }

                    typedText = parsedText.Substring(0, (int)typedTextLength);
                }
            }

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            

            spriteBatch.Draw(debugColor, textBox, Color.White);
            spriteBatch.DrawString(font, typedText, new Vector2(textBox.X + 20, textBox.Y + 20), Color.Black);
            spriteBatch.End();

            base.Draw(gameTime);

        }
        private String parseText(String text)
        {
            String line = String.Empty;
            String returnString = String.Empty;
            String[] wordArray = text.Split(' ');

//checking each time that a word is typed out: if word and whatever stuff is behind it is longer than the textbox width, only type the stuff behind it and a linebreak, and put the word on the next line
            foreach (String word in wordArray)
            {
                if (font.MeasureString(line + word).Length() > textBox.Width)
                {
                    returnString = returnString + line + '\n';
                    line = String.Empty;
                }

                line = line + word + ' ';
            }

            return returnString + line;
        }
    }
}



