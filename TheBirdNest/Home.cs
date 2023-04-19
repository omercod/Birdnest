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
        public Home()
        {
            InitializeComponent();
            userControlAddBird1.Hide();
            userControlAddCage1.Hide();
            userControlBirdSearch1.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

        }

        private void bttnAddBird_Click(object sender, EventArgs e)
        {
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
            userControlBirdSearch1.Show();
            userControlAddCage1.Hide();
            userControlAddBird1.Hide();
            bttnAddBird.ForeColor = Color.White;
            btnAddCage.ForeColor = Color.White;
            btnSearchBird.ForeColor = Color.Black;
            btnSearchCage.ForeColor = Color.White;
        }
    }
}