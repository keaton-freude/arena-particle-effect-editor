using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WinFormsContentLoading
{
    public class ContinuousParticleEffect: ParticleEffect
    {
        public int ParticlesPerUpdate
        {
            get;
            set;
        }

        public ContinuousParticleEffect(List<Texture2D> textures) :
            base(textures)
        {
        }

        public bool Generating
        {
            get;
            set;
        }

        public int MaxParticles
        {
            get;
            set;
        }

        public Particle GenerateNewParticle(int x, int y)
        {
            Texture2D texture = null;
            int ParticleID = -1;
            /* if we're doing random texture polling */
            if (TexturePolling == "Random")
                ParticleID = random.Next(textures.Count);
            else if (TexturePolling == "RoundRobin")
                ParticleID = CurrentTextureIndex++ % textures.Count;


            Particle BaseParticle = MasterParticles[ParticleID];

            //float xp = (float)Math.Cos(Math.PI * 2 / n * x) * r;
            //float yp = (float)Math.Sin(Math.PI * 2 / n * x) * r;
            Vector2 position = new Vector2(x, y);

            /* We will build the rest of this particle off of our base particle */

            Particle ParticleToReturn = new Particle();
            ParticleToReturn.Texture = textures[ParticleID];

            
            position.X += RandomFromRange(BaseParticle.OffsetMinimum.X, BaseParticle.OffsetMaximum.X, random);
            position.Y += RandomFromRange(BaseParticle.OffsetMinimum.Y, BaseParticle.OffsetMaximum.Y, random);
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
            int ttl = 0;
            if (BaseParticle.RangeTTL)
            {
                ttl = random.Next(BaseParticle.MinTTL, BaseParticle.MaxTTL);
            }
            else
            {
                ttl = BaseParticle.TTL;
            }

            ParticleToReturn.Offset = new Vector2(RandomFromRange(BaseParticle.OffsetMinimum.X, BaseParticle.OffsetMaximum.X, random), RandomFromRange(BaseParticle.OffsetMinimum.Y, BaseParticle.OffsetMaximum.Y, random));


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
            ParticleToReturn._BaseTTL = ttl;
            ParticleToReturn.Velocity = velocity;

            return ParticleToReturn;
        }

        public override void Update(float dt, Vector2 EmitterLocation)
        {
            if (Generating)
            {
                for (int particle = 0; particle < particles.Count; particle++)
                {
                    particles[particle].Update(dt);
                    if (particles[particle].TTL <= 0)
                    {
                        //particles.RemoveAt(particle);

                        /* Optimization, we can guarantee that for every removed particle, we are
                         * less than MaxParticles. Therefore, isntead of removing, just replace that particle's position
                         * with a new fresh one
                         */

                        particles[particles.IndexOf(particles[particle])] = GenerateNewParticle((int)EmitterLocation.X, (int)EmitterLocation.Y);

                    }
                }


                /* Generate new Particles for this frame */
                /* This is more of a "wind-up" function, shouldn't be called once
                 * we're at max capacity */
                for (int i = 0; i < ParticlesPerUpdate; ++i)
                {
                    if (particles.Count < MaxParticles)
                        particles.Add(GenerateNewParticle((int)EmitterLocation.X, (int)EmitterLocation.Y));
                }


            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            if (Generating)
            {
                if (BlendingState == "Alpha")
                    spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
                else if (BlendingState == "Additive")
                    spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.Additive);
                for (int index = 0; index < particles.Count; index++)
                {
                    particles[index].Draw(spriteBatch);
                }
                spriteBatch.End();
            }
        }
    }
}
