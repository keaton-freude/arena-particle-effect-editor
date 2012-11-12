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
using Microsoft.Xna.Framework.Graphics;

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


        /// <summary>
        /// Constructs the main form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            fpsLabel = lblFPSREAL;

            contentBuilder = new ContentBuilder();

            contentManager = new ContentManager(modelViewerControl.Services,
                                                contentBuilder.OutputDirectory);

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
        Texture2D LoadTexture(string fileName)
        {
            Cursor = Cursors.WaitCursor;

            string assemblyLocation = Assembly.GetExecutingAssembly().Location;
            string real_path = Path.Combine(assemblyLocation, "..\\..\\..\\..\\Content\\" + fileName);
            string contentPath = Path.GetFullPath(real_path);

            // Unload any existing model.
            //contentManager.Unload();

            // Tell the ContentBuilder what to build.
            contentBuilder.Clear();
            contentBuilder.Add(contentPath, "Texture", null, "TextureProcessor");

            // Build this new model data.
            string buildError = contentBuilder.Build();

            if (string.IsNullOrEmpty(buildError))
            {
                // If the build succeeded, use the ContentManager to
                // load the temporary .xnb file that we just created.
                Cursor = Cursors.Arrow;
                return contentManager.Load<Texture2D>("Texture");
                
                
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
               
            }
        }

        private void btnAddParticle_Click(object sender, EventArgs e)
        {
            AddParticleDlg dlg = new AddParticleDlg();
            dlg.ShowDialog();

            /* Store Particle in List */
            if (dlg.ParticleCreated)
                lstParticles.Items.Add(dlg.Particle);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOneShot.Checked)
            {
                groupBoxOneShot.Visible = true;
                groupBoxContinuous.Visible = false;
            }
            else
            {
                groupBoxContinuous.Visible = true;
                groupBoxOneShot.Visible = false;
            }
        }

        public static Label fpsLabel;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoOneShot.Checked)
            {
                groupBoxOneShot.Visible = true;
                groupBoxContinuous.Visible = false;
            }
            else
            {
                groupBoxContinuous.Visible = true;
                groupBoxOneShot.Visible = false;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            /* Create the effect */

            /* Create the list of textures according to our listbox */

            /* We only test one at a time, we'll kill the ParticleENgine effects list each time */
            ParticleEngine.Instance.effects.Clear();

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
                OneShotParticleEffect one_shot_effect = new OneShotParticleEffect(textures);
                one_shot_effect.EmitterLocation = modelViewerControl.EmitterLocation;
                one_shot_effect.MasterParticles = masterParticles;

                one_shot_effect.TexturePolling = TexturePolling;
                one_shot_effect.NumberOfParticles = Convert.ToInt32(txtNumParticles.Text);

                one_shot_effect.Iterations = Convert.ToInt32(txtIterations.Text);
                one_shot_effect.CircleRadius = (float)Convert.ToDouble(txtRadius.Text);
                ParticleEngine.Instance.effects.Add("Test", one_shot_effect);
                ((OneShotParticleEffect)ParticleEngine.Instance.effects["Test"]).Fire();
                modelViewerControl.Rendering = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
