using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WinFormsContentLoading
{
    public class OneShotParticleEffect: ParticleEffect
    {
        /* This class provides a friendy way of creating one shot particles */

        public String EffectType
        {
            get;
            set;
        }

        /* If EffectType == Circle, then we use this */
        public float CircleRadius
        {
            get;
            set;
        }

        public int NumberOfParticles
        {
            get;
            set;
        }

        public Int32 Iterations
        {
            get;
            set;
        }



        public OneShotParticleEffect(List<Texture2D> textures) :
            base(textures)
        {

        }

        public void Fire()
        {
            /* Create the particle Effect according to the rules given */
            /* Hard coding to a circle for testing. TODO: Make generic */
            int n = NumberOfParticles;

            for (int x = 0; x < n; ++x)
            {
                particles.Add(GenerateNewParticle(x, n, CircleRadius, EmitterLocation.X, EmitterLocation.Y));
            }

        }

        public Particle GenerateNewParticle(int x, int n, float r, float off_x, float off_y)
        {
            Texture2D texture = null;
            int ParticleID = -1; 
            /* if we're doing random texture polling */
            if (TexturePolling == "Random")
                ParticleID = random.Next(textures.Count);
            else if (TexturePolling == "RoundRobin")
                ParticleID = CurrentTextureIndex++ % textures.Count;


            Particle BaseParticle = MasterParticles[ParticleID];

            float xp = (float)Math.Cos(Math.PI * 2 / n * x) * r;
            float yp = (float)Math.Sin(Math.PI * 2 / n * x) * r;
            Vector2 position = new Vector2(xp + off_x, yp + off_y);

            /* We will build the rest of this particle off of our base particle */

            Particle ParticleToReturn = new Particle();
            ParticleToReturn.Texture = textures[ParticleID];
            ParticleToReturn.Location = position;
            
            /* If we're doing static velocity copy it over, otherwise we need to computer */
            Vector2 velocity = Vector2.Zero;

            if (BaseParticle.RandomVelocity)
            {
                /* Compute */
                float vel_x = RandomFromRange(BaseParticle.MinimumVelocity.X, BaseParticle.MaximumVelocity.X, random);
                float vel_y = RandomFromRange(BaseParticle.MinimumVelocity.Y, BaseParticle.MaximumVelocity.Y, random);

                velocity = new Vector2(vel_x, vel_y);
            }
            else
                velocity = BaseParticle.Velocity;

            /* Same thing for acceleration */
            Vector2 acceleration = Vector2.Zero;

            if (BaseParticle.RandomAccel)
            {
                float accel_x = RandomFromRange(BaseParticle.MinimumAcceleration.X, BaseParticle.MaximumAcceleration.X, random);
                float accel_y = RandomFromRange(BaseParticle.MinimumAcceleration.Y, BaseParticle.MaximumAcceleration.Y, random);

                acceleration = new Vector2(accel_x, accel_y);
            }
            else
                acceleration = BaseParticle.Acceleration;



            float angle = BaseParticle.Rotation;
            float angularVelocity = BaseParticle.RotationSpeed;

            string Name = BaseParticle.Name;

            Color startColor = BaseParticle.StartColor;
            Color endColor = BaseParticle.EndColor;


            float alpha = BaseParticle.Alpha;
            float alphaChange = BaseParticle.AlphaChange;
            int ttl = BaseParticle.TTL;

            float scale = BaseParticle.Scale;

            ParticleToReturn.Acceleration = acceleration;
            ParticleToReturn.Alpha = alpha;
            ParticleToReturn.AlphaChange = alphaChange;
            ParticleToReturn.StartColor = startColor;
            ParticleToReturn.EndColor = endColor;
            ParticleToReturn.Name = Name;
            ParticleToReturn.Origin = Vector2.Zero;
            ParticleToReturn.Rotation = angle;
            ParticleToReturn.RotationSpeed = angularVelocity;
            ParticleToReturn.Scale = scale;
            ParticleToReturn.TTL = ttl;
            ParticleToReturn.Velocity = velocity;

            return ParticleToReturn;


            //return null;
        }

        public override void Update()
        {
            for (int particle = 0; particle < particles.Count; particle++)
            {
                particles[particle].Update();
                if (particles[particle].TTL <= 0)
                {
                    particles.RemoveAt(particle);
                    particle--;
                }
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            for (int index = 0; index < particles.Count; index++)
            {
                particles[index].Draw(spriteBatch);
            }
        }
    }
}
