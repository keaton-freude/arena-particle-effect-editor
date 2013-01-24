using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WinFormsContentLoading
{
    public partial class AddParticleDlg : Form
    {
        public AddParticleDlg()
        {
            InitializeComponent();
        }

        public Boolean ParticleCreated
        {
            get;
            set;
        }

        public AddParticleDlg(Particle copy)
        {
            InitializeComponent();

            /* Add relevant info to fields.. */
            txtName.Text = copy.Name;
            txtAlphaStart.Text = copy.StartAlpha.ToString();
            txtEndAlpha.Text = copy.EndAlpha.ToString();

            txtRot.Text = copy.Rotation.ToString();
            txtDeltaRot.Text = copy.RotationSpeed.ToString();
            txtScale.Text = copy.ScaleStart.ToString();
            txtScaleEnd.Text = copy.ScaleEnd.ToString();

            txtMinLife.Text = copy.MinLife.ToString();
            txtMaxLife.Text = copy.MaxLife.ToString();


            txtTexturePath.Text = copy.TextureName;

            System.Drawing.Color color;
            color = System.Drawing.Color.FromArgb(copy.StartColor.R, copy.StartColor.G, copy.StartColor.B);
            pctStartColor.BackColor = color;
            pctEndColor.BackColor = System.Drawing.Color.FromArgb(copy.EndColor.R, copy.EndColor.G, copy.EndColor.B);
            StartColor = copy.StartColor;
            EndColor = copy.EndColor;




            EditedParticle = true;

        }

        public bool EditedParticle
        {
            get;
            set;
        }

        public Particle Particle
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Drawing.Color chosen = colorDialog1.Color;
                StartColor = new Microsoft.Xna.Framework.Color(chosen.R, chosen.G, chosen.B);
                pctStartColor.BackColor = chosen;
                pctEndColor.BackColor = chosen;
            }
        }

        

        private void AddParticleDlg_Load(object sender, EventArgs e)
        {

        }

        

        private void txtTexturePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddTexture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {


                txtTexturePath.Text = openFileDialog1.FileName;
                string[] items = txtTexturePath.Text.Split('\\');

                txtTexturePath.Text = items[items.Length - 1];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* Cancel */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /* Submit */

            Particle = new Particle();

            /* Fill out Particle's fields */

            Particle.Name = txtName.Text;
            Particle.Location = Vector2.Zero; /* This will be set before spawning by Emitter Location */

            
            Particle.StartColor = StartColor;
            Particle.EndColor = EndColor;
            
            
            /* Alpha Start */
            Particle.StartAlpha = (float)Convert.ToDouble(txtAlphaStart.Text);
            Particle.EndAlpha = (float)Convert.ToDouble(txtEndAlpha.Text);

            /* Initial Rotation */
            Particle.Rotation = (float)Convert.ToDouble(txtRot.Text);

            /* Delta Rot */
            Particle.RotationSpeed = (float)Convert.ToDouble(txtDeltaRot.Text);

            /* Scale */
            Particle.Scale = (float)Convert.ToDouble(txtScale.Text);

            /* TTL */


            /* Check to see if a ranged TTL is being used */
            Particle.MinLife = (float)Convert.ToDouble(txtMinLife.Text);
            Particle.MaxLife = (float)Convert.ToDouble(txtMaxLife.Text);

            Particle.ScaleStart = (float)Convert.ToDouble(txtScale.Text);
            Particle.ScaleEnd = (float)Convert.ToDouble(txtScaleEnd.Text);

            /* Texture Name */
            Particle.TextureName = txtTexturePath.Text;
            ParticleCreated = true;
            this.Close();

        }

        private void btnLerpColorStart_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Drawing.Color chosen = colorDialog1.Color;
                StartColor = new Microsoft.Xna.Framework.Color(chosen.R, chosen.G, chosen.B);
                pctStartColor.BackColor = chosen;
            }
        }

        private void btnLerpColorEnd_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Drawing.Color chosen = colorDialog1.Color;
                EndColor = new Microsoft.Xna.Framework.Color(chosen.R, chosen.G, chosen.B);
                pctEndColor.BackColor = chosen;
            }
        }

        private Microsoft.Xna.Framework.Color StartColor;
        private Microsoft.Xna.Framework.Color EndColor;

       

    }
}
