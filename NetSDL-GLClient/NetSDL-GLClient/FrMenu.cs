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
            InitializeComponent();
            LoginOp op = new LoginOp();
            DataTable dt= op.GetWareHouse();
            if (dt.Rows.Count != 0)
            {
                coboxWarehouse.DataSource = dt;
                coboxWarehouse.ValueMember = "Unit_id";
                coboxWarehouse.DisplayMember = "Unit_name";
            }
        }

        private void llblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            this.refresh();
        }
    }
}
