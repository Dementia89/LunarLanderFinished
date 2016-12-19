using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameLibrary;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace LunarLander
{
    public class Lander : DrawableGameComponent
    {
        TimeSpan elapsedTime = TimeSpan.Zero;

        private Vector2 position;
        private Vector2 UP;
        private PrimitiveBatch pb;

        private bool isVisible;

        public int fuel { get; set; }

        private int fuelUsage;

        public float angle = 0;
        public float thrustPower = 0f;
        private float thrustPowerInc = 0.05f;
        private float thrustPowerDec = 0.01f;
        private float maxThrust = 0.5f;

        public float gravity = 0.02f;
        private float maxGrav = 5.0f;

        public bool alive = true;
        public bool landed = false;

        private KeyboardState oldKeyboardState;

        public LinkedList<Line2D> landerLines;
        public LinkedList<Vector2> landerCraft;

        public Lander(Game game) : base(game)
        {
            fuelUsage = 10;

            position = new Vector2(3, 3);
            UP = new Vector2(0, -1);
            pb = new PrimitiveBatch(game.GraphicsDevice);

            isVisible = true;

            Initialize();
        }
        
        public override void Initialize()
        {
            oldKeyboardState = new KeyboardState();

            landerLines = new LinkedList<Line2D>();
            landerCraft = new LinkedList<Vector2>();

            GenerateCraft();

            fuel = 100;

            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState newKeyboardState = Keyboard.GetState();
            elapsedTime += gameTime.ElapsedGameTime;

            if (fuel > 100)
            {
                fuel = 100;
            }

            if(fuel < 0)
            {
                fuel = 0;
            }

            if (alive)
            {
                if (newKeyboardState != oldKeyboardState)
                {
                    if (Keyboard.GetState().IsKeyDown(Keys.Up))
                    {
                        if (elapsedTime > TimeSpan.FromSeconds(1))
                        {
                            fuel -= fuelUsage;
                            elapsedTime = TimeSpan.Zero;
                        }

                        if (fuel > 0)
                        {
                            thrustPower += thrustPowerInc;
                            gravity -= thrustPowerInc;
                        }

                        if (thrustPower > maxThrust)
                        {
                            
                            thrustPower = maxThrust;
                        }
                        if (landed)
                        {
                            landed = false;
                        }
                    }

                    if (!landed && fuel > 0)
                    {
                        if (Keyboard.GetState().IsKeyDown(Keys.Left))
                        {
                            angle -= MathHelper.ToRadians(3.0f);
                        }

                        if (Keyboard.GetState().IsKeyDown(Keys.Right))
                        {
                            angle += MathHelper.ToRadians(3.0f);
                        }
                    }
                }
            }

            Matrix rotMatrix = Matrix.CreateRotationZ(angle);

            Vector2 currentDirection = Vector2.Transform(UP, rotMatrix);
            currentDirection *= thrustPower;
            position += currentDirection;

            thrustPower -= thrustPowerDec;
            if (thrustPower < 0)
            {
                thrustPower = 0;
            }

            if (alive)
            {
                if (!landed)
                {
                    ApplyGravity();
                }
            }

            GenerateCraft();

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            // TODO: Add your draw code here
            if (isVisible)
            {
                pb.Begin(PrimitiveType.LineList);
                
                foreach(Vector2 v in landerCraft)
                {
                    pb.AddVertex(v, Color.Green);
                }

                pb.End();
            }

            base.Draw(gameTime);
        }

        public void CreateLines()
        {
            if(landerLines != null)
            {
                landerLines.Clear();
            }
            for(int i = 0; i < 5; i += 2)
            {
                landerLines.AddLast(new Line2D(landerCraft.ElementAt(i).X, landerCraft.ElementAt(i).Y, landerCraft.ElementAt(i + 1).X, landerCraft.ElementAt(i + 1).Y));
            }
        }

        public void GenerateCraft()
        {
            if(landerCraft != null)
            {
                landerCraft.Clear();
            }
            
            landerCraft.AddLast(RotateIt(new Vector2(position.X + 3, position.Y)) * 2);
            landerCraft.AddLast(RotateIt(new Vector2(position.X - 3, position.Y - 3)) * 2);

            landerCraft.AddLast(RotateIt(new Vector2(position.X + 3, position.Y)) * 2);
            landerCraft.AddLast(RotateIt(new Vector2(position.X - 3, position.Y + 3)) * 2);

            landerCraft.AddLast(RotateIt(new Vector2(position.X - 1, position.Y - 2)) * 2);
            landerCraft.AddLast(RotateIt(new Vector2(position.X - 1, position.Y + 2)) * 2);
        }

        private Vector2 RotateIt(Vector2 v)
        {
            float xRotated = position.X + (v.X - position.X) * (float)Math.Sin(angle) - (v.Y - position.Y) * (float)Math.Cos(angle);

            float yRotated = position.Y - (v.X - position.X) * (float)Math.Cos(angle) - (v.Y - position.Y) * (float)Math.Sin(angle);

            xRotated = xRotated + position.X;
            yRotated = yRotated + position.Y;

            return new Vector2(xRotated, yRotated);
        }

        private void ApplyGravity()
        {
            gravity += 0.005f;

            if(gravity > maxGrav)
            {
                gravity = maxGrav;
            }

            if(gravity < 0)
            {
                gravity = 0;
            }

            position += new Vector2(0, gravity);
        }
    }
}
