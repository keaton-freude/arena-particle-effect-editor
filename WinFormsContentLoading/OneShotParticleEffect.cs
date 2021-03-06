﻿using System;
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

        //public int NumberOfParticles
        //{
        //    get;
        //    set;
        //}

        public Int32 Iterations
        {
            get;
            set;
        }



        public OneShotParticleEffect(List<Texture2D> textures, ParticleEmitter emitter) :
            base(textures, emitter)
        {

        }

        public void Fire()
        {
            /* Create the particle Effect according to the rules given */
            /* Hard coding to a circle for testing. TODO: Make generic */
            int n = Emitter.MaxParticles;

            for (int x = 0; x < n; ++x)
            {
                float xp = (float)Math.Cos(Math.PI * 2 / n * x) * CircleRadius;
                float yp = (float)Math.Sin(Math.PI * 2 / n * x) * CircleRadius;
                particles.Add(GenerateNewParticle(xp, yp, 0, 1));
            }

        }

        public override void Update(float dt)
        {
            for (int particle = 0; particle < particles.Count; particle++)
            {
                particles[particle].Update(dt);
                if (particles[particle].Life <= 0)
                {
                    //particles[particles.IndexOf(particles[particle])] = GenerateNewParticle(1, 1, 1, EmitterLocation.X, EmitterLocation.Y);
                    particles.RemoveAt(particle);
                }
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
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

        public override void SaveToFile(System.Xml.XmlWriter writer)
        {
            writer.WriteStartElement("ParticleEffect");
            writer.WriteStartAttribute("Type");
            writer.WriteValue("OneShot");
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("TexturePolling");
            writer.WriteValue(TexturePolling);
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("BlendState");
            writer.WriteValue(BlendingState);
            writer.WriteEndAttribute();
            writer.WriteStartAttribute("Radius");
            writer.WriteValue(CircleRadius.ToString());
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
