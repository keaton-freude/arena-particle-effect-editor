#region File Description
//-----------------------------------------------------------------------------
// MainForm.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
#endregion
using Microsoft.Xna.Framework;
using System.Linq;
//using Microsoft.Xna.Framework.Graphics;

using System.Collections.Generic;

namespace WinFormsContentLoading
{
    /// <summary>
    /// Custom form provides the main user interface for the program.
    /// In this sample we used the designer to fill the entire form with a
    /// ModelViewerControl, except for the menu bar which provides the
    /// "File / Open..." option.
    /// </summary>
    public partial class MainForm : Form
    {
        ContentBuilder contentBuilder;
        ContentManager contentManager;

        String State = "None";

        public ParticleEmitter emitter = null;
        public float emitter_rot = 0.0f;

        public static Label particleCountLabel;
        public static Label maxParticleCount;

        public string CurrentSystemName = "None";

        /// <summary>
        /// Constructs the main form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            fpsLabel = lblFPSREAL;
            particleCountLabel = lblParticlesActive;
            maxParticleCount = lblMaxParticles;

            contentBuilder = new ContentBuilder();

            contentManager = new ContentManager(modelViewerControl.Services,
                                                contentBuilder.OutputDirectory);

            ParticleEngine.Instance.main_form_reference = this;

            /// Automatically bring up the "Load Model" dialog when we are first shown.
            //this.Shown += OpenMenuClicked;

        }


        /// <summary>
        /// Event handler for the Exit menu option.
        /// </summary>
        void ExitMenuClicked(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Event handler for the Open menu option.
        /// </summary>
        void OpenMenuClicked(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            // Default to the directory which contains our content files.
            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string relativePath = Path.Combine(assemblyLocation, "../../../../Content/");
            string contentPath = Path.GetFullPath(relativePath);

            fileDialog.InitialDirectory = contentPath;

            fileDialog.Title = "Load Model";

            fileDialog.Filter = "All Files (*.*)|*.*";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //LoadModel(fileDialog.FileName);
            }
        }


        /// <summary>
        /// Loads a new 3D model file into the ModelViewerControl.
        /// </summary>
        public Texture2D LoadTexture(string fileName)
        {
            Cursor = Cursors.WaitCursor;

            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string real_path = Path.Combine(assemblyLocation, "..\\..\\..\\..\\Content\\" + fileName);
            string contentPath = Path.GetFullPath(real_path);

            // Unload any existing model.
            //contentManager.Unload();

            // Tell the ContentBuilder what to build.
            //contentBuilder.Clear();
            contentBuilder.Add(contentPath, fileName.Split('.')[0], null, "TextureProcessor");

            // Build this new model data.
            string buildError = contentBuilder.Build();

            if (string.IsNullOrEmpty(buildError))
            {
                // If the build succeeded, use the ContentManager to
                // load the temporary .xnb file that we just created.
                Cursor = Cursors.Arrow;
                return contentManager.Load<Texture2D>(fileName.Split('.')[0]);
                
                
            }
            else
            {
                // If the build failed, display an error message.
                MessageBox.Show(buildError, "Error");
                return null;
            }

            Cursor = Cursors.Arrow;
        }

