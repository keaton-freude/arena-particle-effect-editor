using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Xml;

namespace WinFormsContentLoading
{
    public class ParticleSystem
    {
        public List<ParticleEffect> effects;
        public string name;

        public ParticleSystem()
        {
            effects = new List<ParticleEffect>();
        }

        public ParticleSystem(String name)
        {
            this.name = name;
            effects = new List<ParticleEffect>();
        }

        public void Update(float dt)
        {
            foreach (ParticleEffect effect in effects)
            {
                effect.Update(dt);
            }
            if (effects.Count != 0)
            {
                MainForm.maxParticleCount.Text = "Max Particles: " + effects[0].Emitter.MaxParticles.ToString();
                MainForm.particleCountLabel.Text = "Active Particles: " + effects[0].particles.Count.ToString();
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (ParticleEffect effect in effects)
            {
                effect.Draw(spriteBatch);
            }
        }

        public void SaveToFile(XmlWriter writer)
        {
            writer.WriteStartDocument();

            writer.WriteStartElement("ParticleSystem");
            writer.WriteStartAttribute("Name");
            writer.WriteValue(name);
            writer.WriteEndAttribute();

            foreach (ParticleEffect effect in effects)
            {
                effect.SaveToFile(writer);
            }

            writer.WriteEndElement();

            /* Finish the document out */
            writer.WriteEndDocument();
        }
    }
}
