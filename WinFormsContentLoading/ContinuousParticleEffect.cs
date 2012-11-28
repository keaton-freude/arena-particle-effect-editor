using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WinFormsContentLoading
{
    public class ContinuousParticleEffect : ParticleEffect
    {
        public ContinuousParticleEffect(List<Texture2D> textures, ParticleEmitter emitter) :
            base(textures, emitter)
        {
        }

        public bool Generating
        {
            get;
            set;
        }

        public override void Update(float dt)
        {
            if (Generating)
            {
                for (int particle = 0; particle < particles.Count; particle++)
                {
                    particles[particle].Update(dt);
                    if (particles[particle].Life <= 0)
                    {
                        particles.RemoveAt(particle);

                        /* Optimization, we can guarantee that for every removed particle, we are
                         * less than MaxParticles. Therefore, isntead of removing, just replace that particle's position
                         * with a new fresh one
                         */

                        //particles[particles.IndexOf(particles[particle])] = GenerateNewParticle(0, 0);

                    }
                }


                /* Generate new Particles for this frame */
                /* This is more of a "wind-up" function, shouldn't be called once
                 * we're at max capacity */
                for (int i = 0; i < Emitter.ParticlesPerUpdate; ++i)
                {
                    if (particles.Count < Emitter.MaxParticles)
                        particles.Add(base.GenerateNewParticle(0, 0));
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
