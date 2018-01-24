using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picking
{
    public partial class FrStartPickingGroup : BaseForm
    {
        public FrStartPickingGroup()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; 
            dataGridView1.Font = new Font("Arial Unicode MS", 10, FontStyle.Bold);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ProcessExc.ShowForm("Picking for");
        }
    }
}
