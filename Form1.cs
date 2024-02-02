using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_3
{
    public partial class Form1 : Form
    {
        public int loginAttempt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EMS_Main ems_Main = new EMS_Main();
            LoginPurgatory loginPurgatory = new LoginPurgatory();

            if (txtUser.Text == "admin" && txtPW.Text == "password")
            {
                MessageBox.Show("Login Successful! Please remember to logout when finished.");
                ems_Main.Show();
                this.Hide();
            }
            else
            {
                grpError.Show();
                RefreshData();
                txtUser.Focus();

                loginAttempt += 1;
                if(loginAttempt == 3)
                {
                    MessageBox.Show("Excessive login attempts! Redirecting...", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    loginPurgatory.Show();
                    this.Hide();
                }
            }

            
        }
        private void RefreshData()
        {
            txtUser.Clear();
            txtPW.Clear();
        }

        private void btnCloseError_Click(object sender, EventArgs e)
        {
            grpError.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpError.Hide();
        }
    }
}
