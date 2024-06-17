using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SteamConnectionBlocker
{
    public partial class Mainform : MaterialForm
    {
        public bool isConnectionBlocked = false;
        public Mainform()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue100, TextShade.WHITE);
        }

        private async void switch_blockConnection_CheckedChanged(object sender, System.EventArgs e)
        {
            isConnectionBlocked = !isConnectionBlocked;
            await myFuncs.blockConnection(isConnectionBlocked);
            
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by NightfallCT");
        }
    }

    public class myFuncs
    {
        public static async Task blockConnection(bool isBlocked)
        {
            string tempFile = Path.GetTempFileName() + ".bat";

            if (isBlocked)
            {
                string blockCmd = @"netsh advfirewall firewall add rule name=""_02 Block steam(Program)"" dir=in program=""C:\Program Files (x86)\Steam\bin\cef\cef.win7x64\steamwebhelper.exe"" action=block
netsh advfirewall firewall add rule name=""_01 Block steam(Program)"" dir=in program=""C:\Program Files (x86)\Steam\steam.exe"" action=block
netsh advfirewall firewall add rule name=""_02 Block steam(Program)"" dir=out program=""C:\Program Files (x86)\Steam\bin\cef\cef.win7x64\steamwebhelper.exe"" action=block
netsh advfirewall firewall add rule name=""_01 Block steam(Program)"" dir=out program=""C:\Program Files (x86)\Steam\steam.exe"" action=block";
                File.WriteAllText(tempFile, blockCmd);
            }
            else
            {
                string freeCmd = @"netsh advfirewall firewall set rule name=\""_01 Block steam(Program)\"" new enable=no
netsh advfirewall firewall set rule name=\""_02 Block steam(Program)\"" new enable=no
netsh advfirewall firewall delete rule name=""_01 Block steam(Program)
netsh advfirewall firewall delete rule name=""_02 Block steam(Program)""";

                File.WriteAllText(tempFile, freeCmd);
            }

            var process = new Process();
            var startInfo = new ProcessStartInfo
            {
                FileName = tempFile,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false
            };
            process.StartInfo = startInfo;
            process.Start();

            // Handle output and error streams
            await Task.WhenAll(
                Task.Run(() => process.StandardOutput.ReadToEndAsync()),
                Task.Run(() => process.StandardError.ReadToEndAsync()),
                Task.Run(() => process.WaitForExit())
            );

            File.Delete(tempFile);
        }

    }
}
