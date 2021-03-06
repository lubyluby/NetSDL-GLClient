﻿using NetSDL_GLClient.Operator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSDL_GLClient
{
    public partial class FrMenu : Form
    {
        public delegate void RefreshDelegate();
        public event RefreshDelegate refresh;
      
        public FrMenu()
        {
            LoginOp op = new LoginOp();
            this.WindowState = FormWindowState.Maximized; 
            InitializeComponent();
            DataTable dt= op.GetWareHouse();
            if (dt.Rows.Count != 0)
            {
                coboxWarehouse.DataSource = dt;
                coboxWarehouse.ValueMember = "Unit_id";
                coboxWarehouse.DisplayMember = "Unit_name";
            }
            this.btnPacking.Enabled = false;
            this.btnPutaway.Enabled = false;
            this.btnReceive.Enabled = false;
        }

        private void llblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.refresh();
        }

        private void btnPicking_Click(object sender, EventArgs e)
        {
            string token = LoginOp.token;
            string whId= coboxWarehouse.SelectedValue.ToString();

            string fileName = "Picking\\Picking.exe";
            //string fileName = @"D:\project\Pr13Test\testWinform\bin\Debug\testWinform.exe";
            fileName = Getpath() + fileName;
           
            string[] args = new string[2];
            args[0] = token;
            args[1] = whId;
            try
            {
                Tools.StartProcess(fileName, args);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private static string Getpath()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            path = path.Substring(0, path.LastIndexOf("\\"));
            path = path.Substring(0, path.LastIndexOf("\\") + 1) + "exec\\";
            return path;
        }

        protected override void WndProc(ref Message msg)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            if (msg.Msg == WM_SYSCOMMAND && ((int)msg.WParam == SC_CLOSE))
            {
                Application.ExitThread();
                return;
            }
            base.WndProc(ref msg);
        }

       
    }
}
