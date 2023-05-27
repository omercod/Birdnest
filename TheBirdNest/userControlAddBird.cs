using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
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
        public string userID { get; set; }
        public string[] cageNumbers;
        private SqlConnection con;
        public userControlAddBird()
        {
            InitializeComponent();
            dateBirdHatchingDate.MaxDate = DateTime.Now;
            dateBirdHatchingDate.Value = DateTime.Now;
            con = new SqlConnection(findCon());
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
            string sNumber = txtSerialNumberBird.Text;
            if (sNumber.Length != sNumber.Count(c => Char.IsNumber(c)) || sNumber.Length == 0)
            {
                MessageBox.Show("Serial number contains only numbers!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxBirdSpe.SelectedIndex == -1 || comboBoxBirdSubSpe.SelectedIndex == -1
            || cmbBirdGender.SelectedIndex == -1 || cmbHeadColor.SelectedIndex == -1 ||
                cmbBreastColor.SelectedIndex == -1 || cmbBodyColor.SelectedIndex == -1)
            {
                MessageBox.Show("All the Comboboxes must be selected!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if BirdParent
            if(txtBirdMotherSN.Text == "Only for baby bird")
            {
                txtBirdMotherSN.Text = "";
                txtBirdFatherSerialNumber.Text = "";
            }

            string addtotable = $"insert into BirdsTable values('{txtSerialNumberBird.Text}','" +
                $"{comboBoxBirdSpe.Text}','" +
                $"{comboBoxBirdSubSpe.Text}','{dateBirdHatchingDate.Value.ToString("yyyy-MM-dd")}" +
                $"','{cmbBirdGender.Text}','{cmbCagesNumber.Text}','" +
                $"{txtBirdFatherSerialNumber.Text}','{txtBirdMotherSN.Text}','{cmbHeadColor.Text}" +
                $"','{cmbBreastColor.Text}','{cmbBodyColor.Text}')";
            string snExist = $"SELECT COUNT(*) FROM BirdsTable WHERE" +
                $" Serial_Number = '{txtSerialNumberBird.Text.ToString()}'";
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
            //add data to table
            cmd = new SqlCommand(addtotable, con);
            cmd.ExecuteNonQuery();
            con.Close();
            //Reset the input
            txtSerialNumberBird.Text = "";
            comboBoxBirdSpe.SelectedIndex = -1;
            comboBoxBirdSubSpe.SelectedIndex = -1;
            dateBirdHatchingDate.MaxDate = DateTime.Now;
            cmbBirdGender.SelectedIndex = -1;
            cmbCagesNumber.SelectedIndex = -1;
            cmbBodyColor.SelectedIndex = -1;
            cmbBreastColor.SelectedIndex = -1;
            cmbHeadColor.SelectedIndex = -1;
            txtBirdFatherSerialNumber.Text = "Only for baby bird";
            txtBirdMotherSN.Text = "Only for baby bird";

            MessageBox.Show("Bird was added Successfully", "Bird Added"
            , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxBabyBird_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBabyBird.Checked)
            {
                cmbHeadColor.Enabled = false;
                cmbBreastColor.Enabled = false;
                cmbBodyColor.Enabled = false;
                comboBoxBirdSpe.Enabled = false;
                comboBoxBirdSubSpe.Enabled = false;
                cmbCagesNumber.Enabled = false;
                cmbCagesNumber.SelectedIndex = -1;
                txtBirdFatherSerialNumber.Text = "";
                txtBirdMotherSN.Text = "";
                txtBirdFatherSerialNumber.Enabled = true;
                txtBirdMotherSN.Enabled = true;
                cmbBodyColor.SelectedIndex = -1;
                cmbBreastColor.SelectedIndex = -1;
                cmbHeadColor.SelectedIndex = -1;
            }
            else
            {
                cmbHeadColor.Enabled = true;
                cmbBreastColor.Enabled = true;
                cmbBodyColor.Enabled = true;
                comboBoxBirdSpe.Enabled = true;
                comboBoxBirdSubSpe.Enabled = true;
                cmbCagesNumber.Enabled = true;
                txtBirdFatherSerialNumber.Enabled = false;
                txtBirdFatherSerialNumber.Text = "Only for baby bird";
                txtBirdMotherSN.Text = "Only for baby bird";
                txtBirdMotherSN.Enabled = false;
            }
        }

        private void userControlAddBird_MouseMove(object sender, MouseEventArgs e)
        {
            if (cmbCagesNumber.SelectedIndex != -1 && cmbCagesNumber.SelectedIndex != 0)
                return;
            if (checkBoxBabyBird.Checked)
            {
                cmbCagesNumber.Enabled = false;
                cmbCagesNumber.SelectedIndex = -1;
                return;
            }
            // get the cage list.
            // Open the SQL connection
            con.Open();
            // Define the SQL query to retrieve the cage numbers
            string query = "SELECT Cage_Number FROM CagesTable";
            // Create a list to store the cage numbers
            List<string> cageNumbersList = new List<string>();
            // Execute the SQL query and retrieve the cage numbers
            SqlCommand cmd = new SqlCommand(query, con);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Add each cage number to the list
                    string cageNumber = reader.GetString(0);
                    cageNumbersList.Add(cageNumber);
                }
            }
            // Convert the list of cage numbers to a string array
            // Close the SQL connection
            con.Close();
            cageNumbers = cageNumbersList.ToArray();
            if (cageNumbersList.Count != 0)
            {
                cmbCagesNumber.Enabled = true;
                cmbCagesNumber.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbCagesNumber.DataSource = cageNumbers;
            }
        }

        //For Baby Bird.
        private void btnOKforParent_Click(object sender, EventArgs e)
        {
            //Errors
            string fatherSnExist = $"SELECT Bird_Gender,Cage_Number FROM BirdsTable WHERE Serial_Number = '{txtBirdFatherSerialNumber.Text}'";
            string motherSnExist = $"SELECT Bird_Gender,Cage_Number FROM BirdsTable WHERE Serial_Number = '{txtBirdMotherSN.Text}'";
            string gender = "Unknown";
            string motherCage = "", fatherCage = "";
            //Check if Father S.N exist.
            // open new SQL(data, connection)
            SqlCommand cmd = new SqlCommand(fatherSnExist, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                gender = reader["Bird_Gender"].ToString();
                fatherCage = reader["Cage_Number"].ToString();
                // Use birdSpe and birdSubSpe as needed
            }
            reader.Close();
            // if Serial Number is exsit in the table send message.
            if (gender == "Unknown" || gender == "Female")
            {
                MessageBox.Show("Father S.N was not found!", "Error"
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            con.Close();
            gender = "Unknown";
            //Check if Mother S.N exist.
            // open new SQL(data, connection)
            cmd = new SqlCommand(motherSnExist, con);
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                gender = reader["Bird_Gender"].ToString();
                motherCage = reader["Cage_Number"].ToString();
                // Use birdSpe and birdSubSpe as needed
            }
            reader.Close();
            // if Serial Number is exsit in the table send message.
            if (gender == "Unknown" || gender == "Male")
            {
                MessageBox.Show("Mother S.N was not found!", "Error"
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            if (fatherCage != motherCage)
            {
                MessageBox.Show("Bird parents not in the same cgae!", "Error"
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            con.Close();

            //all good and put the automatic valuse of the mother for baby bird.
            string babyGender, fatherHead ="", fatherBreast ="", fatherBody ="", motherHead= "",
                motherBreast = "",motherBody = "";
            DateTime dateMother = DateTime.MinValue;
            DateTime dateBaby = dateBirdHatchingDate.Value;
            string motherValues = $"SELECT Bird_Species, Hatching_Date, Sub_Species, Cage_Number,Head_Color," +
                $" Breast_Color, Body_Color" +
                $" FROM BirdsTable WHERE Serial_Number = '{txtBirdMotherSN.Text}'";
            cmd = new SqlCommand(motherValues, con);
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                comboBoxBirdSpe.Text = reader["Bird_Species"].ToString();
                comboBoxBirdSubSpe.Text = reader["Sub_Species"].ToString();
                cmbCagesNumber.Text = reader["Cage_Number"].ToString();
                dateMother = DateTime.Parse(reader["Hatching_Date"].ToString());
                motherHead = reader["Head_Color"].ToString();
                motherBreast = reader["Breast_Color"].ToString();
                motherBody = reader["Body_Color"].ToString();
                comboBoxBirdSubSpe.Enabled = false;
                // Use birdSpe and birdSubSpe as needed
            }
            reader.Close();
            con.Close();

            //Bonus - colors

            //Get the father colors
            //all good and put the automatic valuse of the mother for baby bird.
            string fatherValues = $"SELECT Head_Color, Hatching_Date, Breast_Color, Body_Color" +
                $" FROM BirdsTable WHERE Serial_Number = '{txtBirdFatherSerialNumber.Text}'";
            DateTime dateFather = DateTime.MinValue;
            cmd = new SqlCommand(fatherValues, con);
            con.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                fatherHead = reader["Head_Color"].ToString();
                fatherBreast = reader["Breast_Color"].ToString();
                fatherBody = reader["Body_Color"].ToString();
                dateFather = DateTime.Parse(reader["Hatching_Date"].ToString());
                // Use birdSpe and birdSubSpe as needed
            }
            if (cmbBirdGender.Text == "")
            {
                MessageBox.Show("Must select bird gender first", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            if (dateBaby > dateFather || dateBaby > dateMother)
            {
                MessageBox.Show($"Must select baby bird date after the parents date\n\n" +
                    $"Father Date: {dateFather.ToString("dd-MM-yyyy")}\n" +
                    $"Mother Date: {dateMother.ToString("dd-MM-yyyy")}", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            babyGender = cmbBirdGender.Text;
            string[] babyColors = GetBabyColors(babyGender, fatherHead, fatherBreast, fatherBody, motherHead, motherBreast,
                motherBody);
            reader.Close();
            con.Close();
            cmbHeadColor.Text = babyColors[0];
            cmbBreastColor.Text = babyColors[1];
            cmbBodyColor.Text = babyColors[2];
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
    }
}
