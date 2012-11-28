using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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

        public Vector2 Location
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
    }
}
