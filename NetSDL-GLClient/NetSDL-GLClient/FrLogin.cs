﻿using System;
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
           // this.WindowState = FormWindowState.Maximized; 
            InitializeComponent();
            button1.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtPjNO.Text = "lillybee";
            txtUser.Text = "gladmin";
            txtPwd.Text = "111";
           
            string pjNO = txtPjNO.Text.Trim();
            string user = txtUser.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            
            LoginOp logOp = new LoginOp();
            ret=logOp.GetToken(pjNO,user,pwd);
            if (ret != 0)
            {
                MessageBox.Show("Log in agin please!");
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

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = @"D:\project\Pr13Test\testWinform\bin\Debug\testWinform.exe";
            string[] args = new string[2];
            args[0]="aa";
            args[1]="bb";
            try
            {
                Tools.StartProcess(fileName,args);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

              
              
            
        }
    }
}
