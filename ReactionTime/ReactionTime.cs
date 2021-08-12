
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

namespace Reaction_Time
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SoundEffect oneUp;
        SpriteFont result, gameText;
        int time, tick, x = 0;
        GamePadState gamePad1, gamePad2, gamePad3, gamePad4 = new GamePadState();
        bool on1, on2, on3, on4, gameOver = false;
        bool playing, playSound = false;
        Random rand = new Random();
        int count = 0;
        string placeHolder;
        string fail1 = "P1 didn't react";
        string fail2 = "P2 didn't react";
        string fail3 = "P3 didn't react";
        string fail4 = "P4 didn't react";
        int reaction1, reaction2, reaction3, reaction4 = 0;
        bool pressed1, pressed1y, pressed1x, pressed1a, pressed1b, pressed2, pressed2y, pressed2x, pressed2a, pressed2b,
            pressed3, pressed3y, pressed3x, pressed3a, pressed3b, pressed4, pressed4y, pressed4x, pressed4a, pressed4b = false;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            count = rand.Next(2, 5);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            oneUp = Content.Load<SoundEffect>("One Up yuh");
            result = Content.Load<SpriteFont>("resultText");
            gameText = Content.Load<SpriteFont>("gameText");
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
            IsMouseVisible = true;
            gamePad1 = GamePad.GetState(PlayerIndex.One);
            gamePad2 = GamePad.GetState(PlayerIndex.Two);
            gamePad3 = GamePad.GetState(PlayerIndex.Three);
            gamePad4 = GamePad.GetState(PlayerIndex.Four);
            
            
            #region connected
            if (gamePad1.IsConnected)
            {
                on1 = true;
            }
            else
            {
                on1 = false;
            }

            if (gamePad2.IsConnected)
            {
                on2 = true;
            }
            else
            {
                on2 = false;
            }
            if (gamePad3.IsConnected)
            {
                on3 = true;
            }
            else
            {
                on3 = false;
            }
            if (gamePad4.IsConnected)
            {
                on4 = true;
            }
            else
            {
                on4 = false;
            }
            #endregion
            if (playing)
            {
                placeHolder = count.ToString();
                x = Int32.Parse(placeHolder);
                if (tick % 60 == 0)
                {
                    time++;
                }
                if (!pressed1)
                {
                    reaction1 = -(x * 60) + tick;
                }
                if (!pressed2)
                {
                    reaction2 = -(x * 60) + tick;
                }
                if (!pressed3)
                {
                    reaction3 = -(x * 60) + tick;
                }
                if (!pressed4)
                {
                    reaction4 = -(x * 60) + tick;
                }
                if (count == time && !playSound)
                {
                    playSound = true;
                    oneUp.Play();
                }
                if (-(x*60) + tick >= 120)
                {
                    gameOver = true;
                    if (!pressed1)
                    {
                        pressed1 = false;
                    }
                    if (!pressed2)
                    {
                        pressed2 = false;
                    }
                    if (pressed3)
                    {
                        pressed3 = false;
                    }
                    if (!pressed4)
                    {
                        pressed4 = false;
                    }
                }
            }
            #region Controls


            if (gamePad1.Buttons.Start == ButtonState.Pressed && !playing)
            {
                playing = true;
                time = 0;
                tick = 0;
                pressed1 = false;
                pressed2 = false;
                pressed3 = false;
                pressed4 = false;
            }
            #endregion
            tick++;
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();
            if (playing)
            {
                #region pad1
                if (on1)
                {
                    spriteBatch.DrawString(gameText, "Y", new Vector2(140, 50), Color.Yellow);
                    spriteBatch.DrawString(gameText, "X", new Vector2(100, 90), Color.Blue);
                    spriteBatch.DrawString(gameText, "A", new Vector2(140, 120), Color.Green);
                    spriteBatch.DrawString(gameText, "B", new Vector2(180, 90), Color.Red);
                    
                    if (gamePad1.Buttons.Y == ButtonState.Pressed)
                        {
                            pressed1y = true;
                            pressed1 = true;
                        }
                        if (gamePad1.Buttons.X == ButtonState.Pressed)
                        {
                           pressed1x = true;
                           pressed1 = true;
                        }
                        if (gamePad1.Buttons.A == ButtonState.Pressed)
                        {
                            pressed1a = true;
                            pressed1 = true;
                        }
                        if (gamePad1.Buttons.B == ButtonState.Pressed)
                        {
                            pressed1b = true;
                            pressed1 = true;
                        }
                    if (pressed1)
                    {
                        if (pressed1y)
                        {
                            spriteBatch.DrawString(gameText, reaction1.ToString(), new Vector2(140 + 30, 50), Color.Yellow);
                        }
                        if (pressed1x)
                        {
                            spriteBatch.DrawString(gameText, reaction1.ToString(), new Vector2(100 - 30, 90), Color.Blue);
                        }
                        if (pressed1a)
                        {
                            spriteBatch.DrawString(gameText, reaction1.ToString(), new Vector2(140 + 30, 120), Color.Green);
                        }
                        if (pressed1b)
                        {
                            spriteBatch.DrawString(gameText, reaction1.ToString(), new Vector2(180 + 30, 90), Color.Red);
                        }
                    }
                }
                #endregion
                #region pad2
                //player 2
                    if (on2)
                    {
                        spriteBatch.DrawString(gameText, "Y", new Vector2(520, 50), Color.Yellow);
                        spriteBatch.DrawString(gameText, "X", new Vector2(480, 90), Color.Blue);
                        spriteBatch.DrawString(gameText, "A", new Vector2(520, 120), Color.Green);
                        spriteBatch.DrawString(gameText, "B", new Vector2(560, 90), Color.Red);
                        if (gamePad2.Buttons.Y == ButtonState.Pressed)
                        {
                            pressed2y = true;
                            pressed2 = true;
                        }
                        if (gamePad2.Buttons.X == ButtonState.Pressed)
                        {
                            pressed2x = true;
                            pressed2 = true;
                        }
                        if (gamePad2.Buttons.A == ButtonState.Pressed)
                        {
                            pressed2a = true;
                            pressed2 = true;
                        }
                        if (gamePad2.Buttons.B == ButtonState.Pressed)
                        {
                            pressed2b = true;
                            pressed2 = true;
                        }
                        if (pressed2)
                        {
                            if (pressed2y)
                            {
                                spriteBatch.DrawString(gameText, reaction2.ToString(), new Vector2(520 + 30, 50), Color.Yellow);
                            }
                            if (pressed2x)
                            {
                                spriteBatch.DrawString(gameText, reaction2.ToString(), new Vector2(480 - 30, 90), Color.Blue);
                            }
                            if (pressed2a)
                            {
                                spriteBatch.DrawString(gameText, reaction2.ToString(), new Vector2(520 + 30, 120), Color.Green);
                            }
                            if (pressed2b)
                            {
                                spriteBatch.DrawString(gameText, reaction2.ToString(), new Vector2(560 + 30, 90), Color.Red);
                            }
                        }
                        
                    }
                #endregion
                #region pad3
                    //player 3
                    if (on3)
                    {
                        spriteBatch.DrawString(gameText, "Y", new Vector2(140, 250), Color.Yellow);
                        spriteBatch.DrawString(gameText, "X", new Vector2(100, 290), Color.Blue);
                        spriteBatch.DrawString(gameText, "A", new Vector2(140, 320), Color.Green);
                        spriteBatch.DrawString(gameText, "B", new Vector2(180, 290), Color.Red);
                        if (gamePad3.Buttons.Y == ButtonState.Pressed)
                        {
                            pressed3y = true;
                            pressed3 = true;
                        }
                        if (gamePad3.Buttons.X == ButtonState.Pressed)
                        {
                            pressed3x = true;
                            pressed3 = true;
                        }
                        if (gamePad3.Buttons.A == ButtonState.Pressed)
                        {
                            pressed3a = true;
                            pressed3 = true;
                        }
                        if (gamePad3.Buttons.B == ButtonState.Pressed)
                        {
                            pressed3b = true;
                            pressed3 = true;
                        }
                        if (pressed3)
                        {
                            if (pressed3y)
                            {
                                spriteBatch.DrawString(gameText, reaction3.ToString(), new Vector2(140 + 30, 250), Color.Yellow);
                            }
                            if (pressed3x)
                            {
                                spriteBatch.DrawString(gameText, reaction3.ToString(), new Vector2(100 - 30, 290), Color.Blue);
                            }
                            if (pressed3a)
                            {
                                spriteBatch.DrawString(gameText, reaction3.ToString(), new Vector2(140 + 30, 320), Color.Green);
                            }
                            if (pressed3b)
                            {
                                spriteBatch.DrawString(gameText, reaction3.ToString(), new Vector2(180 + 30, 290), Color.Red);
                            }
                        }
                    }
                    #endregion
                #region pad4
                    //player 4
                    if (on4)
                    {
                        spriteBatch.DrawString(gameText, "Y", new Vector2(520, 250), Color.Yellow);
                        spriteBatch.DrawString(gameText, "X", new Vector2(480, 290), Color.Blue);
                        spriteBatch.DrawString(gameText, "A", new Vector2(520, 320), Color.Green);
                        spriteBatch.DrawString(gameText, "B", new Vector2(560, 290), Color.Red);
                        if (gamePad4.Buttons.Y == ButtonState.Pressed)
                        {
                            pressed4y = true;
                            pressed4 = true;
                        }
                        if (gamePad4.Buttons.X == ButtonState.Pressed)
                        {
                            pressed4x = true;
                            pressed4 = true;
                        }
                        if (gamePad4.Buttons.A == ButtonState.Pressed)
                        {
                            pressed4a = true;
                            pressed4 = true;
                        }
                        if (gamePad4.Buttons.B == ButtonState.Pressed)
                        {
                            pressed4b = true;
                            pressed4 = true;
                        }

                        if (pressed4)
                        {
                            if (pressed4y)
                            {
                                spriteBatch.DrawString(gameText, reaction1.ToString(), new Vector2(520 + 30, 250), Color.Yellow);
                            }
                            if (pressed4x)
                            {
                                spriteBatch.DrawString(gameText, reaction1.ToString(), new Vector2(480 - 30, 290), Color.Blue);
                            }
                            if (pressed4a)
                            {
                                spriteBatch.DrawString(gameText, reaction1.ToString(), new Vector2(520 + 30, 320), Color.Green);
                            }
                            if (pressed4b)
                            {
                                spriteBatch.DrawString(gameText, reaction1.ToString(), new Vector2(560 + 30, 290), Color.Red);
                            }
                        }
                    }
                    #endregion
                    spriteBatch.DrawString(gameText, reaction1.ToString(), new Vector2(350, 200), Color.Black);
                }

                if (!playing)
                {
                    spriteBatch.DrawString(gameText, "Player 1: Press START to play", new Vector2(150, 100), Color.Black);
                }
                if (gameOver)
                {
                    if (!pressed1)
                    {
                        spriteBatch.DrawString(result, fail1, new Vector2(150, 150), Color.Black);
                    }
                    if (!pressed2)
                    {
                        spriteBatch.DrawString(result, fail2, new Vector2(150, 170), Color.Black);
                    }
                    if (!pressed3)
                    {
                        spriteBatch.DrawString(result, fail3, new Vector2(150, 190), Color.Black);
                    }
                    if (!pressed4)
                    {
                        spriteBatch.DrawString(result, fail4, new Vector2(150, 210), Color.Black);
                    }
                }
                spriteBatch.End();

                base.Draw(gameTime);
            }
        }
    }



