using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Xml;

namespace WinFormsContentLoading
{
    public class ParticleEmitter
    {
        public ParticleEmitter()
        {
            Direction = -Vector2.UnitY;
        }

        /* Direction of the Emitter */
        private Vector2 _direction;
        public Vector2 Direction
        {
            get
            {
                return Vector2.Transform(_direction, Matrix.CreateRotationZ(InitialRot));
            }
            set
            {
                _direction = value;
            }
        }

        private Vector2 _location;

        public Vector2 Location
        {
            get
            {
                return _location;
            }
            set
            {
                LastLocation = _location;
                _location = value;
            }
        }

        public Vector2 LastLocation
        {
            get;
            set;
        }

        public float InitialRot
        {
            get;
            set;
        }

        public float MaxAngleRot
        {
            get;
            set;
        }

        public float MinAngleRot
        {
            get;
            set;
        }

        public Vector2 MaxParticleSpeed
        {
            get;
            set;
        }

        public Vector2 MinParticleSpeed
        {
            get;
            set;
        }

        public Int32 MaxParticles
        {
            get;
            set;
        }

        public Vector2 MinVelocity
        {
            get;
            set;
        }

        public Vector2 MaxVelocity
        {
            get;
            set;
        }

        public Int32 ParticlesPerUpdate
        {
            get;
            set;
        }

        public Vector2 OffsetMin
        {
            get;
            set;
        }

        public Vector2 OffsetMax
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

        public void WriteToFile(XmlWriter writer)
        {
            writer.WriteStartElement("ParticleEmitter");


            writer.WriteStartElement("MaxParticles");
            writer.WriteValue(MaxParticles.ToString());
            writer.WriteEndElement();

            /* Min Velocity */
            writer.WriteStartElement("MinVelocity");
            writer.WriteStartAttribute("X");
            writer.WriteValue(MinVelocity.X.ToString());
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("Y");
            writer.WriteValue(MinVelocity.Y.ToString());
            writer.WriteEndAttribute();
            writer.WriteEndElement();

            /* Max Velocity */
            writer.WriteStartElement("MaxVelocity");
            writer.WriteStartAttribute("X");
            writer.WriteValue(MaxVelocity.X.ToString());
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("Y");
            writer.WriteValue(MaxVelocity.Y.ToString());
            writer.WriteEndAttribute();
            writer.WriteEndElement();

            /* Particles per Update */
            writer.WriteStartElement("ParticlePerUpdate");
            writer.WriteValue(ParticlesPerUpdate.ToString());
            writer.WriteEndElement();

            /* OffsetMin */
            writer.WriteStartElement("OffsetMin");
            writer.WriteStartAttribute("X");
            writer.WriteValue(OffsetMin.X.ToString());
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("Y");
            writer.WriteValue(OffsetMin.Y.ToString());
            writer.WriteEndAttribute();
            writer.WriteEndElement();
            

            /* OffsetMax */
            writer.WriteStartElement("OffsetMax");
            writer.WriteStartAttribute("X");
            writer.WriteValue(OffsetMax.X.ToString());
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("Y");
            writer.WriteValue(OffsetMax.Y.ToString());
            writer.WriteEndAttribute();
            writer.WriteEndElement();

            /* MinAccel */
            writer.WriteStartElement("MinAccel");
            writer.WriteStartAttribute("X");
            writer.WriteValue(MinimumAcceleration.X.ToString());
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("Y");
            writer.WriteValue(MinimumAcceleration.Y.ToString());
            writer.WriteEndAttribute();
            writer.WriteEndElement();

            /* MaxAccel */
            writer.WriteStartElement("MaxAccel");
            writer.WriteStartAttribute("X");
            writer.WriteValue(MaximumAcceleration.X.ToString());
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("Y");
            writer.WriteValue(MaximumAcceleration.Y.ToString());
            writer.WriteEndAttribute();
            writer.WriteEndElement();

            writer.WriteEndElement();
        }
    }
}
