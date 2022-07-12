﻿using System;
using System.Windows.Forms;

namespace gamesense
{
    public partial class Form3 : Form
    {
        string HWID;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
        }

        private void copy_hwid_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HWID);
            MessageBox.Show("Copied HWID", "neverlose");
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new Form2();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void howtoDLL_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Last update - 01.02.2021 13:15", "neverlose.cc");
        }

        private void howtoHWID_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Undetected", "neverlose.cc");
        }

        private void finished_Click(object sender, EventArgs e)
        {
            MessageBox.Show("None", "neverlose.cc");
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
