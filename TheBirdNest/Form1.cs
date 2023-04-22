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

        /*public void openFile()
        {
            Excel excel = new Excel(@"C:\Users\omcl9\source\repos\TheBirdNest\BirdNessXl.xlsx", 1);
            string s = excel.readCell(1, 0);
        }*/


        private void Form1_Load(object sender, EventArgs e)
        {
            //openFile();
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
                txtUserLogIn.ForeColor = Color.Black;
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
                txtPassword.ForeColor = Color.Black;
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
            string user = txtUserLogIn.Text;
            string pass = txtPassword.Text;
            Excel excel = new Excel(@"C:\Users\omcl9\source\repos\TheBirdNest\BirdNessXl.xlsx", 1);
            int i = 1;
            while (excel.readCell(i, 0) != "")
            {
                if (user== excel.readCell(i, 0))
                {
                    if (pass == excel.readCell(i, 1))
                    {
                        Home HomeMenu = new Home();
                        HomeMenu.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Password is not correct", "Error"
                           , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                i++;
            }
            MessageBox.Show("Username not exsist", "Error"
              , MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void labelCreateAccount_Click(object sender, EventArgs e)
        {
            frmSign_up signUpForm = new frmSign_up();
            signUpForm.Show();
            this.Hide();
        }

        private void txtUserLogIn_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
