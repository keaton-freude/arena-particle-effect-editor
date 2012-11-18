using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WinFormsContentLoading
{
    public class Particle
    {
        #region Newtonian Properties
        public Vector2 Location
        {
            get;
            set;
        }

        public Vector2 Velocity
        {
            get;
            set;
        }

        public Vector2 Acceleration
        {
            get;
            set;
        }

        public Boolean RandomVelocity
        {
            get;
            set;
        }

        public Boolean RandomAccel
        {
            get;
            set;
        }

        public Boolean ColorInterpolation
        {
            get;
            set;
        }

        public Vector2 MinimumVelocity
        {
            get;
            set;
        }

        public Vector2 MaximumVelocity
        {
            get;
            set;
        }

        public Vector2 MinimumAcceleration
        {
            get;
            set;
        }

        public Vector2 MaximumAcceleration
        {
            get;
            set;
        }
        #endregion

        #region Render Properties
        public Color Color
        {
            get;
            set;
        }

        public Color StartColor
        {
            get;
            set;
        }

        public Color EndColor
        {
            get;
            set;
        }

        public float Alpha
        {
            get;
            set;
        }

        public float AlphaChange
        {
            get;
            set;
        }

        public float Rotation
        {
            get;
            set;
        }

        public float RotationSpeed
        {
            get;
            set;
        }

        public float Scale
        {
            get;
            set;
        }

        public Texture2D Texture
        {
            get;
            set;
        }

        public Vector2 Origin
        {
            get;
            set;
        }
        /* Used to identify itself */
        public String Name
        {
            get;
            set;
        }

        public String TextureName
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Name;
        }
        #endregion

        #region Life-time Specifics
        public Int32 TTL
        {
            get;
            set;
        }

        public Int32 _BaseTTL;
        //public Int32 MaxTTL
        //{
        //    get;
        //    set;
        //}

        public Boolean RangeTTL
        {
            get;
            set;
        }

        public Vector2 OffsetMinimum
        {
            get;
            set;
        }

        public Vector2 OffsetMaximum
        {
            get;
            set;
        }

        public Vector2 Offset
        {
            get;
            set;
        }

        public Int32 MinTTL
        {
            get;
            set;
        }

        public Int32 MaxTTL
        {
            get;
            set;
        }

        public Vector2 SpeedModifier
        {
            get;
            set;
        }

        #endregion

        #region Init
        public Particle()
        {
            /* All pieces of Particle should be set by their property */
        }
        #endregion

        #region Draw/Update
        public void Draw(SpriteBatch spriteBatch)
        {
            float alpha_percent = ((float)TTL / (float)_BaseTTL);
            spriteBatch.Draw(Texture, Location + Offset, null, Color * alpha_percent, Rotation, Origin, Scale, SpriteEffects.None, 1.0f);
        }

        public void Update(float dt)
        {
            TTL--;
            Velocity += Acceleration * dt;
            Location += Velocity * dt;
            Rotation += RotationSpeed * dt;
            Alpha += AlphaChange * dt;

            Color = Color.Lerp(StartColor, EndColor, 1.0f - ((float)TTL / (float)_BaseTTL));
        }
        #endregion
    }
}
