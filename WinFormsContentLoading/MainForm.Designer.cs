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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEffectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFPSREAL = new System.Windows.Forms.Label();
            this.tabEffect1 = new System.Windows.Forms.TabPage();
            this.btnEmitterProperties = new System.Windows.Forms.Button();
            this.chkEmitterMouseFollow = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.rdoRandomPolling = new System.Windows.Forms.RadioButton();
            this.rdoRoundRobin = new System.Windows.Forms.RadioButton();
            this.btnAddParticle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstParticles = new System.Windows.Forms.ListBox();
            this.groupBoxLocation = new System.Windows.Forms.GroupBox();
            this.rdoAdditiveBlending = new System.Windows.Forms.RadioButton();
            this.rdoAlphaBlending = new System.Windows.Forms.RadioButton();
            this.groupBoxOneShot = new System.Windows.Forms.GroupBox();
            this.txtNumParticles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtIterations = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoContinuous = new System.Windows.Forms.RadioButton();
            this.rdoOneShot = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetEmitter = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label6 = new System.Windows.Forms.Label();
            this.lblParticlesActive = new System.Windows.Forms.Label();
            this.lblMaxParticles = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtSystemName = new System.Windows.Forms.TextBox();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.modelViewerControl = new WinFormsContentLoading.ModelViewerControl();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youllNeedItToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabEffect1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxLocation.SuspendLayout();
            this.groupBoxOneShot.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.renderToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.openFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuClicked);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.openFileToolStripMenuItem.Text = "Open File";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // renderToolStripMenuItem
            // 
            this.renderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.addEffectToolStripMenuItem});
            this.renderToolStripMenuItem.Name = "renderToolStripMenuItem";
            this.renderToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.renderToolStripMenuItem.Text = "System";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.testToolStripMenuItem.Text = "Go!";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // addEffectToolStripMenuItem
            // 
            this.addEffectToolStripMenuItem.Name = "addEffectToolStripMenuItem";
            this.addEffectToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.addEffectToolStripMenuItem.Text = "Add Effect";
            // 
            // lblFPSREAL
            // 
            this.lblFPSREAL.AutoSize = true;
            this.lblFPSREAL.BackColor = System.Drawing.Color.Black;
            this.lblFPSREAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPSREAL.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblFPSREAL.Location = new System.Drawing.Point(12, 94);
            this.lblFPSREAL.Name = "lblFPSREAL";
            this.lblFPSREAL.Size = new System.Drawing.Size(40, 18);
            this.lblFPSREAL.TabIndex = 3;
            this.lblFPSREAL.Text = "FPS";
            // 
            // tabEffect1
            // 
            this.tabEffect1.BackColor = System.Drawing.Color.Silver;
            this.tabEffect1.Controls.Add(this.btnEmitterProperties);
            this.tabEffect1.Controls.Add(this.chkEmitterMouseFollow);
            this.tabEffect1.Controls.Add(this.splitContainer1);
            this.tabEffect1.Controls.Add(this.btnSetEmitter);
            this.tabEffect1.Location = new System.Drawing.Point(4, 22);
            this.tabEffect1.Name = "tabEffect1";
            this.tabEffect1.Padding = new System.Windows.Forms.Padding(3);
            this.tabEffect1.Size = new System.Drawing.Size(358, 657);
            this.tabEffect1.TabIndex = 0;
            this.tabEffect1.Text = "Effect 1";
            // 
            // btnEmitterProperties
            // 
            this.btnEmitterProperties.Location = new System.Drawing.Point(248, 6);
            this.btnEmitterProperties.Name = "btnEmitterProperties";
            this.btnEmitterProperties.Size = new System.Drawing.Size(102, 36);
            this.btnEmitterProperties.TabIndex = 4;
            this.btnEmitterProperties.Text = "Emitter Properties";
            this.btnEmitterProperties.UseVisualStyleBackColor = true;
            this.btnEmitterProperties.Click += new System.EventHandler(this.btnEmitterProperties_Click);
            // 
            // chkEmitterMouseFollow
            // 
            this.chkEmitterMouseFollow.AutoSize = true;
            this.chkEmitterMouseFollow.Location = new System.Drawing.Point(107, 17);
            this.chkEmitterMouseFollow.Name = "chkEmitterMouseFollow";
            this.chkEmitterMouseFollow.Size = new System.Drawing.Size(131, 17);
            this.chkEmitterMouseFollow.TabIndex = 3;
            this.chkEmitterMouseFollow.Text = "Emitter Follows Mouse";
            this.chkEmitterMouseFollow.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(6, 48);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.btnRemove);
            this.splitContainer1.Panel1.Controls.Add(this.btnEdit);
            this.splitContainer1.Panel1.Controls.Add(this.rdoRandomPolling);
            this.splitContainer1.Panel1.Controls.Add(this.rdoRoundRobin);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddParticle);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lstParticles);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxLocation);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOneShot);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(346, 595);
            this.splitContainer1.SplitterDistance = 139;
            this.splitContainer1.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(169, 113);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(88, 113);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // rdoRandomPolling
            // 
            this.rdoRandomPolling.AutoSize = true;
            this.rdoRandomPolling.Location = new System.Drawing.Point(190, 47);
            this.rdoRandomPolling.Name = "rdoRandomPolling";
            this.rdoRandomPolling.Size = new System.Drawing.Size(138, 17);
            this.rdoRandomPolling.TabIndex = 4;
            this.rdoRandomPolling.Text = "Random Texture Polling";
            this.rdoRandomPolling.UseVisualStyleBackColor = true;
            // 
            // rdoRoundRobin
            // 
            this.rdoRoundRobin.AutoSize = true;
            this.rdoRoundRobin.Checked = true;
            this.rdoRoundRobin.Location = new System.Drawing.Point(190, 24);
            this.rdoRoundRobin.Name = "rdoRoundRobin";
            this.rdoRoundRobin.Size = new System.Drawing.Size(88, 17);
            this.rdoRoundRobin.TabIndex = 3;
            this.rdoRoundRobin.TabStop = true;
            this.rdoRoundRobin.Text = "Round Robin";
            this.rdoRoundRobin.UseVisualStyleBackColor = true;
            // 
            // btnAddParticle
            // 
            this.btnAddParticle.Location = new System.Drawing.Point(7, 113);
            this.btnAddParticle.Name = "btnAddParticle";
            this.btnAddParticle.Size = new System.Drawing.Size(75, 23);
            this.btnAddParticle.TabIndex = 2;
            this.btnAddParticle.Text = "Add Particle";
            this.btnAddParticle.UseVisualStyleBackColor = true;
            this.btnAddParticle.Click += new System.EventHandler(this.btnAddParticle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Particles in current Effect";
            // 
            // lstParticles
            // 
            this.lstParticles.FormattingEnabled = true;
            this.lstParticles.Location = new System.Drawing.Point(3, 24);
            this.lstParticles.Name = "lstParticles";
            this.lstParticles.Size = new System.Drawing.Size(181, 82);
            this.lstParticles.TabIndex = 0;
            this.lstParticles.SelectedIndexChanged += new System.EventHandler(this.lstParticles_SelectedIndexChanged);
            // 
            // groupBoxLocation
            // 
            this.groupBoxLocation.Controls.Add(this.rdoAdditiveBlending);
            this.groupBoxLocation.Controls.Add(this.rdoAlphaBlending);
            this.groupBoxLocation.Location = new System.Drawing.Point(7, 238);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(319, 63);
            this.groupBoxLocation.TabIndex = 4;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "Render Options";
            // 
            // rdoAdditiveBlending
            // 
            this.rdoAdditiveBlending.AutoSize = true;
            this.rdoAdditiveBlending.Location = new System.Drawing.Point(117, 19);
            this.rdoAdditiveBlending.Name = "rdoAdditiveBlending";
            this.rdoAdditiveBlending.Size = new System.Drawing.Size(107, 17);
            this.rdoAdditiveBlending.TabIndex = 1;
            this.rdoAdditiveBlending.TabStop = true;
            this.rdoAdditiveBlending.Text = "Additive Blending";
            this.rdoAdditiveBlending.UseVisualStyleBackColor = true;
            // 
            // rdoAlphaBlending
            // 
            this.rdoAlphaBlending.AutoSize = true;
            this.rdoAlphaBlending.Location = new System.Drawing.Point(15, 19);
            this.rdoAlphaBlending.Name = "rdoAlphaBlending";
            this.rdoAlphaBlending.Size = new System.Drawing.Size(96, 17);
            this.rdoAlphaBlending.TabIndex = 0;
            this.rdoAlphaBlending.TabStop = true;
            this.rdoAlphaBlending.Text = "Alpha Blending";
            this.rdoAlphaBlending.UseVisualStyleBackColor = true;
            // 
            // groupBoxOneShot
            // 
            this.groupBoxOneShot.Controls.Add(this.txtNumParticles);
            this.groupBoxOneShot.Controls.Add(this.label4);
            this.groupBoxOneShot.Controls.Add(this.txtRadius);
            this.groupBoxOneShot.Controls.Add(this.lblRadius);
            this.groupBoxOneShot.Controls.Add(this.txtIterations);
            this.groupBoxOneShot.Controls.Add(this.label3);
            this.groupBoxOneShot.Controls.Add(this.radioButton5);
            this.groupBoxOneShot.Controls.Add(this.radioButton4);
            this.groupBoxOneShot.Controls.Add(this.radioButton3);
            this.groupBoxOneShot.Location = new System.Drawing.Point(10, 91);
            this.groupBoxOneShot.Name = "groupBoxOneShot";
            this.groupBoxOneShot.Size = new System.Drawing.Size(319, 141);
            this.groupBoxOneShot.TabIndex = 2;
            this.groupBoxOneShot.TabStop = false;
            this.groupBoxOneShot.Text = "One Shot Rules";
            this.groupBoxOneShot.Visible = false;
            this.groupBoxOneShot.Enter += new System.EventHandler(this.groupBoxOneShot_Enter);
            // 
            // txtNumParticles
            // 
            this.txtNumParticles.Location = new System.Drawing.Point(125, 106);
            this.txtNumParticles.Name = "txtNumParticles";
            this.txtNumParticles.Size = new System.Drawing.Size(100, 20);
            this.txtNumParticles.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number of Particles";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(10, 67);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(47, 20);
            this.txtRadius.TabIndex = 6;
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(8, 50);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(40, 13);
            this.lblRadius.TabIndex = 5;
            this.lblRadius.Text = "Radius";
            // 
            // txtIterations
            // 
            this.txtIterations.Location = new System.Drawing.Point(10, 106);
            this.txtIterations.Name = "txtIterations";
            this.txtIterations.Size = new System.Drawing.Size(100, 20);
            this.txtIterations.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Iterations";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Enabled = false;
            this.radioButton5.Location = new System.Drawing.Point(125, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(63, 17);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Triangle";
            this.toolTip1.SetToolTip(this.radioButton5, "Option not enabled due to not being implemented.");
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Location = new System.Drawing.Point(60, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Square";
            this.toolTip1.SetToolTip(this.radioButton4, "Option not enabled due to not being implemented.");
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 20);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Circle";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoContinuous);
            this.groupBox1.Controls.Add(this.rdoOneShot);
            this.groupBox1.Location = new System.Drawing.Point(10, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Effect";
            // 
            // rdoContinuous
            // 
            this.rdoContinuous.AutoSize = true;
            this.rdoContinuous.Location = new System.Drawing.Point(83, 19);
            this.rdoContinuous.Name = "rdoContinuous";
            this.rdoContinuous.Size = new System.Drawing.Size(78, 17);
            this.rdoContinuous.TabIndex = 1;
            this.rdoContinuous.TabStop = true;
            this.rdoContinuous.Text = "Continuous";
            this.rdoContinuous.UseVisualStyleBackColor = true;
            this.rdoContinuous.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoOneShot
            // 
            this.rdoOneShot.AutoSize = true;
            this.rdoOneShot.Location = new System.Drawing.Point(7, 20);
            this.rdoOneShot.Name = "rdoOneShot";
            this.rdoOneShot.Size = new System.Drawing.Size(70, 17);
            this.rdoOneShot.TabIndex = 0;
            this.rdoOneShot.TabStop = true;
            this.rdoOneShot.Text = "One Shot";
            this.rdoOneShot.UseVisualStyleBackColor = true;
            this.rdoOneShot.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Effect Rules";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEffect1);
            this.tabControl1.Location = new System.Drawing.Point(918, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 683);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modelViewerControl_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            // 
            // lblParticlesActive
            // 
            this.lblParticlesActive.AutoSize = true;
            this.lblParticlesActive.BackColor = System.Drawing.Color.Black;
            this.lblParticlesActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticlesActive.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblParticlesActive.Location = new System.Drawing.Point(12, 112);
            this.lblParticlesActive.Name = "lblParticlesActive";
            this.lblParticlesActive.Size = new System.Drawing.Size(112, 18);
            this.lblParticlesActive.TabIndex = 5;
            this.lblParticlesActive.Text = "Particles Active:";
            // 
            // lblMaxParticles
            // 
            this.lblMaxParticles.AutoSize = true;
            this.lblMaxParticles.BackColor = System.Drawing.Color.Black;
            this.lblMaxParticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxParticles.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblMaxParticles.Location = new System.Drawing.Point(12, 130);
            this.lblMaxParticles.Name = "lblMaxParticles";
            this.lblMaxParticles.Size = new System.Drawing.Size(160, 18);
            this.lblMaxParticles.TabIndex = 6;
            this.lblMaxParticles.Text = "Max Particles Allowed: ";
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Current System Name: ";
            // 
            // txtSystemName
            // 
            this.txtSystemName.Location = new System.Drawing.Point(133, 27);
            this.txtSystemName.Name = "txtSystemName";
            this.txtSystemName.Size = new System.Drawing.Size(100, 20);
            this.txtSystemName.TabIndex = 8;
            this.txtSystemName.Text = "TestSystem";
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Location = new System.Drawing.Point(239, 25);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateName.TabIndex = 9;
            this.btnUpdateName.Text = "Update";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            // 
            // modelViewerControl
            // 
            this.modelViewerControl.EmitterLocation = new Microsoft.Xna.Framework.Vector2(0F, 0F);
            this.modelViewerControl.EmitterMarker = null;
            this.modelViewerControl.Location = new System.Drawing.Point(0, 50);
            this.modelViewerControl.Name = "modelViewerControl";
            this.modelViewerControl.Rendering = false;
            this.modelViewerControl.Size = new System.Drawing.Size(912, 661);
            this.modelViewerControl.TabIndex = 1;
            this.modelViewerControl.Text = "modelViewerControl";
            this.modelViewerControl.Textures = null;
            this.modelViewerControl.Click += new System.EventHandler(this.modelViewerControl_Click);
            this.modelViewerControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.modelViewerControl_MouseClick);
            this.modelViewerControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.modelViewerControl_MouseMove);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youllNeedItToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // youllNeedItToolStripMenuItem
            // 
            this.youllNeedItToolStripMenuItem.Name = "youllNeedItToolStripMenuItem";
            this.youllNeedItToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.youllNeedItToolStripMenuItem.Text = "You\'ll need it...";
            this.youllNeedItToolStripMenuItem.Click += new System.EventHandler(this.youllNeedItToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.btnUpdateName);
            this.Controls.Add(this.txtSystemName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMaxParticles);
            this.Controls.Add(this.lblParticlesActive);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblFPSREAL);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.modelViewerControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Arena 2D Particle Effect Editor - Alpha";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabEffect1.ResumeLayout(false);
            this.tabEffect1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxLocation.ResumeLayout(false);
            this.groupBoxLocation.PerformLayout();
            this.groupBoxOneShot.ResumeLayout(false);
            this.groupBoxOneShot.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private ModelViewerControl modelViewerControl;
        public System.Windows.Forms.Label lblFPSREAL;
        private System.Windows.Forms.ToolStripMenuItem renderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEffectToolStripMenuItem;
        private System.Windows.Forms.TabPage tabEffect1;
        private System.Windows.Forms.Button btnEmitterProperties;
        private System.Windows.Forms.CheckBox chkEmitterMouseFollow;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.RadioButton rdoRandomPolling;
        private System.Windows.Forms.RadioButton rdoRoundRobin;
        private System.Windows.Forms.Button btnAddParticle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstParticles;
        private System.Windows.Forms.GroupBox groupBoxLocation;
        private System.Windows.Forms.RadioButton rdoAdditiveBlending;
        private System.Windows.Forms.RadioButton rdoAlphaBlending;
        private System.Windows.Forms.GroupBox groupBoxOneShot;
        private System.Windows.Forms.TextBox txtNumParticles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtIterations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoContinuous;
        private System.Windows.Forms.RadioButton rdoOneShot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSetEmitter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblParticlesActive;
        public System.Windows.Forms.Label lblMaxParticles;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSystemName;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youllNeedItToolStripMenuItem;

    }
}

