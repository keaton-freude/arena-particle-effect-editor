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
            txtAlphaStart.Text = copy.Alpha.ToString();
            txtAlphaChange.Text = copy.AlphaChange.ToString();

            txtOffsetXMin.Text = copy.OffsetMinimum.X.ToString();
            txtOffsetYMin.Text = copy.OffsetMinimum.Y.ToString();
            txtOffsetXMax.Text = copy.OffsetMaximum.X.ToString();
            txtOffsetYMax.Text = copy.OffsetMaximum.Y.ToString();

            if (copy.RandomVelocity)
            {
                txtStartVelX.Text = copy.MinimumVelocity.X.ToString();
                txtStartVelY.Text = copy.MinimumVelocity.Y.ToString();
                txtMaxVelX.Text = copy.MaximumVelocity.X.ToString();
                txtMaxVelY.Text = copy.MaximumVelocity.Y.ToString();
                rdoVelRange.Checked = true;
            }
            else
            {
                txtStartVelX.Text = copy.MinimumVelocity.X.ToString();
                txtStartVelY.Text = copy.MinimumVelocity.Y.ToString();
                rdoStaticVel.Checked = true;
            }

            if (copy.RandomAccel)
            {
                txtStaticAccelX.Text = copy.MinimumAcceleration.X.ToString();
                txtStaticAccelY.Text = copy.MinimumAcceleration.Y.ToString();
                txtAccelRangeX.Text = copy.MaximumAcceleration.X.ToString();
                txtAccelRangeY.Text = copy.MaximumAcceleration.Y.ToString();
                rdoRangeAccel.Checked = true;
            }
            else
            {
                txtStaticAccelX.Text = copy.MinimumAcceleration.X.ToString();
                txtStaticAccelY.Text = copy.MinimumAcceleration.Y.ToString();
                rdoStaticAccel.Checked = true;
            }

            txtRot.Text = copy.Rotation.ToString();
            txtDeltaRot.Text = copy.RotationSpeed.ToString();
            txtScale.Text = copy.Scale.ToString();

            if (copy.RangeTTL)
            {
                txtMaxTTL.Text = copy.MaxTTL.ToString();
                txtTTL.Text = copy.MinTTL.ToString();
                rdoRangeTTL.Checked = true;
            }
            else
            {
                txtTTL.Text = copy.TTL.ToString();
                rdoStaticTTL.Checked = true;
            }

            txtTexturePath.Text = copy.TextureName;

            System.Drawing.Color color;
            color = System.Drawing.Color.FromArgb(copy.StartColor.R, copy.StartColor.G, copy.StartColor.B);
            pctStartColor.BackColor = color;
            pctEndColor.BackColor = System.Drawing.Color.FromArgb(copy.EndColor.R, copy.EndColor.G, copy.EndColor.B);

            if (copy.ColorInterpolation)
                rdoColorLerp.Checked = true;
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


            /* Check to see if a ranged TTL is being used */
            if (rdoRangeTTL.Checked)
            {
                Particle.MinTTL = Convert.ToInt32(txtTTL.Text);
                Particle.MaxTTL = Convert.ToInt32(txtMaxTTL.Text);
                Particle.RangeTTL = true;
            }
            else
            {
                Particle.TTL = Convert.ToInt32(txtTTL.Text);
                //Particle._BaseTTL = Particle.TTL;
                Particle.RangeTTL = false;
            }

            Particle.OffsetMaximum = new Vector2((float)Convert.ToDouble(txtOffsetXMax.Text), (float)Convert.ToDouble(txtOffsetYMax.Text));
            Particle.OffsetMinimum = new Vector2((float)Convert.ToDouble(txtOffsetXMin.Text), (float)Convert.ToDouble(txtOffsetYMin.Text));

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

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (rdoStaticTTL.Checked)
            {
                /* Hide range TTL */
                lblMaxTTL.Visible = false;
                txtMaxTTL.Visible = false;
            }
            else
            {
                lblMaxTTL.Visible = true;
                txtMaxTTL.Visible = true;
            }
        }

        private void rdoRangeTTL_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoStaticTTL.Checked)
            {
                /* Hide range TTL */
                lblMaxTTL.Visible = false;
                txtMaxTTL.Visible = false;
            }
            else
            {
                lblMaxTTL.Visible = true;
                txtMaxTTL.Visible = true;
            }
        }

    }
}
