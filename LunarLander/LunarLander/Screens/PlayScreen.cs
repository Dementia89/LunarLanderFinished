using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Storage;

using GameLibrary;
using System.IO;
using System.Threading.Tasks;
using System.Text;

namespace LunarLander.Screens
{
    public class PlayScreen : GameScreen
    {
        SpriteBatch spriteBatch;
        SpriteFont spriteFont;
        
        Lander lander;
        Terrain terrain;

        PrimitiveBatch pb;

        List<SoundEffect> soundEffects;

        TimeSpan elapsedTime = TimeSpan.Zero;

        bool padsInt = false;
        bool terInt = false;
        bool gameOver = false;

        Font fuelWord;
        

        public PlayScreen()
        {
            
            terrain = new Terrain();

            soundEffects = new List<SoundEffect>();

            pb = new PrimitiveBatch(StateManager.graphicsDevice);
            lander = new Lander(StateManager.game);
            //Components.Add(lander);
            terrain.GenerateTerrain();
            terrain.GeneratePads();
            elapsedTime = TimeSpan.Zero;
            fuelWord = new Font("FUEL 000", 5);
            LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            pb.Begin(PrimitiveType.LineList);

            foreach(Vector2 x in terrain.terrainList)
            {
                pb.AddVertex(x, Color.White);
            }

            foreach(Vector2 x in terrain.padsList)
            {
                pb.AddVertex(x, Color.Green);
            }

            foreach(Vector2 x in fuelWord.sentence)
            {
                pb.AddVertex(x + new Vector2(10,10), Color.White);
            }

            if(terInt || padsInt)
            {
                if (terInt)
                {
                    StateManager.graphicsDevice.Clear(Color.DarkRed);
                }

                if (padsInt)
                {
                    StateManager.graphicsDevice.Clear(Color.DarkGreen);
                }
            }

            lander.Draw(gameTime);
            
            pb.End();

            spriteBatch.Begin();

            AllTheWords();

            spriteBatch.End();
        }

        public override void LoadContent()
        {
            spriteBatch = new SpriteBatch(StateManager.graphicsDevice);
            spriteFont = StateManager.Content.Load<SpriteFont>("font");

            

            soundEffects.Add(StateManager.Content.Load<SoundEffect>("thrusters"));
            soundEffects.Add(StateManager.Content.Load<SoundEffect>("success"));
            soundEffects.Add(StateManager.Content.Load<SoundEffect>("explode"));
            

            StateManager.game.Window.Title = "Lunar Lander";
        }

        public override void Update(GameTime gameTime, StateManager screen, GamePadState gamePadState, MouseState mouseState, KeyboardState keyState, InputHandler input)
        {
            if (input.KeyboardState.WasKeyPressed(Keys.Escape) || input.WasPressed(0, InputHandler.ButtonType.B, Keys.B))
            {
                screen.Pop();
            }

            if (input.KeyboardState.WasKeyPressed(Keys.P) || input.WasPressed(0, InputHandler.ButtonType.Start, Keys.Tab))
            {
                PauseScreen pause = new PauseScreen();
                screen.Push(pause);
            }
            
            elapsedTime += gameTime.ElapsedGameTime;
            
            if(Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                if(elapsedTime > TimeSpan.FromSeconds(2))
                {
                    if(lander.fuel > 0)
                    {
                        soundEffects[0].Play();
                    }
                    
                    elapsedTime = TimeSpan.Zero;
                }
            }
            lander.Update(gameTime);
            fuelWord.Update("Fuel " + lander.fuel);
            lander.CreateLines();

            CollisionCheck();
        }

        private void AllTheWords()
        {
            Vector2 botRight = new Vector2(StateManager.graphicsDevice.Viewport.Width, StateManager.graphicsDevice.Viewport.Height);

            Vector2 v = spriteFont.MeasureString("P = Pause") / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "P = Pause", ((botRight + new Vector2(-50, -20)) - v), Color.Red);

            Vector2 z = spriteFont.MeasureString("Angle:   ") / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "Angle: " + (lander.angle * (180 / 3.145)), (new Vector2(27, 40) - z), Color.White);

            Vector2 y = spriteFont.MeasureString("Thrust: " + lander.thrustPower * 100) / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "Thrust: " + lander.thrustPower * 100, new Vector2(0, 50), Color.White);

            Vector2 zz = spriteFont.MeasureString("Lunar Lander Thing") / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "Lunar Lander Thing", new Vector2(250, 0), Color.Red);

            Vector2 zzz = spriteFont.MeasureString("Left/Right = Roll") / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "Left/Right = Roll", new Vector2(500, 0), Color.Red);

            Vector2 zzzz = spriteFont.MeasureString("Up = Thrust") / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "Up = Thrust", new Vector2(500, 15), Color.Red);

            Vector2 zzzzz = spriteFont.MeasureString("P = Pause") / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "P = Paus", new Vector2(500, 30), Color.Red);

            Vector2 zzzzzzz = spriteFont.MeasureString("Esc = Back") / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "Esc = Back", new Vector2(500, 45), Color.Red);

            if (gameOver == true)
            {
                Vector2 xx = spriteFont.MeasureString("Game Over, Esc to go back") / new Vector2(2, 2);

                spriteBatch.DrawString(spriteFont, "Game Over, Esc to go back", new Vector2(300, 200), Color.Red);
            }

            Vector2 yy = spriteFont.MeasureString("Velocity X: " + lander.gravity * 100) / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "Velocity X: " + lander.gravity * 100, new Vector2(0, 70), Color.White);
        }

        private void CollisionCheck()
        {
            padsInt = false;

            foreach (Line2D l in lander.landerLines)
            {
                foreach (Line2D m in terrain.terrainLines)
                {
                    if (Line2D.Intersects(l, m))
                    {
                        terInt = true;
                        lander.alive = false;
                        gameOver = true;
                        soundEffects[2].Play();
                    }
                }

                foreach (Line2D m in terrain.padsLines)
                {
                    if (Line2D.Intersects(l, m))
                    {
                        if(lander.gravity < .2)
                        {
                            if(((lander.angle * (180 / 3.145) > -5)) && ((lander.angle * (180 / 3.145) < 5)))
                            {
                                padsInt = true;
                                if (lander.landed == false)
                                {
                                    lander.thrustPower = 0;
                                }
                                lander.landed = true;
                                lander.gravity = 0;
                                soundEffects[1].Play();
                            }
                        }
                        else
                        {
                            terInt = true;
                            lander.alive = false;
                            gameOver = true;
                            soundEffects[2].Play();
                        }
                    }
                }
            }
        }
    }
}
