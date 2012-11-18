#region File Description
//-----------------------------------------------------------------------------
// ModelViewerControl.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace WinFormsContentLoading
{
    /// <summary>
    /// Example control inherits from GraphicsDeviceControl, and displays
    /// a spinning 3D model. The main form class is responsible for loading
    /// the model: this control just displays it.
    /// </summary>
    class ModelViewerControl : GraphicsDeviceControl
    {
        /// <summary>
        /// Gets or sets the current model.
        /// </summary>


        

        SpriteBatch spriteBatch;
        public Vector2 EmitterLocation
        {
            get;
            set;
        }

        /* If we're rendering we play our particle effect according to the rules we have */
        public bool Rendering
        {
            get;
            set;
        }
        // Cache information about the model size and position.

        Random random = new Random();

        public List<Texture2D> Textures
        {
            get;
            set;
        }

        public Texture2D EmitterMarker
        {
            get;
            set;
        }

        // Timer controls the rotation speed.
        Stopwatch timer;

        Stopwatch render_control;


        /// <summary>
        /// Initializes the control.
        /// </summary>
        protected override void Initialize()
        {
            EmitterLocation = new Vector2(Width / 2, Height / 2);
            // Start the animation timer.
            timer = Stopwatch.StartNew();

            render_control = Stopwatch.StartNew();
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            // Hook the idle event to constantly redraw our animation.
            Application.Idle += delegate { Invalidate(); };
        }


        /// <summary>
        /// Draws the control.
        /// </summary>
        /// 

        int frames = 0;
        long current_time = 0;
        String FPS = "FPS: ";
        protected override void Draw()
        {
            // Clear to the default control background color.
            
            GraphicsDevice.Clear(Color.Black);

            /* We will always draw the current Emitter Location */

            spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.AlphaBlend);
            if (EmitterMarker != null)
                spriteBatch.Draw(EmitterMarker, new Vector2(EmitterLocation.X - EmitterMarker.Width / 4, EmitterLocation.Y - EmitterMarker.Height / 4), null, Color.White * .2f, 0.0f, Vector2.Zero, .5f, SpriteEffects.None, 1.0f );
            spriteBatch.End();

            MainForm.fpsLabel.Text = FPS;
            if (Rendering)
            {
                
                ParticleEngine.Instance.Draw(spriteBatch);
            }

            
            if (timer.ElapsedMilliseconds >= 17)
            {
                frames++;
                current_time += timer.ElapsedMilliseconds;
                if (current_time >= 1000)
                {
                    current_time -= 1000;
                    FPS = String.Format("FPS: {0}", frames);
                    frames = 0;
                }
                ParticleEngine.Instance.Update((float)timer.ElapsedMilliseconds / 1000.0f, EmitterLocation);
                timer.Restart();
            }
        }


        /// <summary>
        /// Whenever a new model is selected, we examine it to see how big
        /// it is and where it is centered. This lets us automatically zoom
        /// the display, so we can correctly handle models of any scale.
        /// </summary>
   
    }
}
