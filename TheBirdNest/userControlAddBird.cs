using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBirdNest
{
    public partial class userControlAddBird : UserControl
    {
        string[] arrAmerica = {"North America", "Central America", "South America"};
        string[] arrEurope = {"West Europe", "East Europe" };
        string[] arrAustralia = {"Central Australia", "Coastal Cities"};
        string[] arrHeadColor = {"Red", "Yellow", "Black"};
        public userControlAddBird()
        {
            InitializeComponent();
        }


        private void userControlAddBird_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxBirdSpe_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxBirdSpe.SelectedIndex)
            {
                case 0:
                    comboBoxBirdSubSpe.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxBirdSubSpe.Enabled = true;
                    comboBoxBirdSubSpe.Items.Clear();
                    comboBoxBirdSubSpe.Items.AddRange(arrAmerica);
                    break;
                case 1:
                    comboBoxBirdSubSpe.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxBirdSubSpe.Enabled = true;
                    comboBoxBirdSubSpe.Items.Clear();
                    comboBoxBirdSubSpe.Items.AddRange(arrEurope);
                    break;
                case 2:
                    comboBoxBirdSubSpe.DropDownStyle = ComboBoxStyle.DropDownList;
                    comboBoxBirdSubSpe.Enabled = true;
                    comboBoxBirdSubSpe.Items.Clear();
                    comboBoxBirdSubSpe.Items.AddRange(arrAustralia);
                    break;
            }
        }

        private void pictAddBird_Click(object sender, EventArgs e)
        {
            string addtotable = $"insert into BirdsTable values('{txtSerialNumberBird.Text.ToString()}','" +
                $"{comboBoxBirdSpe.Text}','{comboBoxBirdSubSpe.Text}','{dateBirdHatchingDate.Value.ToString()}" +
                $"','{cmbBirdGender.Text}','{txtBirdCageNumber.Text.ToString()}" +
                $"','{txtBirdFatherSerialNumber.Text.ToString()}','{txtBirdMotherSN.Text.ToString()}')";
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:
            \USERS\OMCL9\SOURCE\REPOS\THEBIRDNEST\THEBIRDNEST\BIRDNESTDB.MDF;Integrated Security=True;
            Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
            MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = addtotable;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");

        }

        private void checkBoxBabyBird_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBabyBird.Checked)
            {
                cmbHeadColor.Enabled = false;
                cmbBreastColor.Enabled = false;
                cmbBodyColor.Enabled = false;
                txtBirdFatherSerialNumber.Text = "";
                txtBirdMotherSN.Text = "";
                txtBirdFatherSerialNumber.Enabled = true;
                txtBirdMotherSN.Enabled = true;
            }
            else
            {
                cmbHeadColor.Enabled = true;
                cmbBreastColor.Enabled = true;
                cmbBodyColor.Enabled = true;
                txtBirdFatherSerialNumber.Enabled = false;
                txtBirdFatherSerialNumber.Text = "Only for baby bird";
                txtBirdMotherSN.Text = "Only for baby bird";
                txtBirdMotherSN.Enabled = false;
            }
        }
    }
}
