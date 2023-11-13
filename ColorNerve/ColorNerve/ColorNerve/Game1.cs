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
/* 2 player game
 * random values for intensities [11/30/18]
 * decrease intensity (button combo to decrease intensity) [11/30/18]
 * 0, 255 --> game over [11/29/18]
 * player1 loses = black screen [11/30/18]
 * player2 loses = white screen [12/3/18]
 *  PUT DATE IN WHEN FINISHED WITH SECTION
 * */
namespace ColorNerve
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {

        GraphicsDeviceManager graphics;
        Random rand = new Random();
        SpriteBatch spriteBatch;
        SpriteFont winningMsg;
        SpriteFont directions;
        byte redIntensity;
        byte greenIntensity;
        byte blueIntensity;
        KeyboardState keys = new KeyboardState(); //alows keyboard to take effect
        GamePadState pad1 = new GamePadState();
        GamePadState pad2 = new GamePadState();
        bool gameOver = false;
        bool turn = true;
        bool instructions = true;
   
        //player 1 = true, player 2 = false
        //byte is a type like bool or int or double

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            redIntensity = (byte)rand.Next(1, 254);
            greenIntensity = (byte)rand.Next(1, 254);
            blueIntensity = (byte)rand.Next(1, 254);
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            winningMsg = Content.Load<SpriteFont>("WinningFont");
            directions = Content.Load<SpriteFont>("Instructions");
            //angle brackets mean any type of var
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            keys = Keyboard.GetState();            
            pad1 = GamePad.GetState(PlayerIndex.One);
            pad2 = GamePad.GetState(PlayerIndex.Two);
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            //typecasting -- making program consider one type of data as another type
            #region bools
            //booleans
            /*
            if (redIntensity >= 255)
            {
                redCountingUp = false;
            }
            else if (redIntensity == 0)
            {
                redCountingUp = true;
            }
            if (greenIntensity >= 255)
            {
                greenCountingUp = false;
            }
            else if (greenIntensity == 0)
            {
                greenCountingUp = true;
            } if (blueIntensity >= 255)
            {
                blueCountingUp = false;
            }
            else if (blueIntensity == 0)
            {
                blueCountingUp = true;
            }*/
            #endregion
            //addition/subtraction

            #region keys
            //make sure update is last time
            if (!gameOver) //exclamation point means NOT previous bool
            {
                #region changingColor
                if (turn)
                {
                    if ((keys.IsKeyDown(Keys.R) && (keys.IsKeyDown(Keys.Space)) || (pad1.Buttons.B == ButtonState.Pressed && pad1.Buttons.RightShoulder == ButtonState.Pressed)))
                    {
                        redIntensity -= 2;
                        
                    }
                    else if (keys.IsKeyDown(Keys.R) || pad1.Buttons.B == ButtonState.Pressed)
                    {
                        redIntensity++;
                       
                    }

                    if ((keys.IsKeyDown(Keys.G) && (keys.IsKeyDown(Keys.Space)) || (pad1.Buttons.A == ButtonState.Pressed && pad1.Buttons.RightShoulder == ButtonState.Pressed)))
                    {
                        greenIntensity -= 2;
                        
                    }
                    else if (keys.IsKeyDown(Keys.G) || pad1.Buttons.A == ButtonState.Pressed)
                    {
                        greenIntensity++;
                        
                    }

                    if ((keys.IsKeyDown(Keys.B) && (keys.IsKeyDown(Keys.Space)) || (pad1.Buttons.X == ButtonState.Pressed && pad1.Buttons.RightShoulder == ButtonState.Pressed)))
                    {
                        blueIntensity -= 2;
                       
                    }
                    else if (keys.IsKeyDown(Keys.B) || pad1.Buttons.X == ButtonState.Pressed)
                    {
                        blueIntensity++;
                        
                    }

                    if ((keys.IsKeyDown(Keys.Y) && (keys.IsKeyDown(Keys.Space)) || (pad1.Buttons.Y == ButtonState.Pressed && pad1.Buttons.RightShoulder == ButtonState.Pressed)))
                    {
                        redIntensity-=2;
                        greenIntensity-=2;
                       
                    }
                    else if (keys.IsKeyDown(Keys.Y) || pad1.Buttons.Y == ButtonState.Pressed)
                    {
                        redIntensity++;
                        greenIntensity++;
                        
                    }
                    
                    if (keys.IsKeyDown(Keys.Enter) || pad1.Buttons.RightShoulder == ButtonState.Pressed)
                    {
                        
                            turn = true;
                           
                    }
                }
                 else if (!turn)
                {
                    if ((keys.IsKeyDown(Keys.R) && (keys.IsKeyDown(Keys.Space)) || (pad1.Buttons.B == ButtonState.Pressed && pad1.Buttons.RightShoulder == ButtonState.Pressed)))
                    {
                        redIntensity -= 2;
                        
                    }
                    else if (keys.IsKeyDown(Keys.R) || pad1.Buttons.B == ButtonState.Pressed)
                    {
                        redIntensity++;
                        
                    }

                    if ((keys.IsKeyDown(Keys.G) && (keys.IsKeyDown(Keys.Space)) || (pad1.Buttons.A == ButtonState.Pressed && pad1.Buttons.RightShoulder == ButtonState.Pressed)))
                    {
                        greenIntensity -= 2;
                       
                    }
                    else if (keys.IsKeyDown(Keys.G) || pad1.Buttons.A == ButtonState.Pressed)
                    {
                        greenIntensity++;
                        
                    }

                    if ((keys.IsKeyDown(Keys.B) && (keys.IsKeyDown(Keys.Space)) || (pad1.Buttons.X == ButtonState.Pressed && pad1.Buttons.RightShoulder == ButtonState.Pressed)))
                    {
                        blueIntensity -= 2;
                       
                    }
                    else if (keys.IsKeyDown(Keys.B) || pad1.Buttons.X == ButtonState.Pressed)
                    {
                        blueIntensity++;
                        
                    }

                    if ((keys.IsKeyDown(Keys.Y) && (keys.IsKeyDown(Keys.Space)) || (pad1.Buttons.Y == ButtonState.Pressed && pad1.Buttons.RightShoulder == ButtonState.Pressed)))
                    {
                        redIntensity -= 2;
                        greenIntensity -= 2;
                        
                    }
                    else if (keys.IsKeyDown(Keys.Y) || pad1.Buttons.Y == ButtonState.Pressed)
                    {
                        redIntensity++;
                        greenIntensity++;
                        
                    }

                    if (keys.IsKeyDown(Keys.Enter) || pad2.Buttons.RightShoulder == ButtonState.Pressed)
                    {
                       
                            turn = false;
                            
                    }
                }
              
                #endregion

                if (redIntensity == 255 || redIntensity <= 0 || greenIntensity >= 255 || greenIntensity <= 0 || blueIntensity >= 255 || blueIntensity <= 0)
                {
                    gameOver = true;
                }
                if (keys.IsKeyDown(Keys.LeftShift) || pad1.Buttons.LeftShoulder == ButtonState.Pressed)
                {
                    instructions = false;
                }
            }
            if (gameOver)
            {
                if (keys.IsKeyDown(Keys.Space) || pad1.Buttons.Start == ButtonState.Pressed)
                {
                    gameOver = false;
                    redIntensity = (byte)rand.Next(1, 254);
                    greenIntensity = (byte)rand.Next(1, 254);
                    blueIntensity = (byte)rand.Next(1, 254);
                    turn = true;
                }
            }
            #endregion
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            Color backgroundColor = new Color(redIntensity, greenIntensity, blueIntensity);
            spriteBatch.Begin();
            if (instructions)
            {
                spriteBatch.DrawString(directions, "Hold RGBY/ABXY to change color. Hold space while changing color to \nsubtract. Press enter/right shoulder when you want to end your turn. \nPress SPACE to restart the game when a player loses.", new Vector2(20, 50), Color.Black);
                spriteBatch.DrawString(directions, "Press left shift to continue as PLAYER 1", new Vector2(180, 300), Color.Black);
            }
            if (!gameOver)
            {
                GraphicsDevice.Clear(backgroundColor);

                if (turn)
                {
                    spriteBatch.DrawString(directions, "Player 1", new Vector2(1, 1), Color.White);
                }
                else if (!turn)
                {
                    spriteBatch.DrawString(directions, "Player 2", new Vector2(1, 1), Color.White);
                }
            }
            if (gameOver && turn)
            { 
                GraphicsDevice.Clear(Color.Black);
                spriteBatch.DrawString(winningMsg, "Player 2 Wins", new Vector2(150, 180), Color.SkyBlue);
            }
            if (gameOver && !turn)
            {
                GraphicsDevice.Clear(Color.White);
                spriteBatch.DrawString(winningMsg, "Player 1 Wins", new Vector2(150, 180), Color.IndianRed);
            }
            //default window == 800x400
            //device method NEEDS color
            // TODO: Add your drawing code here
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
