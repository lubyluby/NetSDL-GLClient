using NetSDL_GLClient.Operator;
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
            this.WindowState = FormWindowState.Maximized; 
            InitializeComponent();
            LoginOp op = new LoginOp();
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
            string fileName = "testWinform.exe";
            //string fileName = @"D:\project\Pr13Test\testWinform\bin\Debug\testWinform.exe";
            fileName = Getpath() + fileName;
            string[] args = new string[2];
            args[0] = "aa";
            args[1] = "bb";
            try
            {
                Tools.StartProcess(fileName, args);
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
    }
}
