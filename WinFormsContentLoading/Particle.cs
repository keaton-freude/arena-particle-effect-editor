using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Xml;

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

        public float StartAlpha
        {
            get;
            set;
        }

        public float EndAlpha
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

        public float ScaleStart
        {
            get;
            set;
        }

        public float ScaleEnd
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

        public float MinLife
        {
            get;
            set;
        }

        public float MaxLife
        {
            get;
            set;
        }

        public float Life
        {
            get;
            set;
        }

        public float StartingLife
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
            float alpha = MathHelper.Lerp(StartAlpha, EndAlpha, 1.0f - (Life / StartingLife));
            spriteBatch.Draw(Texture, Location, null, Color * alpha, Rotation, Origin, Scale, SpriteEffects.None, 1.0f);
        }

        public void Update(float dt)
        {
            Life -= dt;
            Velocity += Acceleration * dt;
            Location += Velocity * dt;
            Rotation += RotationSpeed * dt;
       

            Color = Color.Lerp(StartColor, EndColor, 1.0f - (Life / StartingLife));
            Scale = MathHelper.Lerp(ScaleStart, ScaleEnd, 1.0f - (Life / StartingLife));
        }
        #endregion

        #region Saving
        public void SaveToFile(XmlWriter writer)
        {
            writer.WriteStartElement("Particle");
            writer.WriteStartAttribute("Name");
            writer.WriteValue(Name);
            writer.WriteEndAttribute();
            
            /* Color*/
            writer.WriteStartElement("StartColor");

            writer.WriteStartAttribute("R");
            writer.WriteValue(StartColor.R.ToString());
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("G");
            writer.WriteValue(StartColor.G.ToString());
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("B");
            writer.WriteValue(StartColor.B.ToString());
            writer.WriteEndAttribute();

            writer.WriteEndElement();

            writer.WriteStartElement("EndColor");

            writer.WriteStartAttribute("R");
            writer.WriteValue(EndColor.R.ToString());
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("G");
            writer.WriteValue(EndColor.G.ToString());
            writer.WriteEndAttribute();

            writer.WriteStartAttribute("B");
            writer.WriteValue(EndColor.B.ToString());
            writer.WriteEndAttribute();

            writer.WriteEndElement();

            /* Start Alpha */

            writer.WriteStartElement("StartAlpha");
            writer.WriteValue(StartAlpha.ToString());
            writer.WriteEndElement();

            /* End ALpha */

            writer.WriteStartElement("EndAlpha");
            writer.WriteValue(EndAlpha.ToString());
            writer.WriteEndElement();

            /* Rotation */

            writer.WriteStartElement("Rotation");
            writer.WriteValue(Rotation.ToString());
            writer.WriteEndElement();

            /* RotationSpeed */

            writer.WriteStartElement("RotationSpeed");
            writer.WriteValue(RotationSpeed.ToString());
            writer.WriteEndElement();

            /* Scale Start */

            writer.WriteStartElement("ScaleStart");
            writer.WriteValue(ScaleStart.ToString());
            writer.WriteEndElement();

            /* Scale End */
            writer.WriteStartElement("ScaleEnd");
            writer.WriteValue(ScaleEnd.ToString());
            writer.WriteEndElement();

            /* Origin */
            writer.WriteStartElement("Origin");
            writer.WriteStartAttribute("X");
            writer.WriteValue(Origin.X.ToString());
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("Y");
            writer.WriteValue(Origin.Y.ToString());
            writer.WriteEndAttribute();
            writer.WriteEndElement();

            /* Texture Name */
            writer.WriteStartElement("TextureName");
            writer.WriteValue(TextureName);
            writer.WriteEndElement();

            /* Life */
            writer.WriteStartElement("Life");
            writer.WriteStartAttribute("Min");
            writer.WriteValue(MinLife.ToString());
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("Max");
            writer.WriteValue(MaxLife.ToString());
            writer.WriteEndAttribute();
            writer.WriteEndElement();

            writer.WriteEndElement();

        }
        #endregion
    }
}
