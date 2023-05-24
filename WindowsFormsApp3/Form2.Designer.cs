namespace WindowsFormsApp3
{
    partial class Form2
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
            this.btnaddpt = new System.Windows.Forms.Button();
            this.btnAddstaf = new System.Windows.Forms.Button();
            this.btnhistory = new System.Windows.Forms.Button();
            this.btnhostinfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelconter2 = new System.Windows.Forms.Label();
            this.labelconter3 = new System.Windows.Forms.Label();
            this.labelconter4 = new System.Windows.Forms.Label();
            this.labelconter1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaddpt
            // 
            this.btnaddpt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnaddpt.Location = new System.Drawing.Point(52, 57);
            this.btnaddpt.Name = "btnaddpt";
            this.btnaddpt.Size = new System.Drawing.Size(177, 72);
            this.btnaddpt.TabIndex = 0;
            this.btnaddpt.Text = "Add new Patient";
            this.btnaddpt.UseVisualStyleBackColor = false;
            this.btnaddpt.Click += new System.EventHandler(this.btnaddpt_Click);
            // 
            // btnAddstaf
            // 
            this.btnAddstaf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddstaf.Location = new System.Drawing.Point(52, 123);
            this.btnAddstaf.Name = "btnAddstaf";
            this.btnAddstaf.Size = new System.Drawing.Size(177, 72);
            this.btnAddstaf.TabIndex = 1;
            this.btnAddstaf.Text = "Add staf information";
            this.btnAddstaf.UseVisualStyleBackColor = false;
            this.btnAddstaf.Click += new System.EventHandler(this.btnAddstaf_Click);
            // 
            // btnhistory
            // 
            this.btnhistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhistory.Location = new System.Drawing.Point(52, 184);
            this.btnhistory.Name = "btnhistory";
            this.btnhistory.Size = new System.Drawing.Size(177, 72);
            this.btnhistory.TabIndex = 2;
            this.btnhistory.Text = "History of the Patient";
            this.btnhistory.UseVisualStyleBackColor = false;
            this.btnhistory.Click += new System.EventHandler(this.btnhistory_Click);
            // 
            // btnhostinfo
            // 
            this.btnhostinfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnhostinfo.Location = new System.Drawing.Point(52, 236);
            this.btnhostinfo.Name = "btnhostinfo";
            this.btnhostinfo.Size = new System.Drawing.Size(177, 72);
            this.btnhostinfo.TabIndex = 3;
            this.btnhostinfo.Text = "Hospital information ";
            this.btnhostinfo.UseVisualStyleBackColor = false;
            this.btnhostinfo.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "CONTROLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(681, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Health Care";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.LightCoral;
            this.btnexit.Location = new System.Drawing.Point(82, 311);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(88, 47);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp3.Properties.Resources.lifeline_heartbeat1;
            this.pictureBox2.Location = new System.Drawing.Point(1, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(377, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.pexels_jonathan_meyer_668300;
            this.pictureBox1.Location = new System.Drawing.Point(384, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(794, 534);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // labelconter2
            // 
            this.labelconter2.AutoSize = true;
            this.labelconter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconter2.Location = new System.Drawing.Point(-6, 132);
            this.labelconter2.Name = "labelconter2";
            this.labelconter2.Size = new System.Drawing.Size(62, 42);
            this.labelconter2.TabIndex = 10;
            this.labelconter2.Text = "»»";
            // 
            // labelconter3
            // 
            this.labelconter3.AutoSize = true;
            this.labelconter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconter3.Location = new System.Drawing.Point(-6, 196);
            this.labelconter3.Name = "labelconter3";
            this.labelconter3.Size = new System.Drawing.Size(62, 42);
            this.labelconter3.TabIndex = 11;
            this.labelconter3.Text = "»»";
            // 
            // labelconter4
            // 
            this.labelconter4.AutoSize = true;
            this.labelconter4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconter4.Location = new System.Drawing.Point(-6, 250);
            this.labelconter4.Name = "labelconter4";
            this.labelconter4.Size = new System.Drawing.Size(62, 42);
            this.labelconter4.TabIndex = 12;
            this.labelconter4.Text = "»»";
            // 
            // labelconter1
            // 
            this.labelconter1.AutoSize = true;
            this.labelconter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconter1.Location = new System.Drawing.Point(-6, 65);
            this.labelconter1.Name = "labelconter1";
            this.labelconter1.Size = new System.Drawing.Size(62, 42);
            this.labelconter1.TabIndex = 13;
            this.labelconter1.Text = "»»";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 631);
            this.Controls.Add(this.labelconter1);
            this.Controls.Add(this.labelconter4);
            this.Controls.Add(this.labelconter3);
            this.Controls.Add(this.labelconter2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhostinfo);
            this.Controls.Add(this.btnhistory);
            this.Controls.Add(this.btnAddstaf);
            this.Controls.Add(this.btnaddpt);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddpt;
        private System.Windows.Forms.Button btnAddstaf;
        private System.Windows.Forms.Button btnhistory;
        private System.Windows.Forms.Button btnhostinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelconter2;
        private System.Windows.Forms.Label labelconter3;
        private System.Windows.Forms.Label labelconter4;
        private System.Windows.Forms.Label labelconter1;
    }
}