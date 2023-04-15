using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBirdNest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void txtUserLogIn_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtUserLogIn_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtUserLogIn_Enter(object sender, EventArgs e)
        {
            if(txtUserLogIn.Text == "Username")
            {
                txtUserLogIn.Text = "";
                txtUserLogIn.ForeColor = Color.DarkGray;
            }
        }

        private void txtUserLogIn_Leave(object sender, EventArgs e)
        {
            if (txtUserLogIn.Text == "")
            {
                txtUserLogIn.Text = "Username";
                txtUserLogIn.ForeColor = Color.DarkGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.DarkGray;
                txtPassword.PasswordChar = '\0';
            }
        }

        private void labelCreateAccount_MouseHover(object sender, EventArgs e)
        {
            labelCreateAccount.ForeColor = Color.Black;
        }

        private void labelCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            labelCreateAccount.ForeColor = Color.SaddleBrown;
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            frmSign_up signUpForm = new frmSign_up();
            signUpForm.Show();
            this.Hide();
        }
    }
}
