﻿using System;
using GameEngine.GameObjects;
using GameEngine.HelpObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GameEngine.Objects
{
    class Bounci : MovableObject
    {
        public Bounci(GameScreen game)
            : base(game)
        {
            colisionBox = new ColisionBox(this,ColisionBox.BoxType.Circle);
            float scale = 0.5f;
            Scale = new Vector2(scale, scale);
            Position = new Vector2(GameHelper.Instance.RandomNext(-400, 400), GameHelper.Instance.RandomNext(-400, 400));
            smer = new Vector2(GameHelper.Instance.RandomNext(-400, 400), GameHelper.Instance.RandomNext(-400, 400));
            smer.Normalize();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            if (colideX)
            {
                smer = new Vector2(-smer.X,smer.Y);
            }
            else if (colideY)
            {
                smer = new Vector2(smer.X, -smer.Y);
            }
        }

        public override void LoadContent(ContentManager content)
        {
            if (Texture == null)
            {
                Texture = content.Load<Texture2D>("Sprites/hvezda");
            }
        }
    }
}