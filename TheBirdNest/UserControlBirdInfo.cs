using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Threading;
using System.IO;

namespace TheBirdNest
{
    public partial class UserControlBirdInfo : UserControl
    {
        private int sNumber;
        private string gender;
        private string thisHeadC;
        private string thisBreastC;
        private string thisBodyC;
        private string thisSpe;
        private string thisSubspe;
        private string cageNum;
        private string otherGen;
        SqlConnection con;
        SqlCommand cmd;
        DateTime dateFather, dateMother;
        public UserControlBirdInfo(int sNumber)
        {
            InitializeComponent();
            btnAddBabyAfter.Visible = false;
            txtSN.Visible = false;
            txtSerialNumberSearchBird.Visible = false;
            dateHatching.Visible = false;
            cmbBirdGender.Visible = false;
            panelSN.Visible = false;
            cmbCages.Visible = false;
            btnUpdate.Visible = false;
            dateFather = DateTime.MinValue;
            dateMother = DateTime.MinValue;

            this.sNumber = sNumber;
            con = new SqlConnection(findCon());
            dataInfo();
            otherGenderArray();
        }

        public string findCon()
        {
            string databaseFileName = "BirdNestDB.mdf";

            // Get the directory path of the executable file
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the directory path with the database file name
            string databaseFilePath = Path.Combine(directoryPath, databaseFileName);

            // Update the connection string to use the dynamic file path and database name
            string connectionString = $@"Data Source=(LocalDb)\MSSQLLocalDB;
             AttachDbFilename='{databaseFilePath}';Integrated Security=True;Connect Timeout=30;
            Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
             MultiSubnetFailover=False";

            return connectionString;
        }

