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

namespace LunarLander.Screens
{
    class MainMenu : GameScreen
    {
        SpriteBatch spriteBatch;
        SpriteFont spriteFont;

        public MainMenu()
        {
            LoadContent();
        }

        public override void LoadContent()
        {
            spriteBatch = new SpriteBatch(StateManager.graphicsDevice);
            spriteFont = StateManager.Content.Load<SpriteFont>("font");
        }

        public override void Update(GameTime gameTime, StateManager screen, GamePadState gamePadState, MouseState mouseState, KeyboardState keyState, InputHandler input)
        {
            if (input.KeyboardState.WasKeyPressed(Keys.Escape) || input.WasPressed(0, InputHandler.ButtonType.B, Keys.B))
            {
                StateManager.game.Exit();
            }

            if (input.KeyboardState.WasKeyPressed(Keys.P) || input.WasPressed(0, InputHandler.ButtonType.A, Keys.A))
            {
                PlayScreen play = new PlayScreen();
                screen.Push(play);
            }

            if (input.KeyboardState.WasKeyPressed(Keys.C) || input.WasPressed(0, InputHandler.ButtonType.X, Keys.X))
            {
                CreditsScreen credits = new CreditsScreen();
                screen.Push(credits);
            }
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            Vector2 center = new Vector2(StateManager.graphicsDevice.Viewport.Width / 2, StateManager.graphicsDevice.Viewport.Height / 2);

            Vector2 v = spriteFont.MeasureString("Lunar Landering Thing") / new Vector2(2, 2);

            Vector2 x = spriteFont.MeasureString("C = Credits, P = Play, Esc = Exit") / new Vector2(2, 2);
            
            spriteBatch.DrawString(spriteFont, "Lunar Landering Thing", (center - v), Color.Red);

            spriteBatch.DrawString(spriteFont, "C = Credits, P = Play, Esc = Exit", ((center + new Vector2(0, 20)) - x), Color.White);

            spriteBatch.End();
        }
    }
}
