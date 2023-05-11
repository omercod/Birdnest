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
            this.MouseDown += new MouseEventHandler(panelControl_MouseDown);
            this.MouseMove += new MouseEventHandler(panelControl_MouseMove);
        }
        //Excel
        Excel excel;
        //Panel Control
        private Point mouseDownLocation;
        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDownLocation = e.Location;
        }
        private void panelControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left = e.X + this.Left - mouseDownLocation.X;
                this.Top = e.Y + this.Top - mouseDownLocation.Y;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //openFile();
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
                if (checkBoxShowPass.Checked)
                {
                    txtPassword.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                }
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                if (checkBoxShowPass.Checked)
                {
                    txtPassword.PasswordChar = '\0';
                }
                else
                {
                    txtPassword.PasswordChar = '*';
                }
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

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "Password" && checkBoxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            if (txtPassword.Text == "Password" && checkBoxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            if (!checkBoxShowPass.Checked)
            {
                txtPassword.PasswordChar = '*';
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
            if (excel == null)
                excel = new Excel(@"C:\Users\omcl9\source\repos\TheBirdNest\BirdNessXl.xlsx", 1);
            int i = 1;
            while (excel.readCell(i, 1) != "")
            {
                if (user== excel.readCell(i, 1))
                {
                    if (pass == excel.readCell(i, 2))
                    {
                        Home HomeMenu = new Home(user);
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

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            if(excel != null)
                excel.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
