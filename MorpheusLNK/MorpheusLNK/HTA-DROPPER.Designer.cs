namespace MorpheusLNK
{
    partial class HTA_DROPPER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HTA_DROPPER));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.afterExe_Name = new System.Windows.Forms.TextBox();
            this.htaBuild_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.downloadUrl_Box = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "HTA-BUILDER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(80, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "After Download Name";
            // 
            // afterExe_Name
            // 
            this.afterExe_Name.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.afterExe_Name.Location = new System.Drawing.Point(18, 218);
            this.afterExe_Name.Multiline = true;
            this.afterExe_Name.Name = "afterExe_Name";
            this.afterExe_Name.Size = new System.Drawing.Size(370, 27);
            this.afterExe_Name.TabIndex = 14;
            this.afterExe_Name.Text = "LNKBUILD.exe";
            this.afterExe_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // htaBuild_btn
            // 
            this.htaBuild_btn.BackColor = System.Drawing.Color.Black;
            this.htaBuild_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.htaBuild_btn.FlatAppearance.BorderSize = 0;
            this.htaBuild_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.htaBuild_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.htaBuild_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htaBuild_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htaBuild_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.htaBuild_btn.Location = new System.Drawing.Point(517, 408);
            this.htaBuild_btn.Name = "htaBuild_btn";
            this.htaBuild_btn.Size = new System.Drawing.Size(205, 30);
            this.htaBuild_btn.TabIndex = 13;
            this.htaBuild_btn.Text = "BUILD";
            this.htaBuild_btn.UseVisualStyleBackColor = false;
            this.htaBuild_btn.Click += new System.EventHandler(this.HtaBuild_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Payload url";
            // 
            // downloadUrl_Box
            // 
            this.downloadUrl_Box.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.downloadUrl_Box.Location = new System.Drawing.Point(18, 138);
            this.downloadUrl_Box.Multiline = true;
            this.downloadUrl_Box.Name = "downloadUrl_Box";
            this.downloadUrl_Box.Size = new System.Drawing.Size(370, 27);
            this.downloadUrl_Box.TabIndex = 11;
            this.downloadUrl_Box.Text = "payload-url";
            this.downloadUrl_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(12, 423);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 18);
            this.statusLabel.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MorpheusLNK.Properties.Resources.noback;
            this.pictureBox1.Location = new System.Drawing.Point(418, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // HTA_DROPPER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.afterExe_Name);
            this.Controls.Add(this.htaBuild_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.downloadUrl_Box);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HTA_DROPPER";
            this.Text = "HTA_DROPPER";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox afterExe_Name;
        private System.Windows.Forms.Button htaBuild_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox downloadUrl_Box;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}