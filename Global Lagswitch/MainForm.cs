﻿using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NetFwTypeLib;
using System.Diagnostics;

namespace GlobalLagswitch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

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

        private bool mouseDown;
        private Point lastLocation;

        private void titleLabel_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void titleLabel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void Wait(int ms)
        {
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalMilliseconds < ms)
                Application.DoEvents();

        }

        private void lsonButton_Click(object sender, EventArgs e)
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
                catch
                {
                }
            }
            catch
            {
                statusLabel.Text = "Status: Please run as an admin.";
                MessageBox.Show("Please run as an admin.");
                this.Close();
            }
        }

        private void lsoffButton_Click(object sender, EventArgs e)
        {
            try
            {
                INetFwPolicy2 firewallPolicy = (INetFwPolicy2)Activator.CreateInstance(
                Type.GetTypeFromProgID("HNetCfg.FwPolicy2"));
                firewallPolicy.Rules.Remove("Global Lagswitch Block");
                statusLabel.Text = "Status: Disabled!";
            }
            catch
            {
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