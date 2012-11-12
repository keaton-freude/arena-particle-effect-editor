namespace WinFormsContentLoading
{
    partial class AddParticleDlg
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStaticAccelX = new System.Windows.Forms.TextBox();
            this.txtStaticAccelY = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnStaticColor = new System.Windows.Forms.Button();
            this.lblStaticColor = new System.Windows.Forms.Label();
            this.rdoStaticColor = new System.Windows.Forms.RadioButton();
            this.rdoColorLerp = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlphaChange = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlphaStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLerpColorEnd = new System.Windows.Forms.Button();
            this.btnLerpColorStart = new System.Windows.Forms.Button();
            this.lblEndColor = new System.Windows.Forms.Label();
            this.lblStartColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTexturePath = new System.Windows.Forms.TextBox();
            this.btnAddTexture = new System.Windows.Forms.Button();
            this.txtTTL = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeltaRot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMaxAccel = new System.Windows.Forms.Label();
            this.rdoStaticAccel = new System.Windows.Forms.RadioButton();
            this.lblStartAccel = new System.Windows.Forms.Label();
            this.rdoRangeAccel = new System.Windows.Forms.RadioButton();
            this.txtAccelRangeX = new System.Windows.Forms.TextBox();
            this.txtAccelRangeY = new System.Windows.Forms.TextBox();
            this.txtMaxVelY = new System.Windows.Forms.TextBox();
            this.txtStartVelY = new System.Windows.Forms.TextBox();
            this.txtMaxVelX = new System.Windows.Forms.TextBox();
            this.lblMaxVelocity = new System.Windows.Forms.Label();
            this.lblStartVelocity = new System.Windows.Forms.Label();
            this.txtStartVelX = new System.Windows.Forms.TextBox();
            this.rdoVelRange = new System.Windows.Forms.RadioButton();
            this.rdoStaticVel = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(109, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Particle 1";
            // 
            // txtStaticAccelX
            // 
            this.txtStaticAccelX.Location = new System.Drawing.Point(5, 74);
            this.txtStaticAccelX.Name = "txtStaticAccelX";
            this.txtStaticAccelX.Size = new System.Drawing.Size(53, 20);
            this.txtStaticAccelX.TabIndex = 6;
            this.txtStaticAccelX.Text = "0.0";
            // 
            // txtStaticAccelY
            // 
            this.txtStaticAccelY.Location = new System.Drawing.Point(64, 74);
            this.txtStaticAccelY.Name = "txtStaticAccelY";
            this.txtStaticAccelY.Size = new System.Drawing.Size(53, 20);
            this.txtStaticAccelY.TabIndex = 7;
            this.txtStaticAccelY.Text = "0.0";
            // 
            // btnStaticColor
            // 
            this.btnStaticColor.Location = new System.Drawing.Point(59, 79);
            this.btnStaticColor.Name = "btnStaticColor";
            this.btnStaticColor.Size = new System.Drawing.Size(75, 23);
            this.btnStaticColor.TabIndex = 8;
            this.btnStaticColor.Text = "Select Color";
            this.btnStaticColor.UseVisualStyleBackColor = true;
            this.btnStaticColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStaticColor
            // 
            this.lblStaticColor.AutoSize = true;
            this.lblStaticColor.Location = new System.Drawing.Point(60, 63);
            this.lblStaticColor.Name = "lblStaticColor";
            this.lblStaticColor.Size = new System.Drawing.Size(31, 13);
            this.lblStaticColor.TabIndex = 9;
            this.lblStaticColor.Text = "Color";
            // 
            // rdoStaticColor
            // 
            this.rdoStaticColor.AutoSize = true;
            this.rdoStaticColor.Checked = true;
            this.rdoStaticColor.Location = new System.Drawing.Point(6, 29);
            this.rdoStaticColor.Name = "rdoStaticColor";
            this.rdoStaticColor.Size = new System.Drawing.Size(79, 17);
            this.rdoStaticColor.TabIndex = 10;
            this.rdoStaticColor.TabStop = true;
            this.rdoStaticColor.Text = "Static Color";
            this.rdoStaticColor.UseVisualStyleBackColor = true;
            this.rdoStaticColor.CheckedChanged += new System.EventHandler(this.rdoStaticColor_CheckedChanged);
            // 
            // rdoColorLerp
            // 
            this.rdoColorLerp.AutoSize = true;
            this.rdoColorLerp.Location = new System.Drawing.Point(97, 29);
            this.rdoColorLerp.Name = "rdoColorLerp";
            this.rdoColorLerp.Size = new System.Drawing.Size(110, 17);
            this.rdoColorLerp.TabIndex = 11;
            this.rdoColorLerp.Text = "Color Interpolation";
            this.rdoColorLerp.UseVisualStyleBackColor = true;
            this.rdoColorLerp.CheckedChanged += new System.EventHandler(this.rdoColorLerp_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlphaChange);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAlphaStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLerpColorEnd);
            this.groupBox1.Controls.Add(this.btnLerpColorStart);
            this.groupBox1.Controls.Add(this.lblEndColor);
            this.groupBox1.Controls.Add(this.lblStartColor);
            this.groupBox1.Controls.Add(this.rdoStaticColor);
            this.groupBox1.Controls.Add(this.lblStaticColor);
            this.groupBox1.Controls.Add(this.rdoColorLerp);
            this.groupBox1.Controls.Add(this.btnStaticColor);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 168);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Options";
            // 
            // txtAlphaChange
            // 
            this.txtAlphaChange.Location = new System.Drawing.Point(103, 136);
            this.txtAlphaChange.Name = "txtAlphaChange";
            this.txtAlphaChange.Size = new System.Drawing.Size(35, 20);
            this.txtAlphaChange.TabIndex = 13;
            this.txtAlphaChange.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Alpha Change (float)";
            // 
            // txtAlphaStart
            // 
            this.txtAlphaStart.Location = new System.Drawing.Point(6, 136);
            this.txtAlphaStart.Name = "txtAlphaStart";
            this.txtAlphaStart.Size = new System.Drawing.Size(35, 20);
            this.txtAlphaStart.TabIndex = 13;
            this.txtAlphaStart.Text = "1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alpha Start (float)";
            // 
            // btnLerpColorEnd
            // 
            this.btnLerpColorEnd.Location = new System.Drawing.Point(140, 79);
            this.btnLerpColorEnd.Name = "btnLerpColorEnd";
            this.btnLerpColorEnd.Size = new System.Drawing.Size(47, 23);
            this.btnLerpColorEnd.TabIndex = 13;
            this.btnLerpColorEnd.Text = "Select";
            this.btnLerpColorEnd.UseVisualStyleBackColor = true;
            this.btnLerpColorEnd.Visible = false;
            this.btnLerpColorEnd.Click += new System.EventHandler(this.btnLerpColorEnd_Click);
            // 
            // btnLerpColorStart
            // 
            this.btnLerpColorStart.Location = new System.Drawing.Point(6, 79);
            this.btnLerpColorStart.Name = "btnLerpColorStart";
            this.btnLerpColorStart.Size = new System.Drawing.Size(47, 23);
            this.btnLerpColorStart.TabIndex = 13;
            this.btnLerpColorStart.Text = "Select";
            this.btnLerpColorStart.UseVisualStyleBackColor = true;
            this.btnLerpColorStart.Visible = false;
            this.btnLerpColorStart.Click += new System.EventHandler(this.btnLerpColorStart_Click);
            // 
            // lblEndColor
            // 
            this.lblEndColor.AutoSize = true;
            this.lblEndColor.Location = new System.Drawing.Point(143, 63);
            this.lblEndColor.Name = "lblEndColor";
            this.lblEndColor.Size = new System.Drawing.Size(53, 13);
            this.lblEndColor.TabIndex = 13;
            this.lblEndColor.Text = "End Color";
            this.lblEndColor.Visible = false;
            // 
            // lblStartColor
            // 
            this.lblStartColor.AutoSize = true;
            this.lblStartColor.Location = new System.Drawing.Point(3, 63);
            this.lblStartColor.Name = "lblStartColor";
            this.lblStartColor.Size = new System.Drawing.Size(56, 13);
            this.lblStartColor.TabIndex = 13;
            this.lblStartColor.Text = "Start Color";
            this.lblStartColor.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTexturePath);
            this.groupBox2.Controls.Add(this.btnAddTexture);
            this.groupBox2.Controls.Add(this.txtTTL);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtScale);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDeltaRot);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtRot);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(234, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 229);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Render Options";
            // 
            // txtTexturePath
            // 
            this.txtTexturePath.Location = new System.Drawing.Point(7, 175);
            this.txtTexturePath.Name = "txtTexturePath";
            this.txtTexturePath.Size = new System.Drawing.Size(244, 20);
            this.txtTexturePath.TabIndex = 9;
            this.txtTexturePath.TextChanged += new System.EventHandler(this.txtTexturePath_TextChanged);
            // 
            // btnAddTexture
            // 
            this.btnAddTexture.Location = new System.Drawing.Point(6, 145);
            this.btnAddTexture.Name = "btnAddTexture";
            this.btnAddTexture.Size = new System.Drawing.Size(121, 23);
            this.btnAddTexture.TabIndex = 8;
            this.btnAddTexture.Text = "Add Texture...";
            this.btnAddTexture.UseVisualStyleBackColor = true;
            this.btnAddTexture.Click += new System.EventHandler(this.btnAddTexture_Click);
            // 
            // txtTTL
            // 
            this.txtTTL.Location = new System.Drawing.Point(9, 119);
            this.txtTTL.Name = "txtTTL";
            this.txtTTL.Size = new System.Drawing.Size(100, 20);
            this.txtTTL.TabIndex = 7;
            this.txtTTL.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "TTL";
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(9, 80);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(100, 20);
            this.txtScale.TabIndex = 5;
            this.txtScale.Text = "1.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Scale";
            // 
            // txtDeltaRot
            // 
            this.txtDeltaRot.Location = new System.Drawing.Point(138, 32);
            this.txtDeltaRot.Name = "txtDeltaRot";
            this.txtDeltaRot.Size = new System.Drawing.Size(37, 20);
            this.txtDeltaRot.TabIndex = 3;
            this.txtDeltaRot.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Delta Rotation (Radians)";
            // 
            // txtRot
            // 
            this.txtRot.Location = new System.Drawing.Point(9, 32);
            this.txtRot.Name = "txtRot";
            this.txtRot.Size = new System.Drawing.Size(37, 20);
            this.txtRot.TabIndex = 1;
            this.txtRot.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Initial Rotation (Radians)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtMaxVelY);
            this.groupBox3.Controls.Add(this.txtStartVelY);
            this.groupBox3.Controls.Add(this.txtMaxVelX);
            this.groupBox3.Controls.Add(this.lblMaxVelocity);
            this.groupBox3.Controls.Add(this.lblStartVelocity);
            this.groupBox3.Controls.Add(this.txtStartVelX);
            this.groupBox3.Controls.Add(this.rdoVelRange);
            this.groupBox3.Controls.Add(this.rdoStaticVel);
            this.groupBox3.Location = new System.Drawing.Point(234, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 235);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Newtonian Physics";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMaxAccel);
            this.groupBox4.Controls.Add(this.rdoStaticAccel);
            this.groupBox4.Controls.Add(this.txtStaticAccelY);
            this.groupBox4.Controls.Add(this.lblStartAccel);
            this.groupBox4.Controls.Add(this.txtStaticAccelX);
            this.groupBox4.Controls.Add(this.rdoRangeAccel);
            this.groupBox4.Controls.Add(this.txtAccelRangeX);
            this.groupBox4.Controls.Add(this.txtAccelRangeY);
            this.groupBox4.Location = new System.Drawing.Point(9, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(264, 125);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acceleration";
            // 
            // lblMaxAccel
            // 
            this.lblMaxAccel.AutoSize = true;
            this.lblMaxAccel.Location = new System.Drawing.Point(123, 55);
            this.lblMaxAccel.Name = "lblMaxAccel";
            this.lblMaxAccel.Size = new System.Drawing.Size(57, 13);
            this.lblMaxAccel.TabIndex = 13;
            this.lblMaxAccel.Text = "Max Accel";
            this.lblMaxAccel.Visible = false;
            // 
            // rdoStaticAccel
            // 
            this.rdoStaticAccel.AutoSize = true;
            this.rdoStaticAccel.Checked = true;
            this.rdoStaticAccel.Location = new System.Drawing.Point(6, 30);
            this.rdoStaticAccel.Name = "rdoStaticAccel";
            this.rdoStaticAccel.Size = new System.Drawing.Size(114, 17);
            this.rdoStaticAccel.TabIndex = 8;
            this.rdoStaticAccel.TabStop = true;
            this.rdoStaticAccel.Text = "Static Acceleration";
            this.rdoStaticAccel.UseVisualStyleBackColor = true;
            this.rdoStaticAccel.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // lblStartAccel
            // 
            this.lblStartAccel.AutoSize = true;
            this.lblStartAccel.Location = new System.Drawing.Point(2, 55);
            this.lblStartAccel.Name = "lblStartAccel";
            this.lblStartAccel.Size = new System.Drawing.Size(59, 13);
            this.lblStartAccel.TabIndex = 12;
            this.lblStartAccel.Text = "Start Accel";
            // 
            // rdoRangeAccel
            // 
            this.rdoRangeAccel.AutoSize = true;
            this.rdoRangeAccel.Location = new System.Drawing.Point(126, 30);
            this.rdoRangeAccel.Name = "rdoRangeAccel";
            this.rdoRangeAccel.Size = new System.Drawing.Size(119, 17);
            this.rdoRangeAccel.TabIndex = 9;
            this.rdoRangeAccel.Text = "Acceleration Range";
            this.rdoRangeAccel.UseVisualStyleBackColor = true;
            this.rdoRangeAccel.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // txtAccelRangeX
            // 
            this.txtAccelRangeX.Location = new System.Drawing.Point(123, 74);
            this.txtAccelRangeX.Name = "txtAccelRangeX";
            this.txtAccelRangeX.Size = new System.Drawing.Size(53, 20);
            this.txtAccelRangeX.TabIndex = 11;
            this.txtAccelRangeX.Visible = false;
            // 
            // txtAccelRangeY
            // 
            this.txtAccelRangeY.Location = new System.Drawing.Point(182, 74);
            this.txtAccelRangeY.Name = "txtAccelRangeY";
            this.txtAccelRangeY.Size = new System.Drawing.Size(53, 20);
            this.txtAccelRangeY.TabIndex = 10;
            this.txtAccelRangeY.Visible = false;
            // 
            // txtMaxVelY
            // 
            this.txtMaxVelY.Location = new System.Drawing.Point(172, 63);
            this.txtMaxVelY.Name = "txtMaxVelY";
            this.txtMaxVelY.Size = new System.Drawing.Size(51, 20);
            this.txtMaxVelY.TabIndex = 7;
            this.txtMaxVelY.Visible = false;
            // 
            // txtStartVelY
            // 
            this.txtStartVelY.Location = new System.Drawing.Point(59, 63);
            this.txtStartVelY.Name = "txtStartVelY";
            this.txtStartVelY.Size = new System.Drawing.Size(47, 20);
            this.txtStartVelY.TabIndex = 6;
            this.txtStartVelY.Text = "0";
            // 
            // txtMaxVelX
            // 
            this.txtMaxVelX.Location = new System.Drawing.Point(115, 63);
            this.txtMaxVelX.Name = "txtMaxVelX";
            this.txtMaxVelX.Size = new System.Drawing.Size(51, 20);
            this.txtMaxVelX.TabIndex = 5;
            this.txtMaxVelX.Visible = false;
            // 
            // lblMaxVelocity
            // 
            this.lblMaxVelocity.AutoSize = true;
            this.lblMaxVelocity.Location = new System.Drawing.Point(112, 47);
            this.lblMaxVelocity.Name = "lblMaxVelocity";
            this.lblMaxVelocity.Size = new System.Drawing.Size(67, 13);
            this.lblMaxVelocity.TabIndex = 4;
            this.lblMaxVelocity.Text = "Max Velocity";
            this.lblMaxVelocity.Visible = false;
            // 
            // lblStartVelocity
            // 
            this.lblStartVelocity.AutoSize = true;
            this.lblStartVelocity.Location = new System.Drawing.Point(6, 47);
            this.lblStartVelocity.Name = "lblStartVelocity";
            this.lblStartVelocity.Size = new System.Drawing.Size(69, 13);
            this.lblStartVelocity.TabIndex = 3;
            this.lblStartVelocity.Text = "Start Velocity";
            // 
            // txtStartVelX
            // 
            this.txtStartVelX.Location = new System.Drawing.Point(6, 63);
            this.txtStartVelX.Name = "txtStartVelX";
            this.txtStartVelX.Size = new System.Drawing.Size(47, 20);
            this.txtStartVelX.TabIndex = 2;
            this.txtStartVelX.Text = "0";
            // 
            // rdoVelRange
            // 
            this.rdoVelRange.AutoSize = true;
            this.rdoVelRange.Location = new System.Drawing.Point(104, 19);
            this.rdoVelRange.Name = "rdoVelRange";
            this.rdoVelRange.Size = new System.Drawing.Size(97, 17);
            this.rdoVelRange.TabIndex = 1;
            this.rdoVelRange.Text = "Velocity Range";
            this.rdoVelRange.UseVisualStyleBackColor = true;
            this.rdoVelRange.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdoStaticVel
            // 
            this.rdoStaticVel.AutoSize = true;
            this.rdoStaticVel.Checked = true;
            this.rdoStaticVel.Location = new System.Drawing.Point(6, 19);
            this.rdoStaticVel.Name = "rdoStaticVel";
            this.rdoStaticVel.Size = new System.Drawing.Size(92, 17);
            this.rdoStaticVel.TabIndex = 0;
            this.rdoStaticVel.TabStop = true;
            this.rdoStaticVel.Text = "Static Velocity";
            this.rdoStaticVel.UseVisualStyleBackColor = true;
            this.rdoStaticVel.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddParticleDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "AddParticleDlg";
            this.Text = "Add Particle";
            this.Load += new System.EventHandler(this.AddParticleDlg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStaticAccelX;
        private System.Windows.Forms.TextBox txtStaticAccelY;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnStaticColor;
        private System.Windows.Forms.Label lblStaticColor;
        private System.Windows.Forms.RadioButton rdoStaticColor;
        private System.Windows.Forms.RadioButton rdoColorLerp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLerpColorEnd;
        private System.Windows.Forms.Button btnLerpColorStart;
        private System.Windows.Forms.Label lblEndColor;
        private System.Windows.Forms.Label lblStartColor;
        private System.Windows.Forms.TextBox txtAlphaChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAlphaStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDeltaRot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMaxVelX;
        private System.Windows.Forms.Label lblMaxVelocity;
        private System.Windows.Forms.Label lblStartVelocity;
        private System.Windows.Forms.TextBox txtStartVelX;
        private System.Windows.Forms.RadioButton rdoVelRange;
        private System.Windows.Forms.RadioButton rdoStaticVel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtMaxVelY;
        private System.Windows.Forms.TextBox txtStartVelY;
        private System.Windows.Forms.TextBox txtTTL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTexturePath;
        private System.Windows.Forms.Button btnAddTexture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rdoRangeAccel;
        private System.Windows.Forms.RadioButton rdoStaticAccel;
        private System.Windows.Forms.TextBox txtAccelRangeX;
        private System.Windows.Forms.TextBox txtAccelRangeY;
        private System.Windows.Forms.Label lblMaxAccel;
        private System.Windows.Forms.Label lblStartAccel;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}