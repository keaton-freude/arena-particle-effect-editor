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

        // Timer controls the rotation speed.
        Stopwatch timer;


        /// <summary>
        /// Initializes the control.
        /// </summary>
        protected override void Initialize()
        {
            // Start the animation timer.
            timer = Stopwatch.StartNew();
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // Hook the idle event to constantly redraw our animation.
            Application.Idle += delegate { Invalidate(); };
        }


        /// <summary>
        /// Draws the control.
        /// </summary>
        protected override void Draw()
        {
            // Clear to the default control background color.

            GraphicsDevice.Clear(Color.Black);

            if (Rendering)
            {
                spriteBatch.Begin();
                

                spriteBatch.End();
            }
            
        }


        /// <summary>
        /// Whenever a new model is selected, we examine it to see how big
        /// it is and where it is centered. This lets us automatically zoom
        /// the display, so we can correctly handle models of any scale.
        /// </summary>
   
    }
}
