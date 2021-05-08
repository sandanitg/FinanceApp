using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceApp
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

       
        private void LogIn(object sender, EventArgs e)
        {
            if ((txtUserName.Text == "sandani") && (txtPassword.Text == "1234"))
            {
                this.Hide();
                Home home = new Home();
                home.FormClosed += (s, args) => this.Close();
                home.Activate();
                home.ShowDialog();
                
            }
            else {
                MessageBox.Show("Please enter correct credentials!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
