
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
       
        Logger log = LogManager.GetCurrentClassLogger();

      
        public  FrPicking(string[] args):base(args)
        {
            
            InitializeComponent();
           
        }
        

        private void llblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           ProcessExc.ShowForm("Menu");
           this.Close();
         
        }
        
        

        private void BtnGroupPicking_Click(object sender, EventArgs e)
        {
            
            FrStartPickingGroup startPickingGroup = new FrStartPickingGroup(this.args);
            startPickingGroup.Show();
            this.Hide();
        }

        private void FrPicking_Load(object sender, EventArgs e)
        {
           
        }

    }
}
