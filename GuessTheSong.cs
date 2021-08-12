
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

namespace Guess_the_Song
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        //audio plays - done
        //questions for 30s - done
        //alternate answers - done
        //play button - done
        //play button stops and starts - done
        //play button changes w state - done
        //score printed - done
        //game over - done
        //restart - done
        //incorrect answers - X
        Song song1;
        Song song2;
        Song song3;
        Song song4;
        Song song5;

        SpriteFont gameText;
        SpriteFont gameOver;
        Texture2D button;
        Texture2D pixel;

        Rectangle answerA;
        Rectangle answerB;
        Rectangle answerC;
        Rectangle answerD;
        Rectangle answerE;

        Rectangle buttonRect;
        List<string> A_Answers;
        List<string> B_Answers;
        List<string> C_Answers;
        List<string> D_Answers;
        List<string> E_Answers;

        String asgore = "Asgore's Theme";
        String gerudo = "Gerudo Valley";
        String noMercy = "No Mercy";
        String sbdtiutk = "Somebody That I Used to Know";
        String ssb = "Super Smash Bros. Theme";
        Point cursorPoint;

        int tick = 0;
        int question = 1;
        int score = 0;
        int time = 30;

        bool playing = false;
        bool instructions = true;
        bool colorButton = false;

        KeyboardState keys;
        MouseState mouse, oldMouse;
        

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
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            A_Answers = new List<string>();
            B_Answers = new List<string>();
            C_Answers = new List<string>();
            D_Answers = new List<string>();
            E_Answers = new List<string>();

            song1 = Content.Load<Song>("Asgore");
            song2 = Content.Load<Song>("Gerudo Valley");
            song3 = Content.Load<Song>("No Mercy");
            song4 = Content.Load<Song>("Somebody That I Used to Know");
            song5 = Content.Load<Song>("Super Smash Bros");

            gameText = Content.Load<SpriteFont>("GameText");
            gameOver = Content.Load<SpriteFont>("Game Over");
            button = Content.Load<Texture2D>("YoutubePlay");
            buttonRect = new Rectangle(120, 150, 150, 150);

            answerA = new Rectangle(450, 100, 200, 30);
            answerB = new Rectangle(450, 150, 200, 30);
            answerC = new Rectangle(450, 200, 200, 30);
            answerD = new Rectangle(450, 250, 200, 30);
            answerE = new Rectangle(450, 300, 200, 30);
            pixel = Content.Load<Texture2D>("Pixel");
            //1= a, 2= c, 3=b, 4=e, 5=d
            A_Answers.Add(asgore);
            A_Answers.Add("Song of Storms");
            A_Answers.Add("Overwatch Victory Theme");
            A_Answers.Add("Through the Valley");
            A_Answers.Add("Practice Stage");
            B_Answers.Add("Megalovania");
            B_Answers.Add("Song of Time");
            B_Answers.Add(noMercy);
            B_Answers.Add("Keep Your Eyes on the Prize");
            B_Answers.Add("Pokemon Intro");
            C_Answers.Add("Bonetrousle");
            C_Answers.Add(gerudo);
            C_Answers.Add("Hanamura");
            C_Answers.Add("Safe and Sound");
            C_Answers.Add("Gourmet Race");
            D_Answers.Add("Heartache");
            D_Answers.Add("Dragon Roost Island");
            D_Answers.Add("Dorado");
            D_Answers.Add("Diablo Rojo");
            D_Answers.Add(ssb);
            E_Answers.Add("Mettaton NEO");
            E_Answers.Add("Another Medium");
            E_Answers.Add("Junkertown");
            E_Answers.Add(sbdtiutk);
            E_Answers.Add("Tetris Theme A");
            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
 
        }


        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();
            cursorPoint = new Point(mouse.X, mouse.Y);
            keys = Keyboard.GetState();
            mouse = Mouse.GetState();
            
                if (playing)
                {
                    #region play button
                    if (buttonRect.Contains(cursorPoint))
                    {
                        if ((mouse.LeftButton == ButtonState.Pressed && oldMouse.LeftButton == ButtonState.Released))
                        {
                            #region song1
                            if (question == 1)
                            {
                                if (MediaPlayer.State == MediaState.Stopped)
                                {
                                    MediaPlayer.Play(song1);
                                    colorButton = true;
                                }
                                else if (MediaPlayer.State == MediaState.Playing)
                                {
                                    MediaPlayer.Pause();
                                    colorButton = false;

                                }
                                else if (MediaPlayer.State == MediaState.Paused)
                                {
                                    MediaPlayer.Resume();
                                    colorButton = true;
                                }
                            }
                            #endregion
                            #region song2
                            if (question == 2)
                            {
                                if (MediaPlayer.State == MediaState.Stopped)
                                {
                                    MediaPlayer.Play(song2);
                                    colorButton = true;
                                }
                                else if (MediaPlayer.State == MediaState.Playing)
                                {
                                    MediaPlayer.Pause();
                                    colorButton = false;
                                }
                                else if (MediaPlayer.State == MediaState.Paused)
                                {
                                    MediaPlayer.Resume();
                                    colorButton = true;
                                }
                            }
                            #endregion
                            #region song3
                            if (question == 3)
                            {
                                if (MediaPlayer.State == MediaState.Stopped)
                                {
                                    MediaPlayer.Play(song3);
                                    colorButton = true;
                                }
                                else if (MediaPlayer.State == MediaState.Playing)
                                {
                                    MediaPlayer.Pause();
                                    colorButton = false;
                                }
                                else if (MediaPlayer.State == MediaState.Paused)
                                {
                                    MediaPlayer.Resume();
                                    colorButton = true;
                                }
                            }
                            #endregion
                            #region song4
                            if (question == 4)
                            {
                                if (MediaPlayer.State == MediaState.Stopped)
                                {
                                    MediaPlayer.Play(song4);
                                    colorButton = true;
                                }
                                else if (MediaPlayer.State == MediaState.Playing)
                                {
                                    MediaPlayer.Pause();
                                    colorButton = false;
                                }
                                else if (MediaPlayer.State == MediaState.Paused)
                                {
                                    MediaPlayer.Resume();
                                    colorButton = true;
                                }
                            }
                            #endregion
                            #region song5
                            if (question == 5)
                            {
                                if (MediaPlayer.State == MediaState.Stopped)
                                {
                                    MediaPlayer.Play(song5);
                                    colorButton = true;
                                }
                                else if (MediaPlayer.State == MediaState.Playing)
                                {
                                    MediaPlayer.Pause();
                                    colorButton = false;
                                }
                                else if (MediaPlayer.State == MediaState.Paused)
                                {
                                    MediaPlayer.Resume();
                                    colorButton = true;
                                }
                            }
                            #endregion
                        }
                    }
                    #endregion
                    if (time > 0)
                    {
                            if (question == 1)
                            {
                                if ((answerA.Contains(cursorPoint) && (mouse.LeftButton == ButtonState.Pressed && oldMouse.LeftButton == ButtonState.Released)) || keys.IsKeyDown(Keys.A))
                                {
                                    score++;
                                    question++;
                                    time = 30;
                                    MediaPlayer.Stop();
                                    colorButton = false;
                                }
                            }
                            if (question == 2)
                            {
                                if ((answerC.Contains(cursorPoint) && (mouse.LeftButton == ButtonState.Pressed && oldMouse.LeftButton == ButtonState.Released)) || keys.IsKeyDown(Keys.C))
                                {
                                    score++;
                                    question++;
                                    time = 30;
                                    MediaPlayer.Stop();
                                    colorButton = false;
                                }
                            }
                            if (question == 3)
                            {
                                if ((answerB.Contains(cursorPoint) && (mouse.LeftButton == ButtonState.Pressed && oldMouse.LeftButton == ButtonState.Released)) || keys.IsKeyDown(Keys.B))
                                {
                                    score++;
                                    question++;
                                    time = 30;
                                    MediaPlayer.Stop();
                                    colorButton = false;
                                }
                            }
                            if (question == 4 && !buttonRect.Contains(cursorPoint))
                            {
                                if ((answerE.Contains(cursorPoint) && (mouse.LeftButton == ButtonState.Pressed && oldMouse.LeftButton == ButtonState.Released)) || keys.IsKeyDown(Keys.E))
                                {
                                    score++;
                                    question++;
                                    time = 30;
                                    MediaPlayer.Stop();
                                    colorButton = false;
                                }
                            }
                            if (question == 5 && !buttonRect.Contains(cursorPoint))
                            {
                                if ((answerD.Contains(cursorPoint) && (mouse.LeftButton == ButtonState.Pressed && oldMouse.LeftButton == ButtonState.Released)) || keys.IsKeyDown(Keys.D))
                                {
                                    score++;
                                    question++;
                                    time = 30;
                                    MediaPlayer.Stop();
                                    colorButton = false;
                                }
                            }
                        }

                    }
                    else if (time == 0)
                    {
                        question++;
                        time = 30;
                    }
                    
                if (question == 6)
                {
                    playing = false;
                }
            
                if (!playing)
                {
                    if (keys.IsKeyDown(Keys.Space))
                    {
                        instructions = true;
                        question = 1;
                        score = 0;
                    }
                    if (keys.IsKeyDown(Keys.Enter))
                    {
                        playing = true;
                        instructions = false;
                    }
                }
                if (tick % 60 == 0)
                {
                    time--;
                }

            oldMouse = mouse;
            tick++;
            base.Update(gameTime);
}

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            spriteBatch.Begin();
            #region playing
            if (playing)
            {
                if (!colorButton)
                {
                    spriteBatch.Draw(button, buttonRect, Color.White);
                }
                else if (colorButton)
                {
                    spriteBatch.Draw(button, buttonRect, Color.Gray);
                }
                spriteBatch.DrawString(gameText, "Guess the song!", new Vector2(550, 50), Color.Black);
                spriteBatch.DrawString(gameText, "TIME: " + time.ToString(), new Vector2(50, 100), Color.Black);
                spriteBatch.DrawString(gameText, "SCORE: " + score.ToString() + "/5", new Vector2(50, 50), Color.Black);
                spriteBatch.Draw(pixel, answerA, Color.AliceBlue);
                spriteBatch.Draw(pixel, answerB, Color.AliceBlue);
                spriteBatch.Draw(pixel, answerC, Color.AliceBlue);
                spriteBatch.Draw(pixel, answerD, Color.AliceBlue);
                spriteBatch.Draw(pixel, answerE, Color.AliceBlue);

                if (question >= 1)
                {
                    spriteBatch.DrawString(gameText, "A: " + A_Answers[question - 1], new Vector2(450, 100), Color.Black);
                    spriteBatch.DrawString(gameText, "B: " + B_Answers[question - 1], new Vector2(450, 150), Color.Black);
                    spriteBatch.DrawString(gameText, "C: " + C_Answers[question - 1], new Vector2(450, 200), Color.Black);
                    spriteBatch.DrawString(gameText, "D: " + D_Answers[question - 1], new Vector2(450, 250), Color.Black);
                    spriteBatch.DrawString(gameText, "E: " + E_Answers[question - 1], new Vector2(450, 300), Color.Black);
                }
            }
            #endregion
            if (!playing && !instructions)
            {
                spriteBatch.DrawString(gameOver, "Game Over", new Vector2(250, 60), Color.Black);
                spriteBatch.DrawString(gameOver, "SCORE:" + score.ToString(), new Vector2(285, 120), Color.Black);
                spriteBatch.DrawString(gameText, "Press SPACE to play again", new Vector2(275, 200), Color.Black);
            }
            if (instructions)
            {
                spriteBatch.DrawString(gameOver, "Instructions", new Vector2(210, 60), Color.Black);
                spriteBatch.DrawString(gameText, "Use mouse or keys A, B, C, D, or E to choose answers.", new Vector2(170, 180), Color.Black);
                spriteBatch.DrawString(gameText, "ENTER to continue", new Vector2(315, 300), Color.Black);
            }
            //question++

            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}



