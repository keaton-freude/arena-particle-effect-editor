namespace WinFormsContentLoading
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabControl = new System.Windows.Forms.TabPage();
            this.btnSetEmitter = new System.Windows.Forms.Button();
            this.modelViewerControl = new WinFormsContentLoading.ModelViewerControl();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabControl);
            this.tabControl1.Location = new System.Drawing.Point(918, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 675);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modelViewerControl_MouseClick);
            // 
            // TabControl
            // 
            this.TabControl.BackColor = System.Drawing.Color.Silver;
            this.TabControl.Controls.Add(this.btnSetEmitter);
            this.TabControl.Location = new System.Drawing.Point(4, 22);
            this.TabControl.Name = "TabControl";
            this.TabControl.Padding = new System.Windows.Forms.Padding(3);
            this.TabControl.Size = new System.Drawing.Size(358, 649);
            this.TabControl.TabIndex = 0;
            this.TabControl.Text = "tabPage1";
            // 
            // btnSetEmitter
            // 
            this.btnSetEmitter.Location = new System.Drawing.Point(3, 6);
            this.btnSetEmitter.Name = "btnSetEmitter";
            this.btnSetEmitter.Size = new System.Drawing.Size(100, 36);
            this.btnSetEmitter.TabIndex = 1;
            this.btnSetEmitter.Text = "Set Emitter Location";
            this.btnSetEmitter.UseVisualStyleBackColor = true;
            this.btnSetEmitter.Click += new System.EventHandler(this.button1_Click);
            // 
            // modelViewerControl
            // 
            this.modelViewerControl.EmitterLocation = new Microsoft.Xna.Framework.Vector2(0F, 0F);
            this.modelViewerControl.Location = new System.Drawing.Point(0, 27);
            this.modelViewerControl.Name = "modelViewerControl";
            this.modelViewerControl.Size = new System.Drawing.Size(912, 684);
            this.modelViewerControl.TabIndex = 1;
            this.modelViewerControl.Text = "modelViewerControl";
            this.modelViewerControl.Click += new System.EventHandler(this.modelViewerControl_Click);
            this.modelViewerControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modelViewerControl_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.modelViewerControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "WinForms Content Loading";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private ModelViewerControl modelViewerControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabControl;
        private System.Windows.Forms.Button btnSetEmitter;

    }
}

