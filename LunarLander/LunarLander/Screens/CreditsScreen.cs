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
    class CreditsScreen : GameScreen
    {
        SpriteBatch spriteBatch;
        SpriteFont spriteFont;

        public CreditsScreen()
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
                screen.Pop();
            }
        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            Vector2 center = new Vector2(StateManager.graphicsDevice.Viewport.Width / 2, StateManager.graphicsDevice.Viewport.Height / 2);

            Vector2 v = spriteFont.MeasureString("All the hate poured into the making of this game:") / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "All the hate poured into the making of this game:", (center - v), Color.Red);

            Vector2 x = spriteFont.MeasureString("Benjamin Holton") / new Vector2(2, 2);

            spriteBatch.DrawString(spriteFont, "Benjamin Holton", ((center + new Vector2(0, 20)) - x), Color.White);

            spriteBatch.End();
        }
    }
}
