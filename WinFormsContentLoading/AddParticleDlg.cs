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
            }
        }

        private void rdoColorLerp_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoColorLerp.Checked)
            {
                lblStaticColor.Visible = false;
                btnStaticColor.Visible = false;

                lblStartColor.Visible = true;
                lblEndColor.Visible = true;
                btnLerpColorEnd.Visible = true;
                btnLerpColorStart.Visible = true;
                //EndColor = new Microsoft.Xna.Framework.Color(-1, -1, -1);
            }
            else
            {
                lblStaticColor.Visible = true;
                btnStaticColor.Visible = true;

                lblStartColor.Visible = false;
                lblEndColor.Visible = false;
                btnLerpColorEnd.Visible = false;
                btnLerpColorStart.Visible = false;
            }
        }

        private void rdoStaticColor_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoColorLerp.Checked)
            {
                lblStaticColor.Visible = false;
                btnStaticColor.Visible = false;

                lblStartColor.Visible = true;
                lblEndColor.Visible = true;
                btnLerpColorEnd.Visible = true;
                btnLerpColorStart.Visible = true;
                //EndColor = new Microsoft.Xna.Framework.Color(-1, -1, -1);
            }
            else
            {
                lblStaticColor.Visible = true;
                btnStaticColor.Visible = true;

                lblStartColor.Visible = false;
                lblEndColor.Visible = false;
                btnLerpColorEnd.Visible = false;
                btnLerpColorStart.Visible = false;
            }
        }

        private void AddParticleDlg_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStaticVel.Checked)
            {
                lblStartVelocity.Visible = true;
                txtStartVelX.Visible = true;
                txtStartVelX.Visible = true;

                lblMaxVelocity.Visible = false;
                txtMaxVelX.Visible = false;
                txtMaxVelY.Visible = false;
            }
            else
            {
                lblStartVelocity.Visible = !true;
                txtStartVelX.Visible = !true;
                txtStartVelX.Visible = !true;

                lblMaxVelocity.Visible = !false;
                txtMaxVelX.Visible = !false;
                txtMaxVelY.Visible = !false;
                txtStartVelX.Visible = true;
                txtStartVelY.Visible = true;
                lblStartVelocity.Visible = true;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStaticVel.Checked)
            {
                lblStartVelocity.Visible = true;
                txtStartVelX.Visible = true;
                txtStartVelX.Visible = true;

                lblMaxVelocity.Visible = false;
                txtMaxVelX.Visible = false;
                txtMaxVelY.Visible = false;
            }
            else
            {
                lblStartVelocity.Visible = !true;
                txtStartVelX.Visible = !true;
                txtStartVelX.Visible = !true;

                lblMaxVelocity.Visible = !false;
                txtMaxVelX.Visible = !false;
                txtMaxVelY.Visible = !false;
                txtStartVelX.Visible = true;
                txtStartVelY.Visible = true;
                lblStartVelocity.Visible = true;
            }
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
            
            /* Static Velocity */
            if (rdoStaticVel.Checked)
            {
                Particle.Velocity = new Vector2((float)Convert.ToDouble(txtStartVelX.Text), (float)Convert.ToDouble(txtStartVelY.Text));
                Particle.RandomVelocity = false;
            }
            else
            {
                /* Otherwise particle will have its Velocity chosen between a range at creation time */
                /* So we'll set the appropriate flag and set Min/Max values */
                Particle.RandomVelocity = true;
                Particle.MinimumVelocity = new Vector2((float)Convert.ToDouble(txtStartVelX.Text), (float)Convert.ToDouble(txtStartVelY.Text));
                Particle.MaximumVelocity = new Vector2((float)Convert.ToDouble(txtMaxVelX.Text), (float)Convert.ToDouble(txtMaxVelY.Text));
            }

            /* Static Acceleration */
            if (rdoStaticAccel.Checked)
            {
                Particle.Acceleration = new Vector2((float)Convert.ToDouble(txtStaticAccelX.Text), (float)Convert.ToDouble(txtStaticAccelY.Text));
                Particle.RandomAccel = false;
            }
            else
            {
                Particle.RandomAccel = true;
                Particle.MinimumAcceleration = new Vector2((float)Convert.ToDouble(txtStaticAccelX.Text), (float)Convert.ToDouble(txtStaticAccelY.Text));
                Particle.MaximumAcceleration = new Vector2((float)Convert.ToDouble(txtAccelRangeX.Text), (float)Convert.ToDouble(txtAccelRangeY.Text));
            }

            /* Single Color */
            if (rdoStaticColor.Checked)
            {
                Particle.EndColor = StartColor;
                Particle.StartColor = StartColor;
            }
            else
            {
                Particle.StartColor = StartColor;
                Particle.EndColor = EndColor;
            }

            /* Alpha Start */
            Particle.Alpha = (float)Convert.ToDouble(txtAlphaStart.Text);
            /* Alpha Change */
            Particle.AlphaChange = (float)Convert.ToDouble(txtAlphaChange.Text);

            /* Initial Rotation */
            Particle.Rotation = (float)Convert.ToDouble(txtRot.Text);

            /* Delta Rot */
            Particle.RotationSpeed = (float)Convert.ToDouble(txtDeltaRot.Text);

            /* Scale */
            Particle.Scale = (float)Convert.ToDouble(txtScale.Text);

            /* TTL */
            Particle.TTL = Convert.ToInt32(txtTTL.Text);

            /* Texture Name */
            Particle.TextureName = txtTexturePath.Text;
            ParticleCreated = true;
            this.Close();

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoStaticAccel.Checked)
            {
                /* Make the range stuff invisible */
                txtAccelRangeX.Visible = false;
                txtAccelRangeY.Visible = false;
                lblMaxAccel.Visible = false;
            }
            else
            {
                /* Make it visible! */
                txtAccelRangeX.Visible = true;
                txtAccelRangeY.Visible = true;
                lblMaxAccel.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdoStaticAccel.Checked)
            {
                /* Make the range stuff invisible */
                txtAccelRangeX.Visible = false;
                txtAccelRangeY.Visible = false;
                lblMaxAccel.Visible = false;
            }
            else
            {
                /* Make it visible! */
                txtAccelRangeX.Visible = true;
                txtAccelRangeY.Visible = true;
                lblMaxAccel.Visible = true;
            }
        }

        private void btnLerpColorStart_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Drawing.Color chosen = colorDialog1.Color;
                StartColor = new Microsoft.Xna.Framework.Color(chosen.R, chosen.G, chosen.B);
            }
        }

        private void btnLerpColorEnd_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.Drawing.Color chosen = colorDialog1.Color;
                EndColor = new Microsoft.Xna.Framework.Color(chosen.R, chosen.G, chosen.B);
            }
        }

        private Microsoft.Xna.Framework.Color StartColor;
        private Microsoft.Xna.Framework.Color EndColor;

    }
}
