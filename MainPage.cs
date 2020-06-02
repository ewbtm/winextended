using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace WinExtended
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            string batpath = @"C:\Windows\System32\wext.bat";
            string progpath = System.Reflection.Assembly.GetExecutingAssembly().Location.ToString();

            // Check if bat file exists, if no, then create it.
            if (!File.Exists(batpath))
            {
                File.Create(batpath);
            }
            else
            {
                // Create special BAT, which on special mode will run program again.
                string[] batinternal = { "@echo Programm running. Please don't close this window until finish.", progpath };
                File.WriteAllLines(batpath, batinternal);
            }

            // Get registry key of Setup
            RegistryKey privstat = Registry.LocalMachine.OpenSubKey(@"SYSTEM\\Setup", true);
            restartbtn.Hide();

            if(privstat != null)
            {
                string cmdline = privstat.GetValue("CmdLine").ToString();
                string setuptype = privstat.GetValue("SetupType").ToString();
                if (cmdline == " " && setuptype == "0")
                {
                    fullstatus.Text = "Privilegies is off.";
                    button2.Hide();
                    button1.Show();
                }
                else if (cmdline == "wext.bat" && setuptype == "2")
                {
                    fullstatus.Text = "Privilegies is on.";
                    button1.Hide();
                    button2.Show();
                }
            }
        }

        private void cmdbtn_Click(object sender, EventArgs e)
        {
            string cmd = "cmd.exe";

            var proc = new ProcessStartInfo()
            {
                UseShellExecute = true,
                WorkingDirectory = @"C:\Windows\System32",
                FileName = @"C:\Windows\system32\cmd.exe",
                Arguments = "/c" + cmd,
                WindowStyle = ProcessWindowStyle.Normal
            };

            Process.Start(proc);
        }

        private void pwbtn_Click(object sender, EventArgs e)
        {
            string cmd = "powershell.exe";

            var proc = new ProcessStartInfo()
            {
                UseShellExecute = true,
                WorkingDirectory = @"C:\Windows\System32",
                FileName = @"C:\Windows\system32\WindowsPowershell\v1.0\powershell.exe",
                Arguments = "/c" + cmd,
                WindowStyle = ProcessWindowStyle.Normal
            };

            Process.Start(proc);
        }

        private void taskmgrbtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\System32\taskmgr.exe");
        }

        private void regeditbtn_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Windows\regedit.exe");
        }

        private void button1_Click_1(object sender, EventArgs e) // Privilegies give
        {
            RegistryKey privmode = Registry.LocalMachine.OpenSubKey(@"SYSTEM\\Setup", true);

            // var pathloc = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string cmdline = "wext.bat";
            privmode.SetValue("CmdLine", cmdline);
            privmode.SetValue("SetupType", 2, RegistryValueKind.DWord);
            privmode.Close();

            fullstatus.Text = "Privilegies is on. Restart for access mode.";
            aboutBtn.Hide();
            restartbtn.Show();
            button1.Hide();
            button2.Show();
        }

        private void button2_Click(object sender, EventArgs e) // Privilegies delete
        {
            RegistryKey privmode = Registry.LocalMachine.OpenSubKey(@"SYSTEM\\Setup", true);
            
            privmode.SetValue("CmdLine", " ");
            privmode.SetValue("SetupType", 0, RegistryValueKind.DWord);
            privmode.Close();

            fullstatus.Text = "Privilegies is off.";

            aboutBtn.Hide();
            button2.Hide();
            button1.Show();
        }

        private void restartbtn_Click(object sender, EventArgs e) // Restart PC
        {
            var proc = new ProcessStartInfo()
            
            {
                UseShellExecute = true,
                WorkingDirectory = @"C:\Windows\System32",
                FileName = @"C:\Windows\system32\cmd.exe",
                Arguments = "shutdown /r /t 0",
                WindowStyle = ProcessWindowStyle.Normal
            };

            Process.Start(proc);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closebtn_Click_1(object sender, EventArgs e) // Working THIS
        {
            Application.Exit();
        }

        private void restartbtn_Click_1(object sender, EventArgs e) // Working THIS
        {
            this.Close();
            MainPage mp = new MainPage();
            mp.Show();
        }

        private void authorlink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.instagr.am/EWBTM");
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void authorlink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.instagr.am/EWBTM");
        }

        private void githublink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.github.com/ewbtm/winextended/");
        }
    }
}
