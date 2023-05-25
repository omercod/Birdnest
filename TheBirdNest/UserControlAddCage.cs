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
using System.IO;

namespace TheBirdNest
{
    public partial class UserControlAddCage : UserControl
    {
        public string userID { get; set; }
        public int cageIndex;
        private SqlConnection con;
        public UserControlAddCage()
        {
            InitializeComponent();
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

        private void UserControlAddCage_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCage_Click(object sender, EventArgs e)
        {
            string cageN = txtSerialNumberCage.Text;
            string cageLen = txtCageLength.Text;
            string cageWidth = txtCageWitdh.Text;
            string cageHigh = txtCageHigh.Text;

            if (cageN.Length == 0 || cageN.Count(c => Char.IsNumber(c)) == 0
    ||         cageN.Count(c => Char.IsLetter(c)) == 0)
            {
                MessageBox.Show("Cage number contains numbers and letters!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cageLen.Length == 0 || cageLen.Count(c => Char.IsLetter(c)) != 0
                || float.Parse(cageLen) <= 0)
            {
                MessageBox.Show("Cage length must be bigger than 0!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cageWidth.Length == 0 || cageWidth.Count(c => Char.IsLetter(c)) != 0
                || float.Parse(cageWidth) <= 0)
            {
                MessageBox.Show("Cage width must be bigger than 0!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cageHigh.Length == 0 || cageHigh.Count(c => Char.IsLetter(c)) != 0
                || float.Parse(cageHigh) <= 0)
            {
                MessageBox.Show("Cage high must be bigger than 0!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbCageMat.SelectedIndex == -1)
            {
                MessageBox.Show("Cage materials must be selected!", "Error"
                , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Open the SQL connection
            con.Open();
            // Define the SQL query to count the rows
            string query = "SELECT COUNT(*) FROM CagesTable";
            // Execute the SQL query and retrieve the row count
            SqlCommand cmd = new SqlCommand(query, con);
            cageIndex = (int)cmd.ExecuteScalar();

            // Close the SQL connection
            con.Close();

            string addtotable = $"INSERT INTO CagesTable VALUES ('{cageN}', '{cageLen}', " +
                $"'{cageWidth}', '{cageHigh}', '{cmbCageMat.Text}', '{cageIndex}')";
            string snExist = $"SELECT COUNT(*) FROM CagesTable WHERE CONVERT(varchar(MAX), Cage_Number) = '{cageN}'";
            // open new SQL(data, connection)
            con.Open();
            cmd = new SqlCommand(snExist, con);
            int count = (int)cmd.ExecuteScalar();
            // If the cage number exists, show an error message
            if (count > 0)
            {
                MessageBox.Show("Cage number already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return;
            }
            //add data to table
            cmd = new SqlCommand(addtotable, con);
            cmd.ExecuteNonQuery();
            con.Close();
            // reset the inputs
            txtSerialNumberCage.Text = "";
            txtCageLength.Text = "";
            txtCageWitdh.Text = "";
            txtCageHigh.Text = "";
            cmbCageMat.SelectedIndex = -1;
            MessageBox.Show("Successfully Saved", "Cage Added"
            , MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
