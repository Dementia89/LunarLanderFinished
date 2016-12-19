using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using GameLibrary;

namespace LunarLander
{
    class Terrain
    {
        public LinkedList<Vector2> terrainList;
        public LinkedList<Vector2> padsList;

        public LinkedList<Line2D> terrainLines;
        public LinkedList<Line2D> padsLines;

        public Terrain()
        {
            //Content.RootDirectory = "Content";

            terrainList = new LinkedList<Vector2>();
            terrainLines = new LinkedList<Line2D>();

            padsLines = new LinkedList<Line2D>();
            padsList = new LinkedList<Vector2>();
            
            //Content.RootDirectory = "Content";
        }

        public void GenerateTerrain()
        {
            // Create a new SpriteBatch, which can be used to draw textures.

            // TODO: use this.Content to load your game content here

            StreamReader reader = File.OpenText(@".\Content\terrain.txt.txt");
            string line = null;

            while ((line = reader.ReadLine()) != null)
            {
                line = line.Trim();

                if (!line.StartsWith("#"))
                {
                    string[] s = line.Split(',');

                    Vector2 p1 = new Vector2(int.Parse(s[0]), int.Parse(s[1]));
                    terrainList.AddLast(p1);

                    Vector2 p2 = new Vector2(int.Parse(s[2]), int.Parse(s[3]));
                    terrainList.AddLast(p2);

                    terrainLines.AddLast(new Line2D(p1.X, p1.Y, p2.X, p2.Y));
                }
            }

            reader.Close();
        }

        public void GeneratePads()
        {
            StreamReader reader = File.OpenText(@".\Content\pads.txt.txt");
            string line = null;

            while ((line = reader.ReadLine()) != null)
            {
                line = line.Trim();

                if (!line.StartsWith("#"))
                {
                    string[] s = line.Split(',');

                    Vector2 p1 = new Vector2(int.Parse(s[0]), int.Parse(s[1]));
                    padsList.AddLast(p1);

                    Vector2 p2 = new Vector2(int.Parse(s[2]), int.Parse(s[3]));
                    padsList.AddLast(p2);

                    padsLines.AddLast(new Line2D(p1.X, p1.Y, p2.X, p2.Y));
                }
            }

            reader.Close();
        }
    }
}
