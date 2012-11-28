using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsContentLoading
{
    public partial class EmitterPropertiesDlg : Form
    {
        public ParticleEmitter BuiltEmitter;
        public string State = "Cancel";

        public EmitterPropertiesDlg()
        {
            InitializeComponent();
            State = "New";

            BuiltEmitter = new ParticleEmitter();
        }

        public EmitterPropertiesDlg(ParticleEmitter copy)
        {
            InitializeComponent();
            BuiltEmitter = new ParticleEmitter();
            txtMinAngle.Text = copy.MinAngleRot.ToString();
            txtMaxAngle.Text = copy.MaxAngleRot.ToString();

            txtMinSpeedX.Text = copy.MinVelocity.X.ToString();
            txtMinSpeedY.Text = copy.MinVelocity.Y.ToString();
            txtMaxSpeedX.Text = copy.MaxVelocity.X.ToString();
            txtMaxSpeedY.Text = copy.MaxVelocity.Y.ToString();

            txtMaxParticles.Text = copy.MaxParticles.ToString();
            txtParticlesPerUpdate.Text = copy.ParticlesPerUpdate.ToString();

            txtMinOffsetX.Text = copy.OffsetMin.X.ToString();
            txtMinOffsetY.Text = copy.OffsetMin.Y.ToString();
            txtMaxOffsetX.Text = copy.OffsetMax.X.ToString();
            txtMaxOffsetY.Text = copy.OffsetMax.Y.ToString();

            txtMinAccelX.Text = copy.MinimumAcceleration.X.ToString();
            txtMinAccelY.Text = copy.MinimumAcceleration.Y.ToString();
            txtMaxAccelX.Text = copy.MaximumAcceleration.X.ToString();
            txtMaxAccelY.Text = copy.MaximumAcceleration.Y.ToString();

            State = "Edit";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            BuiltEmitter.MinAngleRot = (float)Convert.ToDouble(txtMinAngle.Text);
            BuiltEmitter.MaxAngleRot = (float)Convert.ToDouble(txtMaxAngle.Text);
            //BuiltEmitter.MinParticleSpeed = new Microsoft.Xna.Framework.Vector2((float)Convert.ToDouble(txtMinSpeedX.Text), (float)Convert.ToDouble(txtMinSpeedY.Text));
            //BuiltEmitter.MaxParticleSpeed = new Microsoft.Xna.Framework.Vector2((float)Convert.ToDouble(txtMaxSpeedX.Text), (float)Convert.ToDouble(txtMaxSpeedY.Text));

            BuiltEmitter.MinVelocity = new Microsoft.Xna.Framework.Vector2((float)Convert.ToDouble(txtMinSpeedX.Text), (float)Convert.ToDouble(txtMinSpeedY.Text));
            BuiltEmitter.MaxVelocity = new Microsoft.Xna.Framework.Vector2((float)Convert.ToDouble(txtMaxSpeedX.Text), (float)Convert.ToDouble(txtMaxSpeedY.Text));

            BuiltEmitter.MaxParticles = Convert.ToInt32(txtMaxParticles.Text);
            BuiltEmitter.ParticlesPerUpdate = Convert.ToInt32(txtParticlesPerUpdate.Text);

            BuiltEmitter.OffsetMin = new Microsoft.Xna.Framework.Vector2((float)Convert.ToDouble(txtMinOffsetX.Text), (float)Convert.ToDouble(txtMinOffsetY.Text));
            BuiltEmitter.OffsetMax = new Microsoft.Xna.Framework.Vector2((float)Convert.ToDouble(txtMaxOffsetX.Text), (float)Convert.ToDouble(txtMaxOffsetY.Text));

            BuiltEmitter.MinimumAcceleration = new Microsoft.Xna.Framework.Vector2((float)Convert.ToDouble(txtMinAccelX.Text), (float)Convert.ToDouble(txtMinAccelY.Text));
            BuiltEmitter.MaximumAcceleration = new Microsoft.Xna.Framework.Vector2((float)Convert.ToDouble(txtMaxAccelX.Text), (float)Convert.ToDouble(txtMaxAccelY.Text));

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            State = "Cancel";
            this.Close();
        }
    }
}
