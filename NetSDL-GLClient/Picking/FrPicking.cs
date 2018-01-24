
using NLog;
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
using System.Runtime.InteropServices;


namespace Picking
{
    public partial class FrPicking : BaseForm
    {
        string[] args;
        string token;
        string whId;
        Logger log = LogManager.GetCurrentClassLogger();
        public FrPicking(string[] args)
        {
            this.args = args;
            if (args.Length != 0)
            {
                token = args[0];
                whId=args[1];
            }
            this.WindowState = FormWindowState.Maximized; 
            InitializeComponent();
            //llblBack.Hide();
           
           // MessageBox.Show("token:" + token +"whid:"+whId);
        }

        private void llblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           ProcessExc.ShowForm("Menu");
           this.Close();
         
        }
        
        

        private void BtnGroupPicking_Click(object sender, EventArgs e)
        {
            FrStartPickingGroup startPickingGroup = new FrStartPickingGroup();
            startPickingGroup.Show();
            this.Hide();
        }

    }
}
