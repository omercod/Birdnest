using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using WpfGif;
using System.Windows.Forms.Integration;
using System.IO;

namespace TheBirdNest
{
    public partial class UserControlBirdSearch : UserControl
    {
        private SqlConnection con;
        private Control parentControl;
        private string gifFileName = "ezgif.com-resize.gif";

        public Control ParentControl
        {
            get { return parentControl; }
            set { parentControl = value; }
        }

        public UserControlBirdSearch()
        {
            InitializeComponent();
            con = new SqlConnection(findCon());
            // Set the default text for the DateTimePicker control
            dateHatching.CustomFormat = "'Select Date'";
            dateHatching.Format = DateTimePickerFormat.Custom;
            cmbBirdSpe.SelectedIndex = 0;
            cmbBirdGender.SelectedIndex = 0;
            dataSearchBird.Visible = false;
            dateHatching.MaxDate = DateTime.Now;
            dateHatching.CalendarMonthBackground = Color.AntiqueWhite;
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

        private void UserControlBirdSearch_Load(object sender, EventArgs e)
        {
            // Get the base directory of the application
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the base directory with the GIF file name
            string gifPath = Path.Combine(baseDirectory, gifFileName);

            // Clear the BackgroundImage property of the PictureBox
            picBirdsGif.BackgroundImage = null;

            // Create a new instance of the Bitmap class with the path to the GIF file
            var gifImage = new System.Drawing.Bitmap(gifPath);

            // Set the Image property of the PictureBox to the GIF image
            picBirdsGif.Image = gifImage;
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

        private void btnToSearchBird_Click(object sender, EventArgs e)
        {
            dataSearch();
            picBirdsGif.Visible = false;
        }

        public void dataSearch()
        {
            DataTable data = advancedSearchData();
            // Check if i got one row in the search or more
            if (data.Rows.Count == 1)
            {
                // Only one row found
                // Retrieve the serial number from the first row
                int serialNumber = (int)data.Rows[0]["S.N"];
                Form home = this.FindForm();
                UserControlBirdInfo birdInfo = new UserControlBirdInfo(serialNumber);
                Point currentLocation = this.Location;
                birdInfo.Location = currentLocation;
                // Find the parent form or container control
                Control parentControl = this.Parent; // Replace "Control" with the appropriate parent control type                                  // Add the new user control to the parent control's collection of controls
                parentControl.Controls.Add(birdInfo);
                // Bring the new user control to the front
                birdInfo.BringToFront();
            }
            else
            {
                dataSearchBird.DataSource = advancedSearchData();
                dataSearchBird.EnableHeadersVisualStyles = false;
                dataSearchBird.ColumnHeadersDefaultCellStyle.BackColor = Color.AntiqueWhite;
                dataSearchBird.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dataSearchBird.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataSearchBird.ColumnHeadersDefaultCellStyle.Font = new Font("Sans Serif Collection", 5, FontStyle.Bold);
                dataSearchBird.DefaultCellStyle.Font = new Font("Sans Serif", 10, FontStyle.Regular);
                dataSearchBird.ReadOnly = true;
                dataSearchBird.Visible = true;
                dataSearchBird.CellClick += DataSearchBird_CellClick;
            }
        }
        public void PopulateDataGridView()
        {
            // Clear existing data in the DataGridView
            picBirdsGif.Visible = false;
            dataSearchBird.DataSource = null;
            dataSearchBird.Rows.Clear();
            dataSearchBird.Columns.Clear();

            // Retrieve data from the database or any other source
            DataTable data = advancedSearchData();

            // Set the DataGridView's DataSource to the retrieved data
            dataSearchBird.DataSource = data;
            dataSearchBird.AutoResizeColumns();
            dataSearchBird.Refresh();
        }

        private DataTable advancedSearchData()
        {
            DataTable dataTable = new DataTable();
            //
            string query = "SELECT * FROM BirdsTable WHERE 1=1";

            // Parameters for filtering
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Add search conditions dynamically
            if (txtSN.Text != "" && txtSN.Text != "Serial Number")
            {
                try
                {
                    parameters.Add(new SqlParameter("@SerialNumber", int.Parse(txtSN.Text)));
                    query += $" AND Serial_Number = '{txtSN.Text}'"; 
                }
                catch
                {
                    query += $" AND Serial_Number = '12314'";
                }
             
                    
            }

            if (dateHatching.CustomFormat != "'Select Date'")
            {
                query += $" AND Hatching_Date = '{dateHatching.Value.ToString("yyyy-MM-dd")}'";
                parameters.Add(new SqlParameter("@HatchingDate", dateHatching.Value.ToString("yyyy-MM-dd")));
            }

            if (cmbBirdSpe.SelectedIndex != 0)
            {
                query += $" AND CONVERT(varchar(MAX), Bird_Species) = '{cmbBirdSpe.Text}'";
                parameters.Add(new SqlParameter("@Species", cmbBirdSpe.Text));
            }

            if (cmbBirdGender.SelectedIndex != 0)
            {
                query += $" AND CONVERT(varchar(MAX), Bird_Gender) = '{cmbBirdGender.Text}'";
                parameters.Add(new SqlParameter("@Gender", cmbBirdGender.Text));
            }

            // Open new SQL(data, connection)
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddRange(parameters.ToArray());


            // Add columns to the DataTable
            dataTable.Columns.Add("S.N", typeof(int));
            dataTable.Columns.Add("Species", typeof(string));
            dataTable.Columns.Add("Hatching Date", typeof(string));
            dataTable.Columns.Add("Gender", typeof(string));
            dataTable.Columns.Add("Cage Number", typeof(string));
            DataRow row;
            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            {
               using (SqlDataReader reader = command.ExecuteReader())
               {
                        while (reader.Read())
                        {
                            // Add rows to the DataTable
                            row = dataTable.NewRow();
                            row["S.N"] = reader.GetInt32(0);
                            row["Species"] = reader.GetString(1);
                            row["Hatching Date"] = reader.GetDateTime(3).ToShortDateString();
                            row["Gender"] = reader.GetString(4);
                            row["Cage Number"] = reader.GetString(5);
                            dataTable.Rows.Add(row);
                    }
               }
            }
            con.Close();
            return dataTable;
        }

        //Row in the table clicked and preform the bird.
        private bool cellClickHandled = false;

        private void DataSearchBird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell belongs to a specific column (e.g., "S.N" column)
            if (e.RowIndex >= 0 && e.ColumnIndex == dataSearchBird.Columns["S.N"].Index)
            {
                // Check if the event has already been handled
                if (!cellClickHandled)
                {
                    // Set the flag to indicate that the event has been handled
                    cellClickHandled = true;

                    try
                    {
                        // Get the value of the clicked cell
                        int snValue = (int)dataSearchBird.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        Form home = this.FindForm();
                        UserControlBirdInfo birdInfo = new UserControlBirdInfo(snValue);
                        Point currentLocation = this.Location;
                        birdInfo.Location = currentLocation;
                        // Find the parent form or container control
                        Control parentControl = this.Parent; // Replace "Control" with the appropriate parent control type
                                                             // Add the new user control to the parent control's collection of controls
                        parentControl.Controls.Add(birdInfo);
                        // Bring the new user control to the front
                        birdInfo.BringToFront();
                    }
                    catch
                    {
                        return;
                    }

                }
            }
        }

        private void DataSearchBird_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Reset the flag on mouse down event to allow handling the cell click again
            cellClickHandled = false;
        }

        private void dateHatching_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)sender;

            // Update the format and text when a date is selected
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.CustomFormat = "dd-MM-yyyy";
            dateTimePicker.Text = dateTimePicker.Value.ToString("dd-MM-yyyy");
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            txtSN.Text = "Serial Number";
            txtSN.ForeColor = Color.Gray;
            dateHatching.CustomFormat = "'Select Date'";
            dateHatching.Format = DateTimePickerFormat.Custom;
            cmbBirdSpe.SelectedIndex = 0;
            cmbBirdGender.SelectedIndex = 0;
        }
    }

}
