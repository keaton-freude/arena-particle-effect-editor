using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Xml;

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

                int particle_budget = Emitter.MaxParticles - particles.Count;
                int particles_this_update = 0;
                if (particle_budget - Emitter.ParticlesPerUpdate < 0)
                {
                    particles_this_update = Emitter.ParticlesPerUpdate - (Emitter.ParticlesPerUpdate - particle_budget);
                }
                else
                    particles_this_update = Emitter.ParticlesPerUpdate;


                for (int i = 0; i < Emitter.ParticlesPerUpdate; ++i)
                {
                    /* How many particles CAN we add? */

                    

                    if (particles.Count < Emitter.MaxParticles)
                        particles.Add(base.GenerateNewParticle(0, 0, i+1, particles_this_update));
                    else
                        break;
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

        public override void SaveToFile(XmlWriter writer)
        {
            writer.WriteStartElement("ParticleEffect");
            writer.WriteStartAttribute("Type");
            writer.WriteValue("Continuous");
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("TexturePolling");
            writer.WriteValue(TexturePolling);
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("BlendState");
            writer.WriteValue(BlendingState);
            writer.WriteEndAttribute();

            Emitter.WriteToFile(writer);

            foreach (Particle p in MasterParticles)
            {
                p.SaveToFile(writer);
            }

            writer.WriteEndElement();
        }
    }
}
