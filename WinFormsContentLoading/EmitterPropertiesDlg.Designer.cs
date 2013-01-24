namespace WinFormsContentLoading
{
    partial class EmitterPropertiesDlg
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaxAngle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMinAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaxSpeedY = new System.Windows.Forms.TextBox();
            this.txtMinSpeedY = new System.Windows.Forms.TextBox();
            this.txtMaxSpeedX = new System.Windows.Forms.TextBox();
            this.txtMinSpeedX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtParticlesPerUpdate = new System.Windows.Forms.TextBox();
            this.txtMaxParticles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtMaxOffsetY = new System.Windows.Forms.TextBox();
            this.txtMinOffsetX = new System.Windows.Forms.TextBox();
            this.txtMaxOffsetX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinOffsetY = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMaxAccelY = new System.Windows.Forms.TextBox();
            this.txtMaxAccelX = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMinAccelY = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMinAccelX = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaxAngle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMinAngle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emission Angle Rotations";
            // 
            // txtMaxAngle
            // 
            this.txtMaxAngle.Enabled = false;
            this.txtMaxAngle.Location = new System.Drawing.Point(85, 32);
            this.txtMaxAngle.Name = "txtMaxAngle";
            this.txtMaxAngle.Size = new System.Drawing.Size(51, 20);
            this.txtMaxAngle.TabIndex = 2;
            this.txtMaxAngle.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(82, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Maximum Angle";
            // 
            // txtMinAngle
            // 
            this.txtMinAngle.Enabled = false;
            this.txtMinAngle.Location = new System.Drawing.Point(9, 32);
            this.txtMinAngle.Name = "txtMinAngle";
            this.txtMinAngle.Size = new System.Drawing.Size(51, 20);
            this.txtMinAngle.TabIndex = 1;
            this.txtMinAngle.Text = "0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Min Angle";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaxSpeedY);
            this.groupBox2.Controls.Add(this.txtMinSpeedY);
            this.groupBox2.Controls.Add(this.txtMaxSpeedX);
            this.groupBox2.Controls.Add(this.txtMinSpeedX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Velocity";
            // 
            // txtMaxSpeedY
            // 
            this.txtMaxSpeedY.Location = new System.Drawing.Point(150, 33);
            this.txtMaxSpeedY.Name = "txtMaxSpeedY";
            this.txtMaxSpeedY.Size = new System.Drawing.Size(40, 20);
            this.txtMaxSpeedY.TabIndex = 3;
            this.txtMaxSpeedY.Text = "0.0";
            // 
            // txtMinSpeedY
            // 
            this.txtMinSpeedY.Location = new System.Drawing.Point(55, 33);
            this.txtMinSpeedY.Name = "txtMinSpeedY";
            this.txtMinSpeedY.Size = new System.Drawing.Size(40, 20);
            this.txtMinSpeedY.TabIndex = 4;
            this.txtMinSpeedY.Text = "0.0";
            // 
            // txtMaxSpeedX
            // 
            this.txtMaxSpeedX.Location = new System.Drawing.Point(104, 33);
            this.txtMaxSpeedX.Name = "txtMaxSpeedX";
            this.txtMaxSpeedX.Size = new System.Drawing.Size(40, 20);
            this.txtMaxSpeedX.TabIndex = 2;
            this.txtMaxSpeedX.Text = "0.0";
            // 
            // txtMinSpeedX
            // 
            this.txtMinSpeedX.Location = new System.Drawing.Point(9, 33);
            this.txtMinSpeedX.Name = "txtMinSpeedX";
            this.txtMinSpeedX.Size = new System.Drawing.Size(40, 20);
            this.txtMinSpeedX.TabIndex = 3;
            this.txtMinSpeedX.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Max Velocity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Min Velocity";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtParticlesPerUpdate);
            this.groupBox3.Controls.Add(this.txtMaxParticles);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 69);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emission Control";
            // 
            // txtParticlesPerUpdate
            // 
            this.txtParticlesPerUpdate.Location = new System.Drawing.Point(93, 32);
            this.txtParticlesPerUpdate.Name = "txtParticlesPerUpdate";
            this.txtParticlesPerUpdate.Size = new System.Drawing.Size(55, 20);
            this.txtParticlesPerUpdate.TabIndex = 3;
            this.txtParticlesPerUpdate.Text = "30";
            // 
            // txtMaxParticles
            // 
            this.txtMaxParticles.Location = new System.Drawing.Point(9, 32);
            this.txtMaxParticles.Name = "txtMaxParticles";
            this.txtMaxParticles.Size = new System.Drawing.Size(55, 20);
            this.txtMaxParticles.TabIndex = 3;
            this.txtMaxParticles.Text = "30";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Particles Per Update";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Max Particles";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtMaxOffsetY);
            this.groupBox4.Controls.Add(this.txtMinOffsetX);
            this.groupBox4.Controls.Add(this.txtMaxOffsetX);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtMinOffsetY);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(218, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 78);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Offset At Spawn";
            // 
            // txtMaxOffsetY
            // 
            this.txtMaxOffsetY.Location = new System.Drawing.Point(149, 32);
            this.txtMaxOffsetY.Name = "txtMaxOffsetY";
            this.txtMaxOffsetY.Size = new System.Drawing.Size(39, 20);
            this.txtMaxOffsetY.TabIndex = 6;
            this.txtMaxOffsetY.Text = "0";
            // 
            // txtMinOffsetX
            // 
            this.txtMinOffsetX.Location = new System.Drawing.Point(9, 32);
            this.txtMinOffsetX.Name = "txtMinOffsetX";
            this.txtMinOffsetX.Size = new System.Drawing.Size(39, 20);
            this.txtMinOffsetX.TabIndex = 7;
            this.txtMinOffsetX.Text = "0";
            // 
            // txtMaxOffsetX
            // 
            this.txtMaxOffsetX.Location = new System.Drawing.Point(104, 32);
            this.txtMaxOffsetX.Name = "txtMaxOffsetX";
            this.txtMaxOffsetX.Size = new System.Drawing.Size(39, 20);
            this.txtMaxOffsetX.TabIndex = 5;
            this.txtMaxOffsetX.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Maximum Offset";
            // 
            // txtMinOffsetY
            // 
            this.txtMinOffsetY.Location = new System.Drawing.Point(54, 32);
            this.txtMinOffsetY.Name = "txtMinOffsetY";
            this.txtMinOffsetY.Size = new System.Drawing.Size(39, 20);
            this.txtMinOffsetY.TabIndex = 4;
            this.txtMinOffsetY.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Minimum Offset";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMaxAccelY);
            this.groupBox5.Controls.Add(this.txtMaxAccelX);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtMinAccelY);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtMinAccelX);
            this.groupBox5.Location = new System.Drawing.Point(218, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Acceleration";
            // 
            // txtMaxAccelY
            // 
            this.txtMaxAccelY.Location = new System.Drawing.Point(54, 72);
            this.txtMaxAccelY.Name = "txtMaxAccelY";
            this.txtMaxAccelY.Size = new System.Drawing.Size(39, 20);
            this.txtMaxAccelY.TabIndex = 6;
            this.txtMaxAccelY.Text = "0";
            // 
            // txtMaxAccelX
            // 
            this.txtMaxAccelX.Location = new System.Drawing.Point(9, 72);
            this.txtMaxAccelX.Name = "txtMaxAccelX";
            this.txtMaxAccelX.Size = new System.Drawing.Size(39, 20);
            this.txtMaxAccelX.TabIndex = 8;
            this.txtMaxAccelX.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Maximum Acceleration";
            // 
            // txtMinAccelY
            // 
            this.txtMinAccelY.Location = new System.Drawing.Point(54, 33);
            this.txtMinAccelY.Name = "txtMinAccelY";
            this.txtMinAccelY.Size = new System.Drawing.Size(39, 20);
            this.txtMinAccelY.TabIndex = 7;
            this.txtMinAccelY.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Minimum Acceleration";
            // 
            // txtMinAccelX
            // 
            this.txtMinAccelX.Location = new System.Drawing.Point(9, 33);
            this.txtMinAccelX.Name = "txtMinAccelX";
            this.txtMinAccelX.Size = new System.Drawing.Size(39, 20);
            this.txtMinAccelX.TabIndex = 5;
            this.txtMinAccelX.Text = "0";
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSubmit.Location = new System.Drawing.Point(352, 318);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(272, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EmitterPropertiesDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 353);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmitterPropertiesDlg";
            this.Text = "EmitterPropertiesDlg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaxAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMinAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMaxSpeedY;
        private System.Windows.Forms.TextBox txtMinSpeedY;
        private System.Windows.Forms.TextBox txtMaxSpeedX;
        private System.Windows.Forms.TextBox txtMinSpeedX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtParticlesPerUpdate;
        private System.Windows.Forms.TextBox txtMaxParticles;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtMaxOffsetY;
        private System.Windows.Forms.TextBox txtMinOffsetX;
        private System.Windows.Forms.TextBox txtMaxOffsetX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinOffsetY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtMaxAccelY;
        private System.Windows.Forms.TextBox txtMaxAccelX;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMinAccelY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMinAccelX;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}