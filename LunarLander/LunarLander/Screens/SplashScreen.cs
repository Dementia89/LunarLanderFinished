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
    public class SplashScreen : GameScreen
    {
        SpriteBatch spriteBatch;
        SpriteFont spriteFont;

        public SplashScreen()
        {
            LoadContent();
        }

        public override void LoadContent()
        {
            spriteBatch = new SpriteBatch(StateManager.graphicsDevice);
            spriteFont = StateManager.Content.Load<SpriteFont>("font");

            StateManager.game.Window.Title = "Lunar Lander";
        }

        public override void Update(GameTime gameTime, StateManager screen, GamePadState gamePadState, MouseState mouseState, KeyboardState keyState, InputHandler input)
        {
            if (input.KeyboardState.WasKeyPressed(Keys.Escape) || input.WasPressed(0, InputHandler.ButtonType.B, Keys.B))
            {
                StateManager.game.Exit();
            }

            if (input.KeyboardState.WasKeyPressed(Keys.Space) || input.WasPressed(0, InputHandler.ButtonType.A, Keys.A))
            {
                MainMenu menu = new MainMenu();
                screen.Pop();
                screen.Push(menu);
            }
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            Vector2 center = new Vector2(StateManager.graphicsDevice.Viewport.Width / 2, StateManager.graphicsDevice.Viewport.Height / 2);

            Vector2 v = spriteFont.MeasureString("Psychosis Entertainment") / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "Psychosis Entertainment", (center - v), Color.Red);

            Vector2 x = spriteFont.MeasureString("Presents") / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "Presents", ((center + new Vector2(0, 20)) - x), Color.White);

            spriteBatch.End();
        }
    }
}