        private void modelViewerControl_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            State = "SetEmitter";
            btnSetEmitter.Enabled = false;
            btnSetEmitter.Text = "Click Location";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void modelViewerControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (State == "SetEmitter")
            {
                modelViewerControl.EmitterLocation = new Microsoft.Xna.Framework.Vector2(e.X, e.Y);
               // MessageBox.Show(modelViewerControl.EmitterLocation.ToString());
                State = "None";
                btnSetEmitter.Enabled = true;
                btnSetEmitter.Text = "Set Emitter Location";
                modelViewerControl.EmitterMarker = LoadTexture("EmitterMarker.bmp");
                if (emitter == null)
                    emitter = new ParticleEmitter();
                //else
                //{
                    emitter.Location = new Microsoft.Xna.Framework.Vector2(e.X, e.Y);
                    emitter.LastLocation = emitter.Location;
                //}
            }
        }

        private void btnAddParticle_Click(object sender, EventArgs e)
        {
            AddParticleDlg dlg = new AddParticleDlg();
            dlg.ShowDialog();

            /* Store Particle in List */
            if (dlg.ParticleCreated)
            {
                dlg.Particle.Texture = LoadTexture(dlg.Particle.TextureName);
                lstParticles.Items.Add(dlg.Particle);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOneShot.Checked)
            {
                groupBoxOneShot.Visible = true;
                //groupBoxContinuous.Visible = false;
            }
            else
            {
                //groupBoxContinuous.Visible = true;
                groupBoxOneShot.Visible = false;
            }
        }

        public static Label fpsLabel;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdoOneShot.Checked)
            //{
            //    groupBoxOneShot.Visible = true;
            //    groupBoxOneShot.BringToFront();
            //    groupBoxContinuous.Visible = false;
            //}
            //else
            //{
            //    groupBoxContinuous.Visible = true;
            //    groupBoxOneShot.Visible = false;
            //    groupBoxContinuous.BringToFront();
            //}

            if (rdoOneShot.Checked)
            {
                groupBoxOneShot.Visible = true;
                //groupBoxContinuous.Visible = false;
            }
            else
            {
                //groupBoxContinuous.Visible = true;
                groupBoxOneShot.Visible = false;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            /* Create the effect */

            /* Create the list of textures according to our listbox */

            /* We only test one at a time, we'll kill the ParticleENgine effects list each time */
            ParticleEngine.Instance.systems.Clear();

            String TexturePolling = "";

            if (rdoRandomPolling.Checked)
                TexturePolling = "Random";
            else
                TexturePolling = "RoundRobin";

            List<Texture2D> textures = new List<Texture2D>();
            foreach (Particle p in lstParticles.Items)
            {
                textures.Add(LoadTexture(p.TextureName));
            }

            List<Particle> masterParticles = new List<Particle>();
            foreach (Particle p in lstParticles.Items)
            {
                masterParticles.Add(p);
            }

            /* If we're doing one shot we'll handle it here */

            if (rdoOneShot.Checked)
            {
                //OneShotParticleEffect one_shot_effect = new OneShotParticleEffect(textures);
                //one_shot_effect.EmitterLocation = modelViewerControl.EmitterLocation;
                //one_shot_effect.MasterParticles = masterParticles;
                //if (rdoAlphaBlending.Checked)
                //{
                //    one_shot_effect.BlendingState = "Alpha";
                //}
                //else if (rdoAdditiveBlending.Checked)
                //{
                //    one_shot_effect.BlendingState = "Additive";
                //}
                //one_shot_effect.TexturePolling = TexturePolling;
                //one_shot_effect.NumberOfParticles = Convert.ToInt32(txtNumParticles.Text);

                //one_shot_effect.Iterations = Convert.ToInt32(txtIterations.Text);
                //one_shot_effect.CircleRadius = (float)Convert.ToDouble(txtRadius.Text);
                //ParticleEngine.Instance.effects.Add("Test", one_shot_effect);
                //((OneShotParticleEffect)ParticleEngine.Instance.effects["Test"]).Fire();
                //modelViewerControl.Rendering = true;
            }
            else if (rdoContinuous.Checked)
            {
                //ContinuousParticleEffect continuous_effect = new ContinuousParticleEffect(textures);
                //continuous_effect.EmitterLocation = modelViewerControl.EmitterLocation;
                //continuous_effect.MasterParticles = masterParticles;
                //if (rdoAlphaBlending.Checked)
                //{
                //    continuous_effect.BlendingState = "Alpha";
                //}
                //else
                //    continuous_effect.BlendingState = "Additive";
                //continuous_effect.TexturePolling = TexturePolling;
                //continuous_effect.MaxParticles = Convert.ToInt32(txtMaxParticles.Text);
                //continuous_effect.ParticlesPerUpdate = Convert.ToInt32(txtParticlesPerUpdate.Text);
                //ParticleEngine.Instance.effects.Add("Test", continuous_effect);
                //((ContinuousParticleEffect)ParticleEngine.Instance.effects["Test"]).Generating = true;
                //modelViewerControl.Rendering = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstParticles.SelectedIndex != -1)
            {
                /* Spawn ParticleEditor window with the currently selected */
                /* particle as the argument, allows user to edit */

                AddParticleDlg dlg = new AddParticleDlg((Particle)lstParticles.Items[lstParticles.SelectedIndex]);
                dlg.ShowDialog();

                if (dlg.EditedParticle)
                {
                    dlg.Particle.Texture = LoadTexture(dlg.Particle.TextureName);
                    lstParticles.Items[lstParticles.SelectedIndex] = dlg.Particle;
                    
                }
            }
        }

        public float GetAngle(Vector2 From, Vector2 Dest)
        {
            From.Normalize();
            Dest.Normalize();
            float Angle = (float)Math.Acos(Vector2.Dot(From, Dest));

            return (float)Angle;
        }

        private void modelViewerControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (chkEmitterMouseFollow.Checked)
            {
                modelViewerControl.EmitterLocation = new Vector2(e.X, e.Y);
                ParticleEngine.Instance.systems[CurrentSystemName].effects[0].Emitter.Location = new Vector2(e.X, e.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {

                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstParticles.SelectedIndex != -1)
            {
                lstParticles.Items.RemoveAt(lstParticles.SelectedIndex);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void groupBoxOneShot_Enter(object sender, EventArgs e)
        {

        }

        private void btnEmitterProperties_Click(object sender, EventArgs e)
        {
            EmitterPropertiesDlg dlg;
            if (emitter == null)
                dlg = new EmitterPropertiesDlg();
            else
                dlg = new EmitterPropertiesDlg(emitter);

            dlg.ShowDialog();

            if (dlg.State == "New")
            {
                emitter = dlg.BuiltEmitter;
                emitter.Location = modelViewerControl.EmitterLocation;
            }
            else if (dlg.State == "Edit")
            {
                emitter = dlg.BuiltEmitter;
                emitter.Location = modelViewerControl.EmitterLocation;
                emitter.LastLocation = emitter.Location;
            }


        }

        private void lstParticles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Check to see if there's an effect already loaded into the particle engine */
            
            if (ParticleEngine.Instance.systems.Count != 0)
            {
                /* Okay we got a system already in place */
                /* Ask user if we want to load a fresh one from the currently selected items
                 * or if he'd like to test what's currently loaded */
                modelViewerControl.Rendering = false;
                if (overwrite || MessageBox.Show("Yo! You already got a system loaded. Do you want to discard that system and build another based"
                    + " on current parameters? WARNING: Doing so will discard all changes" 
                    + "that have not been saved to the currently loaded system", "System already loaded", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                {
                    /* Lets just take whatever system is loaded (we can guarantee only one) and start it up */

                    /* NOTE: ASSUMING CONTINUOUS FIX THIS BEFORE LAUNCH LOL */
                    ParticleEngine.Instance.systems[CurrentSystemName].effects[0].Emitter.Location = emitter.Location;
                    /* If continuous */
                    if (ParticleEngine.Instance.systems[CurrentSystemName].effects[0].GetType().ToString().Split('.').Last() == "ContinuousParticleEffect")
                        ((ContinuousParticleEffect)ParticleEngine.Instance.systems[CurrentSystemName].effects[0]).Generating = true;
                    else
                        ((OneShotParticleEffect)ParticleEngine.Instance.systems[CurrentSystemName].effects[0]).Fire();

                    modelViewerControl.Rendering = true;
                }
                else
                {
                    /* User wants to discard old effect and build new one from current context */
                    BuildAndRunNewEffect();
                }
            }
            else
            {
                /* No effect loaded, we'll build one from our current context */
                BuildAndRunNewEffect();
            }
        }

        public void BuildAndRunNewEffect()
        {
            CurrentSystemName = txtSystemName.Text;
            ParticleEngine.Instance.systems.Clear();
            ParticleEngine.Instance.systems.Add(CurrentSystemName, new ParticleSystem(CurrentSystemName));

            String TexturePolling = "";

            if (rdoRandomPolling.Checked)
                TexturePolling = "Random";
            else
                TexturePolling = "RoundRobin";

            List<Texture2D> textures = new List<Texture2D>();
            foreach (Particle p in lstParticles.Items)
            {
                textures.Add(p.Texture);
            }

            List<Particle> masterParticles = new List<Particle>();
            foreach (Particle p in lstParticles.Items)
            {
                masterParticles.Add(p);
            }
            emitter.InitialRot = emitter_rot;
            
            /* If we're doing one shot we'll handle it here */

            if (rdoOneShot.Checked)
            {

                OneShotParticleEffect one_shot_effect = new OneShotParticleEffect(textures, emitter);
                one_shot_effect.MasterParticles = masterParticles;
                if (rdoAlphaBlending.Checked)
                {
                    one_shot_effect.BlendingState = "Alpha";
                }
                else if (rdoAdditiveBlending.Checked)
                {
                    one_shot_effect.BlendingState = "Additive";
                }
                one_shot_effect.TexturePolling = TexturePolling;
                one_shot_effect.Emitter = emitter;

                one_shot_effect.Iterations = Convert.ToInt32(txtIterations.Text);
                one_shot_effect.CircleRadius = (float)Convert.ToDouble(txtRadius.Text);

                ParticleEngine.Instance.systems[CurrentSystemName].effects.Add(one_shot_effect);
                ((OneShotParticleEffect)ParticleEngine.Instance.systems[CurrentSystemName].effects[0]).Fire();
                modelViewerControl.Rendering = true;
            }
            else
            {
                ContinuousParticleEffect continuous_effect = new ContinuousParticleEffect(textures, emitter);
                continuous_effect.MasterParticles = masterParticles;
                if (rdoAlphaBlending.Checked)
                {
                    continuous_effect.BlendingState = "Alpha";
                }
                else if (rdoAdditiveBlending.Checked)
                {
                    continuous_effect.BlendingState = "Additive";
                }
                continuous_effect.TexturePolling = TexturePolling;
                continuous_effect.Emitter = emitter;

                ParticleEngine.Instance.systems[CurrentSystemName].effects.Add(continuous_effect);
                ((ContinuousParticleEffect)ParticleEngine.Instance.systems[CurrentSystemName].effects[0]).Generating = true;
                modelViewerControl.Rendering = true;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //modelViewerControl.emitter_rot = (float)((float)trackBar1.Value / 100.0f);
            ////emitter.InitialRot = (float)((float)trackBar1.Value / 100.0f);
            //emitter_rot = (float)((float)trackBar1.Value / 100.0f);
            //if (ParticleEngine.Instance.systems.ContainsKey("Test"))
            //{
            //    ParticleEngine.Instance.systems["Test"].effects[0].Emitter.InitialRot = emitter_rot;
            //}
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                testToolStripMenuItem_Click(sender, null);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            string system_name = "";
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = dlg.FileName;
                system_name = ParticleEngine.Instance.LoadFromFile(path);

                if (system_name != "Fail")
                {
                    Vector2 temp_location = Vector2.Zero;
                    if (emitter != null)
                        temp_location = emitter.Location;
                    
                    emitter = ParticleEngine.Instance.systems[system_name].effects[0].Emitter;
                    emitter.Location = temp_location;
                    emitter.LastLocation = temp_location;
                    if (ParticleEngine.Instance.systems[system_name].effects[0].TexturePolling == "Random")
                    {
                        rdoRandomPolling.Checked = true;
                    }
                    else
                        rdoRoundRobin.Checked = true;
                    
                    
                    
                    lstParticles.Items.Clear();
                    foreach (Particle p in ParticleEngine.Instance.systems[system_name].effects[0].MasterParticles)
                    {
                        p.Texture = LoadTexture(p.TextureName);
                        lstParticles.Items.Add(p);
                    }

                    //string what = ParticleEngine.Instance.systems[system_name].effects[0].GetType().ToString().Split('.').Last();

                    if (ParticleEngine.Instance.systems[system_name].effects[0].GetType().ToString().Split('.').Last() == "ContinuousParticleEffect")
                    {
                        rdoContinuous.Checked = true;
                    }
                    else
                        rdoOneShot.Checked = true;

                    if (ParticleEngine.Instance.systems[system_name].effects[0].BlendingState == "Alpha")
                        rdoAlphaBlending.Checked = true;
                    else
                        rdoAdditiveBlending.Checked = true;

                    CurrentSystemName = system_name;

                }
            }
        }

        private void youllNeedItToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unless you wrote this awesome little thing, using it might seem foreign. Refer to the document that" +
                " came in the installation directory of this program called ReadMePlease.txt in order to learn how to use this little thing");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Save the currently loaded system to file */

            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (System.Xml.XmlWriter writer = System.Xml.XmlWriter.Create(dlg.FileName))
                {
                    ParticleEngine.Instance.systems[CurrentSystemName].SaveToFile(writer);
                }
            }
        }

        private void alwaysOverwriteOldSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            overwrite = !overwrite;
            alwaysOverwriteOldSystemToolStripMenuItem.Checked = overwrite;
        }

        private bool overwrite = false;
       
    }
}
