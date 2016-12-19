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
    public abstract class GameScreen
    {
        // Force all GameScreen derrived components to call LoadContent() automatically 
        // Why not make all screens drawable game components?  This is a good question. 
        // Component managers are typicall game components and the elements managed by a 
        // component should only be managed by the manager (ie. not updated() or drawn()
        // automatically
        public GameScreen()
        {
        }

        // Force all derived classes to implemnet these methods

        public abstract void LoadContent();

        public abstract void Update(GameTime gameTime, StateManager screen, GamePadState gamePadState, MouseState mouseState, KeyboardState keyState, InputHandler input);

        public abstract void Draw(GameTime gameTime);
    }
}