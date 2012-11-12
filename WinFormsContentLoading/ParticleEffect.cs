using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace WinFormsContentLoading
{
    public abstract class ParticleEffect
    {
        protected Random random;
        public Vector2 EmitterLocation { get; set; }
        protected List<Particle> particles; /* Particles currently in effect */
        protected List<Texture2D> textures; /* Textures we can draw on */
        public List<Particle> MasterParticles;

        public bool Generating { get; set; } /* who knows if needed */

        public ParticleEffect(List<Texture2D> textures)
        {
            random = new Random();
            particles = new List<Particle>();
            this.textures = textures;
            MasterParticles = new List<Particle>();
        }

        public float RandomFromRange(float min, float max, Random random)
        {
            return (float)random.NextDouble() * (max - min + 1) + min;
        }

        public Int32 CurrentTextureIndex
        {
            get;
            set;
        }

        public String TexturePolling
        {
            get;
            set;
        }

        public Particle GenerateNewParticle()
        {
            return null;
        }

        public virtual void Update()
        {
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
