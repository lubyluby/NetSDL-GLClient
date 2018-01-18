using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using NetSDL_GLClient.Operator;
using NLog;
using System.Diagnostics;   

namespace NetSDL_GLClient
{
    public partial class FrLogin : Form
    {
        int ret;
      
        public FrLogin()
        {
            this.WindowState = FormWindowState.Maximized; 
            InitializeComponent();
            //button1.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //txtPjNO.Text = "lillybee";
            //txtUser.Text = "gladmin";
            //txtPwd.Text = "111";
           
            string pjNO = txtPjNO.Text.Trim();
            string user = txtUser.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            
            LoginOp logOp = new LoginOp();
            ret=logOp.GetToken(pjNO,user,pwd);
            if (ret != 0)
            {
                MessageBox.Show("Logon failure,Login agin please!");
            }
            else
            {
                FrMenu frMenu = new FrMenu();
                frMenu.refresh += RefreshForm;
                frMenu.Show();
               
            }
           
        }
        public void RefreshForm()
        {
            txtPjNO.Text = "";
            txtUser.Text = "";
            txtPwd.Text = "";
        }

       
    }
}
