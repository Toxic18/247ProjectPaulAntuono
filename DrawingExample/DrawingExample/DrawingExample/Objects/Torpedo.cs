﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using LineDraw;

namespace DrawingExample
{
    public class Torpedo : BaseGameObject
    {
        public float ThrustValue = 100;
        public float RotationRate = 45;
        public override void InitalizeObject()
        {
            //HasMaxiumVelocity = true;
            //MaxiumVelocity = 100;
            hasScreenWrap = false;
            sprite = new Sprite("Newspaceshot");

            sprite.scale = 0.05f;

            sprite.origin.X = (sprite.texture.Width / 2);
            sprite.origin.Y = (sprite.texture.Height / 2);

            Collison = new Rectangle(0, 0, (int)(sprite.texture.Width * sprite.scale), (int)(sprite.texture.Height * sprite.scale));

            //Random r = new Random();
            //r.NextDouble
        }


        public override void Update(GameTime gameTime)
        {
            //GameApp.instance.graphics.PreferredBackBufferWidth;
            // GameApp.instance.graphics.PreferredBackBufferHeight;

        }

        public virtual void Thrust()
        {
            Vector2 newThrust = LinePrimatives.AngleToV2(RotationInDegrees, ThrustValue);
            Velocity += newThrust;
        }
        public virtual void AddRotate(float value, GameTime gameTime)
        {
            float dt = (float)(gameTime.ElapsedGameTime.TotalMilliseconds / 1000f);

            Rotation += (value * RotationRate * dt * (MathHelper.Pi / 180));
        }

    }
}
