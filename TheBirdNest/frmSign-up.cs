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
    public partial class frmSign_up : Form
    {
        public frmSign_up()
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

        private void txtUserLogIn_Enter(object sender, EventArgs e)
        {
            if (txtUserLogIn.Text == "Username")
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

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "ID")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "ID";
                txtID.ForeColor = Color.DarkGray;
            }
        }


        private void labelLogin_MouseHover(object sender, EventArgs e)
        {
            labelLogin.ForeColor = Color.Black;
        }

        private void labelLogin_MouseLeave(object sender, EventArgs e)
        {
            labelLogin.ForeColor = Color.SaddleBrown;
        }
        private void labelLogin_Click(object sender, EventArgs e)
        {
            Form1 logInForm = new Form1();
            logInForm.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userName = txtUserLogIn.Text;
            string pass = txtPassword.Text;
            int userNameDigits = userName.Count(c => Char.IsNumber(c));
            int userNameLetters = userName.Count(c => Char.IsLetter(c));
            int passDigits = pass.Count(c => Char.IsNumber(c));
            int passLetters = pass.Count(c => Char.IsLetter(c));

            //Excel
            if (excel == null)
                excel = new Excel(@"C:\Users\omcl9\source\repos\TheBirdNest\BirdNessXl.xlsx", 1);

            //userName Error
            if (userName.Length < 6 || userName.Length > 8)
            {
                MessageBox.Show(userName+" is not vaild."+"\nUsername must include 6-8 characters.","Error Username"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (userNameDigits > 2)
            {
                MessageBox.Show(userName + " is not vaild." + "\nUsername can include up to 2 digits.", "Error Username"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (userNameDigits + userNameLetters != userName.Length)
            {
                MessageBox.Show(userName + " is not vaild." + "\nUsername contains only digits and letters.", "Error Username"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int i = 1;
            while (excel.readCell(i, 1) != "")
            {
                if (userName == excel.readCell(i, 1))
                {
                    MessageBox.Show("User: " + txtUserLogIn.Text + " is allready exist", "Error Username"
                                      , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                i++;
            }

            //Password Error
            if (pass.Length < 8 || pass.Length > 10)
            {
                MessageBox.Show(pass + " is not vaild." + "\nPassword must include 8-10 characters.", "Error Password"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (passDigits < 1 || passLetters < 1 || pass.Length == passDigits + passLetters)
            {
                MessageBox.Show(pass + " is not vaild." + "\nPassword must contains at least one digit, letter and" +
                    " speacial character.", "Error Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ID Error
            if (txtID.Text.Length != 9 || txtID.Text.Count(c => Char.IsNumber(c)) != 9)
            {
                MessageBox.Show("Please enter a 9 digits ID.", "Error ID"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            i = 1;
            while (excel.readCell(i, 3) != "")
            {
                if (txtID.Text == excel.readCell(i,3))
                {
                    MessageBox.Show("ID: "+ txtID.Text + " is allready exist", "Error ID"
                                      , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                i++;
            }

            excel.writeToCell(i, userName,pass,txtID.Text);
            excel.Save();
            MessageBox.Show(userName + " You Signed Up!", "Congratulations"
                             , MessageBoxButtons.OK, MessageBoxIcon.Information);
            Home HomeMenu = new Home(userName);
            HomeMenu.Show();
            this.Hide();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            if (excel != null)
                excel.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
