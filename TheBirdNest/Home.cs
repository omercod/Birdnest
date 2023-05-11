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
    public partial class Home : Form
    {
        string userName;
        public Home(string user)
        {
            InitializeComponent();
            userControlAddBird1.Hide();
            userControlAddCage1.Hide();
            userControlBirdSearch1.Hide();
            this.MouseDown += new MouseEventHandler(panelControl_MouseDown);
            this.MouseMove += new MouseEventHandler(panelControl_MouseMove);
            lblWelcome.Text += " " + user;
            userName = user;
        }

        //Excel
        Excel excel = new Excel(@"C:\Users\omcl9\source\repos\TheBirdNest\BirdNessXl.xlsx", 1);

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }

        private void bttnAddBird_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "";
            userControlAddBird1.Show();
            userControlAddCage1.Hide();
            userControlBirdSearch1.Hide();
            bttnAddBird.ForeColor = Color.Black;
            btnAddCage.ForeColor = Color.White;
            btnSearchBird.ForeColor = Color.White;
            btnSearchCage.ForeColor = Color.White;
           
        }

        private void userControlAddBird1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCage_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "";
            userControlAddCage1.Show();
            userControlAddBird1.Hide();
            userControlBirdSearch1.Hide();
            btnAddCage.ForeColor = Color.Black;
            bttnAddBird.ForeColor = Color.White;
            btnSearchBird.ForeColor = Color.White;
            btnSearchCage.ForeColor = Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchBird_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = "";
            userControlBirdSearch1.Show();
            userControlAddCage1.Hide();
            userControlAddBird1.Hide();
            bttnAddBird.ForeColor = Color.White;
            btnAddCage.ForeColor = Color.White;
            btnSearchBird.ForeColor = Color.Black;
            btnSearchCage.ForeColor = Color.White;
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            excel.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}