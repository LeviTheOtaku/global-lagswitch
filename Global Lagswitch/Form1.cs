using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mrousavy;
using NetFwTypeLib;

namespace Global_Lagswitch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int id = 0;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Shift, Keys.F.GetHashCode());
        }

        //Hotkey function from: https://www.fluxbytes.com/csharp/how-to-register-a-global-hotkey-for-your-application-in-c/
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF); 
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF); 
                int id = m.WParam.ToInt32();

                if (statusLabel.Text == "Status: Enabled!")
                {
                    off();
                }
                else
                {
                    on();
                }
            }
        }


        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();

        }

        private void lsonButton_Click(object sender, EventArgs e)
        {
            on();
        }

        private void lsoffButton_Click(object sender, EventArgs e)
        {
            off();
        }

        private void on()
        {
            try
            {
                INetFwRule firewallRule = (INetFwRule)Activator.CreateInstance(
                Type.GetTypeFromProgID("HNetCfg.FWRule"));
                firewallRule.Action = NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
                firewallRule.ApplicationName = Process.GetProcessById(Process.GetProcessesByName(processListBox.SelectedItem.ToString())[0].Id).MainModule.FileName;
                firewallRule.Description = "Used by Global Lagswitch.";
                firewallRule.Direction = NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT;
                firewallRule.Enabled = true;
                firewallRule.InterfaceTypes = "All";
                firewallRule.Name = "Global Lagswitch Block";

                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(
                    Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Add(firewallRule);

                statusLabel.Text = "Status: Enabled!";

                Random rnd = new Random();
                int randomval = rnd.Next(6000, 8000);
                Wait(randomval);
                try
                {
                    INetFwPolicy2 firewallPolicy2 = (INetFwPolicy2)Activator.CreateInstance(
                    Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                    firewallPolicy2.Rules.Remove("Global Lagswitch Block");
                    statusLabel.Text = "Status: Disabled!";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void off()
        {
            try
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(
                Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Remove("Global Lagswitch Block");
                statusLabel.Text = "Status: Disabled!";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void processListBox_Click(object sender, EventArgs e)
        {
            processListBox.Items.Clear();


            Process[] processlist = Process.GetProcesses();
            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    object processItem = process.ProcessName;
                    processListBox.Items.Add(processItem);
                }
            }
        }

    }
}
