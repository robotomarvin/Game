﻿using GameEngine.Cameras;
using GameEngine.GameObjects;
using GameEngine.Objects;
using Microsoft.Xna.Framework;

namespace GameEngine.Screens
{
    class ScreenKolize : GameScreen
    {
        public ScreenKolize(ScreenManager screenManager) : base(screenManager){
        }
        public override string Name { get { return "Kolize"; } }

        public override void LoadContent()
        {
            for (int i = 0; i < 1000; i++)
            {
                Layers["SolidObjects"].Objekty.Add(new ColidableRectangle(this));
            }
            IFollowable foll = new ColidebleMovable(this);
            Layers["MovebleObjects"].Objekty.Add((SpriteObject)foll);
            MainCam = new FollowingCamera(this, foll);
            base.LoadContent();
        }

        public override void Draw(GameTime gameTime)
        {
            ScreenManager.GraphicsDevice.Clear(Color.Black);
            base.Draw(gameTime);
        }
    }
}
