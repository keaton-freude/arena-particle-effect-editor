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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEndAlpha = new System.Windows.Forms.TextBox();
            this.txtAlphaStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLerpColorEnd = new System.Windows.Forms.Button();
            this.btnLerpColorStart = new System.Windows.Forms.Button();
            this.lblEndColor = new System.Windows.Forms.Label();
            this.lblStartColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblMaxTTL = new System.Windows.Forms.Label();
            this.txtMaxLife = new System.Windows.Forms.TextBox();
            this.txtMinLife = new System.Windows.Forms.TextBox();
            this.lblMinTTL = new System.Windows.Forms.Label();
            this.txtTexturePath = new System.Windows.Forms.TextBox();
            this.btnAddTexture = new System.Windows.Forms.Button();
            this.txtScale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeltaRot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pctStartColor = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pctEndColor = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScaleEnd = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctStartColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEndColor)).BeginInit();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEndAlpha);
            this.groupBox1.Controls.Add(this.txtAlphaStart);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnLerpColorEnd);
            this.groupBox1.Controls.Add(this.btnLerpColorStart);
            this.groupBox1.Controls.Add(this.lblEndColor);
            this.groupBox1.Controls.Add(this.lblStartColor);
            this.groupBox1.Location = new System.Drawing.Point(15, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 136);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color Options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "End Alpha";
            // 
            // txtEndAlpha
            // 
            this.txtEndAlpha.Location = new System.Drawing.Point(97, 82);
            this.txtEndAlpha.Name = "txtEndAlpha";
            this.txtEndAlpha.Size = new System.Drawing.Size(35, 20);
            this.txtEndAlpha.TabIndex = 14;
            this.txtEndAlpha.Text = "1.0";
            // 
            // txtAlphaStart
            // 
            this.txtAlphaStart.Location = new System.Drawing.Point(6, 79);
            this.txtAlphaStart.Name = "txtAlphaStart";
            this.txtAlphaStart.Size = new System.Drawing.Size(35, 20);
            this.txtAlphaStart.TabIndex = 13;
            this.txtAlphaStart.Text = "1.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Alpha Start (float)";
            // 
            // btnLerpColorEnd
            // 
            this.btnLerpColorEnd.Location = new System.Drawing.Point(97, 32);
            this.btnLerpColorEnd.Name = "btnLerpColorEnd";
            this.btnLerpColorEnd.Size = new System.Drawing.Size(47, 23);
            this.btnLerpColorEnd.TabIndex = 13;
            this.btnLerpColorEnd.Text = "Select";
            this.btnLerpColorEnd.UseVisualStyleBackColor = true;
            this.btnLerpColorEnd.Click += new System.EventHandler(this.btnLerpColorEnd_Click);
            // 
            // btnLerpColorStart
            // 
            this.btnLerpColorStart.Location = new System.Drawing.Point(9, 32);
            this.btnLerpColorStart.Name = "btnLerpColorStart";
            this.btnLerpColorStart.Size = new System.Drawing.Size(47, 23);
            this.btnLerpColorStart.TabIndex = 13;
            this.btnLerpColorStart.Text = "Select";
            this.btnLerpColorStart.UseVisualStyleBackColor = true;
            this.btnLerpColorStart.Click += new System.EventHandler(this.btnLerpColorStart_Click);
            // 
            // lblEndColor
            // 
            this.lblEndColor.AutoSize = true;
            this.lblEndColor.Location = new System.Drawing.Point(100, 16);
            this.lblEndColor.Name = "lblEndColor";
            this.lblEndColor.Size = new System.Drawing.Size(53, 13);
            this.lblEndColor.TabIndex = 13;
            this.lblEndColor.Text = "End Color";
            // 
            // lblStartColor
            // 
            this.lblStartColor.AutoSize = true;
            this.lblStartColor.Location = new System.Drawing.Point(6, 16);
            this.lblStartColor.Name = "lblStartColor";
            this.lblStartColor.Size = new System.Drawing.Size(56, 13);
            this.lblStartColor.TabIndex = 13;
            this.lblStartColor.Text = "Start Color";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtScaleEnd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.txtTexturePath);
            this.groupBox2.Controls.Add(this.btnAddTexture);
            this.groupBox2.Controls.Add(this.txtScale);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDeltaRot);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtRot);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(199, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 265);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Render Options";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblMaxTTL);
            this.groupBox5.Controls.Add(this.txtMaxLife);
            this.groupBox5.Controls.Add(this.txtMinLife);
            this.groupBox5.Controls.Add(this.lblMinTTL);
            this.groupBox5.Location = new System.Drawing.Point(9, 105);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 99);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "TTL";
            // 
            // lblMaxTTL
            // 
            this.lblMaxTTL.AutoSize = true;
            this.lblMaxTTL.Location = new System.Drawing.Point(93, 18);
            this.lblMaxTTL.Name = "lblMaxTTL";
            this.lblMaxTTL.Size = new System.Drawing.Size(47, 13);
            this.lblMaxTTL.TabIndex = 9;
            this.lblMaxTTL.Text = "Max Life";
            // 
            // txtMaxLife
            // 
            this.txtMaxLife.Location = new System.Drawing.Point(92, 34);
            this.txtMaxLife.Name = "txtMaxLife";
            this.txtMaxLife.Size = new System.Drawing.Size(52, 20);
            this.txtMaxLife.TabIndex = 8;
            this.txtMaxLife.Text = "2.0";
            // 
            // txtMinLife
            // 
            this.txtMinLife.Location = new System.Drawing.Point(6, 34);
            this.txtMinLife.Name = "txtMinLife";
            this.txtMinLife.Size = new System.Drawing.Size(52, 20);
            this.txtMinLife.TabIndex = 7;
            this.txtMinLife.Text = "2.0";
            // 
            // lblMinTTL
            // 
            this.lblMinTTL.AutoSize = true;
            this.lblMinTTL.Location = new System.Drawing.Point(7, 18);
            this.lblMinTTL.Name = "lblMinTTL";
            this.lblMinTTL.Size = new System.Drawing.Size(44, 13);
            this.lblMinTTL.TabIndex = 6;
            this.lblMinTTL.Text = "Min Life";
            // 
            // txtTexturePath
            // 
            this.txtTexturePath.Location = new System.Drawing.Point(6, 239);
            this.txtTexturePath.Name = "txtTexturePath";
            this.txtTexturePath.Size = new System.Drawing.Size(244, 20);
            this.txtTexturePath.TabIndex = 9;
            this.txtTexturePath.TextChanged += new System.EventHandler(this.txtTexturePath_TextChanged);
            // 
            // btnAddTexture
            // 
            this.btnAddTexture.Location = new System.Drawing.Point(8, 210);
            this.btnAddTexture.Name = "btnAddTexture";
            this.btnAddTexture.Size = new System.Drawing.Size(121, 23);
            this.btnAddTexture.TabIndex = 8;
            this.btnAddTexture.Text = "Add Texture...";
            this.btnAddTexture.UseVisualStyleBackColor = true;
            this.btnAddTexture.Click += new System.EventHandler(this.btnAddTexture_Click);
            // 
            // txtScale
            // 
            this.txtScale.Location = new System.Drawing.Point(9, 80);
            this.txtScale.Name = "txtScale";
            this.txtScale.Size = new System.Drawing.Size(58, 20);
            this.txtScale.TabIndex = 5;
            this.txtScale.Text = "1.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Scale Start";
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Start Color";
            // 
            // pctStartColor
            // 
            this.pctStartColor.BackColor = System.Drawing.SystemColors.Control;
            this.pctStartColor.Location = new System.Drawing.Point(15, 213);
            this.pctStartColor.Name = "pctStartColor";
            this.pctStartColor.Size = new System.Drawing.Size(53, 50);
            this.pctStartColor.TabIndex = 19;
            this.pctStartColor.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(86, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "End Color";
            // 
            // pctEndColor
            // 
            this.pctEndColor.Location = new System.Drawing.Point(89, 213);
            this.pctEndColor.Name = "pctEndColor";
            this.pctEndColor.Size = new System.Drawing.Size(53, 50);
            this.pctEndColor.TabIndex = 21;
            this.pctEndColor.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Scale End";
            // 
            // txtScaleEnd
            // 
            this.txtScaleEnd.Location = new System.Drawing.Point(105, 79);
            this.txtScaleEnd.Name = "txtScaleEnd";
            this.txtScaleEnd.Size = new System.Drawing.Size(53, 20);
            this.txtScaleEnd.TabIndex = 12;
            this.txtScaleEnd.Text = "1.0";
            // 
            // AddParticleDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 360);
            this.Controls.Add(this.pctEndColor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pctStartColor);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctStartColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctEndColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLerpColorEnd;
        private System.Windows.Forms.Button btnLerpColorStart;
        private System.Windows.Forms.Label lblEndColor;
        private System.Windows.Forms.Label lblStartColor;
        private System.Windows.Forms.TextBox txtAlphaStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDeltaRot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtScale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtMinLife;
        private System.Windows.Forms.Label lblMinTTL;
        private System.Windows.Forms.TextBox txtTexturePath;
        private System.Windows.Forms.Button btnAddTexture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblMaxTTL;
        private System.Windows.Forms.TextBox txtMaxLife;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEndAlpha;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pctStartColor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pctEndColor;
        private System.Windows.Forms.TextBox txtScaleEnd;
        private System.Windows.Forms.Label label3;
    }
}