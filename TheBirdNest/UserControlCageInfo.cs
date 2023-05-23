using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace TheBirdNest
{
    public partial class UserControlCageInfo : UserControl
    {
        private string cageNum;
        private string length;
        private string witdh;
        private string high;
        private string material;
        SqlConnection con;
        SqlCommand cmd;
        public UserControlCageInfo(string cNum)
        {
            InitializeComponent();
            cageNum = cNum;
            txtCageHigh.Enabled = false;
            txtCageLength.Enabled = false;
            txtCageWidth.Enabled = false;
            txtCageNum.Enabled = false;
            cmbCgaeMat.Visible = false;
            btnUpdate.Visible = false;
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\OMCL9\Source\Repos\TheBirdNest\TheBirdNest\BirdNestDB.mdf;
            Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
            ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            dataInfo();
            birdsInCageArray();
        }

        private void UserControlCageInfo_Load(object sender, EventArgs e)
        {

        }

        private void panelBirdInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        public void birdsInCageArray()
        {
            if (cmbCageBirds.SelectedIndex != -1 && cmbCageBirds.SelectedIndex != 0)
                return;
            string query = "";
            // get the cage list.
            // Open the SQL connection
            con.Open();
            // Define the SQL query to retrieve the cage numbers
                query = $"SELECT * FROM BirdsTable WHERE CONVERT(varchar(MAX), Cage_Number) = '{cageNum}'";
            // Create a list to store the cage numbers
            List<string> cageBirdsList = new List<string>();
            // Execute the SQL query and retrieve the cage numbers
            SqlCommand cmd = new SqlCommand(query, con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Add each cage number to the list
                    int birdsSN = reader.GetInt32(0);
                    cageBirdsList.Add(birdsSN.ToString());
                }
            }
            // Convert the list of cage numbers to a string array
            // Close the SQL connection
            con.Close();
            lblCageBirds.Text = $"{cageBirdsList.Count} Birds in cage {cageNum}";
            if (cageBirdsList.Count != 0)
            {
                cmbCageBirds.Enabled = true;
                cmbCageBirds.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbCageBirds.DataSource = cageBirdsList.ToArray();
            }
            else
                cmbCageBirds.Text = $"No birds in {cageNum}.";
        }

        public void dataInfo()
        {
            string query = $"SELECT * FROM CagesTable WHERE CONVERT(varchar(MAX), Cage_Number) = '{cageNum}'";
            cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                txtCageNum.Text = reader.GetString(0);
                length = reader.GetString(1);
                txtCageLength.Text = reader.GetString(1) + " cm";
                witdh = reader.GetString(2);
                txtCageWidth.Text = reader.GetString(2) + " cm";
                high = reader.GetString(3);
                txtCageHigh.Text = reader.GetString(3) + " cm";
                material = reader.GetString(4); 
                lblCageMat.Text = reader.GetString(4);
            }
            reader.Close();
            con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form home = this.FindForm();
            UserControlSearchCage cageSearch = new UserControlSearchCage();
            Point currentLocation = this.Location;
            cageSearch.Location = currentLocation;
            // Find the parent form or container control
            Control parentControl = this.Parent; // Replace "Control" with the appropriate parent control type
                                                 // Add the new user control to the parent control's collection of controls
            parentControl.Controls.Add(cageSearch);
            // Bring the new user control to the front
            cageSearch.Show();
            cageSearch.BringToFront();
            cageSearch.dataSearch();
            cageSearch.PopulateDataGridView();
        }

        private void btnDeleteCage_Click(object sender, EventArgs e)
        {
            // Display the confirmation message box
            var result = MessageBox.Show("Are you sure you want to delete this cage?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM CagesTable WHERE CONVERT(varchar(MAX), Cage_Number) = '{cageNum}'";
                // Open the SQL connection
                con.Open();
                // Create the command with the query and connection
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                Form home = this.FindForm();
                UserControlSearchCage cageSearch = new UserControlSearchCage();
                Point currentLocation = this.Location;
                cageSearch.Location = currentLocation;
                // Find the parent form or container control
                Control parentControl = this.Parent; // Replace "Control" with the appropriate parent control type
                parentControl.Controls.Add(cageSearch);
                // Bring the new user control to the front
                cageSearch.Show();
                cageSearch.BringToFront();
                cageSearch.dataSearch();
                cageSearch.PopulateDataGridView();
            }
        }

        private void btnEditCage_Click(object sender, EventArgs e)
        {
            txtCageHigh.Enabled = true;
            btnEditCage.Text = "Restore";
            txtCageHigh.Text = high;
            txtCageLength.Text = length;
            txtCageWidth.Text = witdh;
            txtCageLength.Enabled = true;
            txtCageWidth.Enabled = true;
            cmbCgaeMat.Visible = true;
            cmbCgaeMat.Text = material;
            btnUpdate.Visible = true;
            lblCageMat.Visible = false;
            cmbCageBirds.Visible = false;
            lblCageBirds.Visible = false;
            panelCageMat.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cageN = txtCageNum.Text;
            string cageLen = txtCageLength.Text;
            string cageWidth = txtCageWidth.Text;
            string cageHigh = txtCageHigh.Text;
            bool flag = false;

            if (cageN.Length == 0 || cageN.Count(c => Char.IsNumber(c)) == 0
            || cageN.Count(c => Char.IsLetter(c)) == 0)
            {
                MessageBox.Show("Cage number contains numbers and letters!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cageLen.Length == 0 || cageLen.Count(c => Char.IsLetter(c)) != 0
                || float.Parse(cageLen) < 0)
            {
                MessageBox.Show("Cage length must be bigger than 0!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cageWidth.Length == 0 || cageWidth.Count(c => Char.IsLetter(c)) != 0
                || float.Parse(cageWidth) < 0)
            {
                MessageBox.Show("Cage width must be bigger than 0!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cageHigh.Length == 0 || cageHigh.Count(c => Char.IsLetter(c)) != 0
                || float.Parse(cageHigh) < 0)
            {
                MessageBox.Show("Cage high must be bigger than 0!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbCgaeMat.SelectedIndex == -1 || cmbCgaeMat.SelectedIndex == 0)
            {
                MessageBox.Show("Cage materials must be selected!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string updateQuery = "UPDATE CagesTable SET ";
            if (cageLen != length)
            {
                updateQuery += $"Cage_Length = '{cageLen}', ";
                length = cageLen;
                flag = true;
            }
            if (cageWidth != witdh)
            {
                updateQuery += $"Cage_Width = '{cageWidth}', ";
                witdh = cageWidth;
                flag = true;
            }
            if (cageHigh != high)
            {
                updateQuery += $"Cage_High = '{cageHigh}', ";
                high = cageHigh;
                flag = true;
            }
            if (material != cmbCgaeMat.Text)
            {
                updateQuery += $"Cage_Material = N'{cmbCgaeMat.Text}', ";
                material = cmbCgaeMat.Text;
                flag = true;
            }

            if (flag == true)
            {
                updateQuery = updateQuery.TrimEnd(',', ' '); // Remove the trailing comma and space
                updateQuery += $" WHERE CONVERT(varchar(MAX), Cage_Number) = '{cageNum}'";
                con.Open();
                SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                updateCmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Successfully Update", "Cage Update"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtCageHigh.Enabled = false;
            txtCageLength.Enabled = false;
            txtCageWidth.Enabled = false;
            txtCageNum.Enabled = false;
            cmbCgaeMat.Visible = false;
            btnUpdate.Visible = false;
            lblCageMat.Visible = true;
            panelCageMat.Visible = true;
            btnEditCage.Text = "Edit Cage";
            txtCageLength.Text = length;
            txtCageWidth.Text = witdh;
            txtCageHigh.Text = high;
            lblCageMat.Text = material;
        }
    }
}