        public void CagesArray()
        {
            if (cmbCages.SelectedIndex != -1 && cmbCages.SelectedIndex != 0)
                return;
            string query = "";
            // get the cage list.
            // Open the SQL connection
            con.Open();
            // Define the SQL query to retrieve the cage numbers
            query = $"SELECT * FROM CagesTable";
            // Create a list to store the cage numbers
            List<string> cagesList = new List<string>();
            // Execute the SQL query and retrieve the cage numbers
            SqlCommand cmd = new SqlCommand(query, con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Add each cage number to the list
                    string cage = reader.GetString(0);
                    cagesList.Add(cage.ToString());
                }
            }
            // Convert the list of cage numbers to a string array
            // Close the SQL connection
            con.Close();
            cmbCages.Visible = true;
            if (cagesList.Count != 0)
            {
                cmbCages.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbCages.DataSource = cagesList.ToArray();
            }
            panelCgaes.Visible = false;
            lblCageNum.Visible = false;
        }
        public void dataInfo()
        {
            string query = $"SELECT * FROM BirdsTable WHERE Serial_Number={sNumber}";
            cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                lblSN.Text = sNumber.ToString();
                lblBirdSpe.Text = reader["Bird_Species"].ToString();
                thisSpe = reader["Bird_Species"].ToString();
                lblSubSpe.Text = reader["Sub_Species"].ToString();
                thisSubspe = reader["Sub_Species"].ToString();
                lblDate.Text = ((DateTime)reader["Hatching_Date"]).ToString("dd.MM.yyyy");
                lblGender.Text = reader["Bird_Gender"].ToString();
                gender = reader["Bird_Gender"].ToString();
                lblCageNum.Text = reader["Cage_Number"].ToString();
                cageNum = reader["Cage_Number"].ToString();
                lblHeadCol.Text = reader["Head_Color"].ToString();
                thisHeadC = reader["Head_Color"].ToString();
                lblBreastCol.Text = reader["Breast_Color"].ToString();
                thisBreastC = reader["Breast_Color"].ToString();
                lblBodyCol.Text = reader["Body_Color"].ToString();
                thisBodyC = reader["Body_Color"].ToString();
                dateMother = DateTime.Parse(reader["Hatching_Date"].ToString());
            }
            reader.Close();
            con.Close();
        }
        

        public void otherGenderArray()
        {
            if (cmbOtherGender.SelectedIndex != -1 && cmbOtherGender.SelectedIndex != 0)
                return;
            string query = "";
            // get the cage list.
            // Open the SQL connection
            con.Open();
            // Define the SQL query to retrieve the cage numbers
            if (gender == "Female")
            {
                query = $"SELECT * FROM BirdsTable WHERE CONVERT(varchar(MAX), Bird_Gender) = '{"Male"}' AND CONVERT(varchar(MAX), Cage_Number) = '{cageNum}'";
                otherGen = "Males";
            }
            else
            {
                query = $"SELECT * FROM BirdsTable WHERE CONVERT(varchar(MAX), Bird_Gender) = '{"Female"}' AND CONVERT(varchar(MAX), Cage_Number) = '{cageNum}'";
                otherGen = "Females";
            }
            lblOtherGen.Text = $"{otherGen} in {cageNum}";
                // Create a list to store the cage numbers
                List<string> otherGenderList = new List<string>();
            // Execute the SQL query and retrieve the cage numbers
            SqlCommand cmd = new SqlCommand(query, con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Add each cage number to the list
                    int cageNumber = reader.GetInt32(0);
                    otherGenderList.Add(cageNumber.ToString());
                }
            }
            // Convert the list of cage numbers to a string array
            // Close the SQL connection
            con.Close();
            if (otherGenderList.Count != 0)
            {
                cmbOtherGender.Enabled = true;
                cmbOtherGender.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbOtherGender.DataSource = otherGenderList.ToArray();
            }
            else
                cmbOtherGender.Text = $"No {otherGen} in {cageNum}.";
        }
        private void UserControlBirdInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form home = this.FindForm();
            UserControlBirdSearch bSearch = new UserControlBirdSearch();
            Point currentLocation = this.Location;
            bSearch.Location = currentLocation;
            // Find the parent form or container control
            Control parentControl = this.Parent; // Replace "Control" with the appropriate parent control type
                                                 // Add the new user control to the parent control's collection of controls
            parentControl.Controls.Add(bSearch);
            // Bring the new user control to the front
            bSearch.Show();
            bSearch.BringToFront();
            bSearch.dataSearch();
            bSearch.PopulateDataGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Display the confirmation message box
            var result = MessageBox.Show("Are you sure you want to delete this bird?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's choice
            if (result == DialogResult.Yes)
            {
                string query = $"DELETE FROM BirdsTable WHERE Serial_Number = '{sNumber.ToString()}'";
                // Open the SQL connection
                con.Open();
                // Create the command with the query and connection
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                this.Hide();
                Form home = this.FindForm();
                UserControlBirdSearch bSearch = new UserControlBirdSearch();
                Point currentLocation = this.Location;
                bSearch.Location = currentLocation;
                // Find the parent form or container control
                Control parentControl = this.Parent; // Replace "Control" with the appropriate parent control type
                parentControl.Controls.Add(bSearch);
                // Bring the new user control to the front
                bSearch.Show();
                bSearch.BringToFront();
                bSearch.dataSearch();
                bSearch.PopulateDataGridView();
            }
        }

        private void btnAddBaby_Click(object sender, EventArgs e)
        {
            if(cmbOtherGender.SelectedIndex == -1)
            {
                MessageBox.Show("Must select other gender bird!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //unVisibble old fields
            btnAddBaby.Visible = false;
            btnDelete.Visible = false;
            btnEditBird.Visible = false;

            //new fields
            btnAddBabyAfter.Visible = true;
            txtSN.Visible = true;
            txtSerialNumberSearchBird.Visible = true;
            dateHatching.Visible = true;
            cmbBirdGender.Visible = true;
            panelSN.Visible = true;
            dateHatching.CustomFormat = "'Select Date'";
            dateHatching.Format = DateTimePickerFormat.Custom;
            cmbBirdGender.SelectedIndex = 0;
        }


        private void txtSN_Enter(object sender, EventArgs e)
        {
            if (txtSN.Text == "")
            {
                txtSN.Text = "Serial Number";
                txtSN.ForeColor = Color.Gray;
            }
            else
            {
                txtSN.Text = "";
                txtSN.ForeColor = Color.Black;
            }
        }

        private void txtSN_Leave(object sender, EventArgs e)
        {
            if (txtSN.Text == "")
            {
                txtSN.Text = "Serial Number";
                txtSN.ForeColor = Color.Gray;
            }
        }

        public string[] GetBabyColors(string babyGender, string fatherHead, string fatherBreast, string fatherBody, string motherHead, string motherBreast, string motherBody)
        {
            string[] finalColors = new string[3];
            Random random = new Random();
            string[] offspringHeadF = { };
            string[] offspringHeadM = { };

            if ((fatherHead == "Red" && motherHead == "Yellow"))
            {
                offspringHeadM = new string[] { "Red", "Yellow" };
                offspringHeadF = new string[] { "Yellow", "Red" };
            }
            else if ((fatherHead == "Yellow" && motherHead == "Red"))
            {
                offspringHeadM = new string[] { "Red", "Yellow" };
                offspringHeadF = new string[] { "Yellow", "Red" };
            }
            else if ((fatherHead == "Red" && motherHead == "Black"))
            {
                offspringHeadM = new string[] { "Red", "Black" };
                offspringHeadF = new string[] { "Red" };
            }
            else if ((fatherHead == "Black" && motherHead == "Red"))
            {
                offspringHeadM = new string[] { "Red", "Black" };
                offspringHeadF = new string[] { "Black" };
            }
            else if ((fatherHead == "Black" && motherHead == "Yellow"))
            {
                offspringHeadM = new string[] { "Red", "Black", "Yellow" };
                offspringHeadF = new string[] { "Yellow", "Black" };
            }
            else if ((fatherHead == "Yellow" && motherHead == "Black"))
            {
                offspringHeadM = new string[] { "Red", "Yellow", "Black" };
                offspringHeadF = new string[] { "Yellow", "Red" };
            }
            else
            {
                offspringHeadF = new string[] { motherHead };
                offspringHeadM = new string[] { motherHead };
            }

            string[] offspringBreastF = { };
            string[] offspringBreastM = { };

            if ((fatherBreast == "Purple" && motherBreast == "White"))
            {
                offspringBreastM = new string[] { "Purple", "White" };
                offspringBreastF = new string[] { "Purple", "White" };
            }
            else if ((fatherBreast == "White" && motherBreast == "Purple"))
            {
                offspringBreastM = new string[] { "Purple", "White" };
                offspringBreastF = new string[] { "Purple", "White" };
            }
            else if ((fatherBreast == "Purple" && motherBreast == "Lilac"))
            {
                offspringBreastM = new string[] { "Purple", "Lilac" };
                offspringBreastF = new string[] { "Purple", "Lilac" };
            }
            else if ((fatherBreast == "Lilac" && motherBreast == "Purple"))
            {
                offspringBreastM = new string[] { "Purple", "Lilac" };
                offspringBreastF = new string[] { "Purple", "Lilac" };
            }
            else if ((fatherBreast == "White" && motherBreast == "Lilac"))
            {
                offspringBreastM = new string[] { "Lilac", "White" };
                offspringBreastF = new string[] { "Lilac", "White" };
            }
            else if ((fatherBreast == "Lilac" && motherBreast == "White"))
            {
                offspringBreastM = new string[] { "Lilac", "White" };
                offspringBreastF = new string[] { "Lilac", "White" };
            }
            else
            {
                offspringBreastF = new string[] { motherBreast };
                offspringBreastM = new string[] { motherBreast };
            }

            ArrayList colors = new ArrayList();
            string[] offspringBodyF = { };
            string[] offspringBodyM = { };

            if ((fatherBody == "Green" && motherBody == "Yellow"))
            {
                offspringBodyM = new string[] { "Yellow" };
                offspringBodyF = new string[] { "Green" };
            }
            else if ((fatherBody == "Yellow" && motherBody == "Green"))
            {
                offspringBodyM = new string[] { "Yellow" };
                offspringBodyF = new string[] { "Yellow" };
            }
            else if ((fatherBody == "Green" && motherBody == "Blue"))
            {
                offspringBodyM = new string[] { "Green", "Blue" };
                offspringBodyF = new string[] { "Green", "Blue" };
            }
            else if ((fatherBody == "Blue" && motherBody == "Green"))
            {
                offspringBodyM = new string[] { "Green", "Blue" };
                offspringBodyF = new string[] { "Green", "Blue" };
            }
            else if ((fatherBody == "Blue" && motherBody == "Yellow"))
            {
                offspringBodyM = new string[] { "Yellow", "Blue" };
                offspringBodyF = new string[] { "Green", "Blue" };
            }
            else if ((fatherBody == "Yellow" && motherBody == "Blue"))
            {
                offspringBodyM = new string[] { "Yellow", "Blue" };
                offspringBodyF = new string[] { "Yellow", "Blue" };
            }//silver
            else if ((fatherBody == "Silver" && motherBody == "Blue"))
            {
                offspringBodyM = new string[] { "Blue" };
                offspringBodyF = new string[] { "Silver" };
            }
            else if ((fatherBody == "Silver" && motherBody == "Yellow"))
            {
                offspringBodyM = new string[] { "Yellow", "Blue" };
                offspringBodyF = new string[] { "Yellow", "Blue" };
            }
            else if ((fatherBody == "Silver" && motherBody == "Green"))
            {
                offspringBodyM = new string[] { "Yellow", "Blue" };
                offspringBodyF = new string[] { "Yellow", "Blue" };
            }
            else if ((fatherBody == "Green" && motherBody == "Silver"))
            {
                offspringBodyM = new string[] { "Yellow", "Blue" };
                offspringBodyF = new string[] { "Green", "Blue" };
            }
            else if ((fatherBody == "Blue" && motherBody == "Silver"))
            {
                offspringBodyM = new string[] { "Blue" };
                offspringBodyF = new string[] { "Blue" };
            }
            else if ((fatherBody == "Yellow" && motherBody == "Silver"))
            {
                offspringBodyM = new string[] { "Yellow", "Blue" };
                offspringBodyF = new string[] { "Yellow", "Blue" };
            }
            else
            {
                offspringBodyF = new string[] { motherBody };
                offspringBodyM = new string[] { motherBody };
            }

            if (babyGender == "Male")
            {
                colors.Add(offspringHeadM);
                colors.Add(offspringBreastM);
                colors.Add(offspringBodyM);
            }
            else if (babyGender == "Female")
            {
                colors.Add(offspringHeadF);
                colors.Add(offspringBreastF);
                colors.Add(offspringBodyF);
            }

            int i = 0;
            foreach (string[] partColor in colors)
            {
                finalColors[i] = partColor[random.Next(partColor.Length)];
                i++;
            }
            return finalColors;
        }

        private void btnAddBabyAfter_Click(object sender, EventArgs e)
        {
            string sNumber = txtSN.Text;
            if (sNumber.Length != sNumber.Count(c => Char.IsNumber(c)) || sNumber.Length == 0)
            {
                MessageBox.Show("Serial number contains only numbers!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //check if SN exist
            string snExist = $"SELECT COUNT(*) FROM BirdsTable WHERE" +
             $" Serial_Number = '{txtSN.Text.ToString()}'";
            // open new SQL(data, connection)
            SqlCommand cmd = new SqlCommand(snExist, con);
            con.Open();
            int count = (int)cmd.ExecuteScalar();
            // if Serial Number is exsit in the table send message.
            if (count > 0)
            {
                MessageBox.Show("Serial number is already exist!", "Error"
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            con.Close();
            if (dateHatching.CustomFormat == "'Select Date'")
            {
                MessageBox.Show("Must select date!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbBirdGender.SelectedIndex == 0)
            {
                MessageBox.Show("Must select gender!", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string otherSpe = "", otherSubeSpe = "", otherHeadC = "",
                otherBreastC = "", otherBodyC = "", babyGender = "";
            //SQL
            string query = $"SELECT * FROM BirdsTable WHERE Serial_Number={cmbOtherGender.Text}";
            cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                otherSpe = reader["Bird_Species"].ToString();
                otherSubeSpe = reader["Sub_Species"].ToString();
                otherHeadC = reader["Head_Color"].ToString();
                otherBreastC = reader["Breast_Color"].ToString();
                otherBodyC = reader["Body_Color"].ToString();
                dateFather = DateTime.Parse(reader["Hatching_Date"].ToString());
                babyGender = cmbBirdGender.Text;
                reader.Close();
            }
            con.Close();
            DateTime dateBaby = dateHatching.Value;
            if (dateBaby > dateFather || dateBaby > dateMother)
            {
                MessageBox.Show($"Must select baby bird date after the parents date\n\n" +
                    $"Father Date: {dateFather.ToString("dd-MM-yyyy")}\n" +
                    $"Mother Date: {dateMother.ToString("dd-MM-yyyy")}", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            if (gender == "Female")
            {
                string[] babyColors = GetBabyColors(babyGender, otherHeadC, otherBreastC,
                            otherBodyC, thisHeadC, thisBreastC, thisBodyC);
                string addtotable = $"insert into BirdsTable values('{txtSN.Text}','" +
                    $"{thisSpe}','{thisSubspe}','{dateHatching.Value.ToString("yyyy-MM-dd")}" +
                    $"','{cmbBirdGender.Text}','{cageNum}','{cmbOtherGender.Text}','" +
                    $"{sNumber.ToString()}','{babyColors[0]}','{babyColors[1]}','{babyColors[2]}')";
                // open new SQL(data, connection)
                con.Open();
                //add data to table
                cmd = new SqlCommand(addtotable, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else
            {
                string[] babyColors = GetBabyColors(babyGender, thisHeadC, thisBreastC,
                    thisBodyC, otherHeadC, otherBreastC, otherBodyC);
                string addtotable = $"insert into BirdsTable values('{txtSN.Text}','" +
                    $"{otherSpe}','{otherSubeSpe}','{dateHatching.Value.ToString("yyyy-MM-dd")}" +
                    $"','{cmbBirdGender.Text}','{cageNum}','{sNumber.ToString()}','" +
                    $"{cmbOtherGender.Text}','{babyColors[0]}','{babyColors[1]}','{babyColors[2]}')";
                // open new SQL(data, connection)
                con.Open();
                //add data to table
                cmd = new SqlCommand(addtotable, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Successfully Saved", "Bird Added"
            , MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtSN.Text = "Serial Number";
            txtSN.ForeColor = Color.Gray;
            dateHatching.CustomFormat = "'Select Date'";
            dateHatching.Format = DateTimePickerFormat.Custom;
            dateHatching.MaxDate = DateTime.Now;
            cmbBirdGender.SelectedIndex = 0;
        }

        private void dateHatching_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;

            // Update the format and text when a date is selected
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.CustomFormat = "dd-MM-yyyy";
            dateTimePicker.Text = dateTimePicker.Value.ToString("dd-MM-yyyy");
        }

        private void btnEditBird_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnEditBird.Text = "Restroe";
            CagesArray();
            cmbCages.Text = cageNum;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string cageN = cmbCages.Text;
            bool flag = false;

            string updateQuery = "UPDATE BirdsTable SET ";
            if (cageNum != cageN)
            {
                updateQuery += $"Cage_Number = '{cageN}'";
                flag = true;
            }
            if (flag == true)
            {
                updateQuery += $" WHERE Serial_Number = '{sNumber}'";
                con.Open();
                SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                updateCmd.ExecuteNonQuery();
                con.Close();
            }
            MessageBox.Show("Successfully Update", "Bird Update"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);

            lblCageNum.Text = cageN;
            lblCageNum.Visible = true;
            cmbCages.Visible = false;
            btnEditBird.Text = "Edit Bird";
            panelCgaes.Visible = true;
            btnUpdate.Visible = false;
        }
    }
}
