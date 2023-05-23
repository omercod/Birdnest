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

namespace TheBirdNest
{
    public partial class UserControlSearchCage : UserControl
    {
        private SqlConnection con;
        public UserControlSearchCage()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;
            AttachDbFilename=C:\Users\OMCL9\Source\Repos\TheBirdNest\TheBirdNest\BirdNestDB.mdf;
            Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
            ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            dataSearchCage.Visible = false;
            cmbCgaeMat.SelectedIndex = 0;
        }

        private void txtSN_Enter(object sender, EventArgs e)
        {
            if (txtSN.Text == "")
            {
                txtSN.Text = "Cage Number";
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
                txtSN.Text = "Cage Number";
                txtSN.ForeColor = Color.Gray;
            }
        }

        private void btnToSearchCage_Click(object sender, EventArgs e)
        {
            dataSearch();
        }

        public void dataSearch()
        {
            DataTable data = advancedSearchData();
            // Check if i got one row in the search or more
            if (data.Rows.Count == 1)
            {
                // Only one row found
                // Retrieve the serial number from the first row
                string CageNum = (string)data.Rows[0]["Cage N."];
                Form home = this.FindForm();
                UserControlCageInfo cageInfo = new UserControlCageInfo(CageNum);
                Point currentLocation = this.Location;
                cageInfo.Location = currentLocation;
                // Find the parent form or container control
                Control parentControl = this.Parent; // Replace "Control" with the appropriate parent control type                                  // Add the new user control to the parent control's collection of controls
                parentControl.Controls.Add(cageInfo);
                // Bring the new user control to the front
                cageInfo.BringToFront();
            }
            else
            {
                dataSearchCage.DataSource = advancedSearchData();
                dataSearchCage.EnableHeadersVisualStyles = false;
                dataSearchCage.ColumnHeadersDefaultCellStyle.BackColor = Color.AntiqueWhite;
                dataSearchCage.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dataSearchCage.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataSearchCage.ColumnHeadersDefaultCellStyle.Font = new Font("Sans Serif Collection", 5, FontStyle.Bold);
                dataSearchCage.DefaultCellStyle.Font = new Font("Sans Serif", 10, FontStyle.Regular);
                dataSearchCage.ReadOnly = true;
                dataSearchCage.Visible = true;
                dataSearchCage.CellClick += DataSearchBird_CellClick;
            }
        }

        private DataTable advancedSearchData()
        {
            DataTable dataTable = new DataTable();
            //
            string query = "SELECT * FROM CagesTable WHERE 1=1";

            // Parameters for filtering
            List<SqlParameter> parameters = new List<SqlParameter>();

            // Add search conditions dynamically
            if (txtSN.Text != "" && txtSN.Text != "Cage Number")
            {
                query += $" AND CONVERT(varchar(MAX), Cage_Number) = '{txtSN.Text}'";
                parameters.Add(new SqlParameter("@CageNumber", txtSN.Text));
            }

            if (cmbCgaeMat.SelectedIndex != 0)
            {
                query += $" AND CONVERT(varchar(MAX), Cage_Material) = '{cmbCgaeMat.Text}'";
                parameters.Add(new SqlParameter("@Material", cmbCgaeMat.Text));
            }

            // Open new SQL(data, connection)
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddRange(parameters.ToArray());
            // Add columns to the DataTable
            dataTable.Columns.Add("Cage N.", typeof(string));
            dataTable.Columns.Add("Length", typeof(string));
            dataTable.Columns.Add("Width", typeof(string));
            dataTable.Columns.Add("High", typeof(string));
            dataTable.Columns.Add("Material", typeof(string));
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
                        row["Cage N."] = reader.GetString(0);
                        row["Length"] = reader.GetString(1) + " cm";
                        row["Width"] = reader.GetString(2) + " cm";
                        row["High"] = reader.GetString(3) + " cm";
                        row["Material"] = reader.GetString(4);
                        dataTable.Rows.Add(row);
                    }
                }
            }
            con.Close();

            // Sort the DataTable by Cage Number column
            dataTable.DefaultView.Sort = "Cage N. ASC";
            dataTable = dataTable.DefaultView.ToTable();

            return dataTable;
        }

        //Row in the table clicked and preform the cage.
        private bool cellClickHandled = false;

        private void DataSearchBird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell belongs to a specific column (e.g., "S.N" column)
            if (e.RowIndex >= 0 && e.ColumnIndex == dataSearchCage.Columns["Cage N."].Index)
            {
                // Check if the event has already been handled
                if (!cellClickHandled)
                {
                    // Set the flag to indicate that the event has been handled
                    cellClickHandled = true;

                    try
                    {
                        // Get the value of the clicked cell
                        string cageNum = (string)dataSearchCage.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                        Form home = this.FindForm();
                        UserControlCageInfo cageInfo = new UserControlCageInfo(cageNum);
                        Point currentLocation = this.Location;
                        cageInfo.Location = currentLocation;
                        // Find the parent form or container control
                        Control parentControl = this.Parent; // Replace "Control" with the appropriate parent control type
                                                             // Add the new user control to the parent control's collection of controls
                        parentControl.Controls.Add(cageInfo);
                        // Bring the new user control to the front
                        cageInfo.BringToFront();
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
        // refresh the data table
        public void PopulateDataGridView()
        {
            // Clear existing data in the DataGridView
            dataSearchCage.DataSource = null;
            dataSearchCage.Rows.Clear();
            dataSearchCage.Columns.Clear();

            // Retrieve data from the database or any other source
            DataTable data = advancedSearchData();

            // Set the DataGridView's DataSource to the retrieved data
            dataSearchCage.DataSource = data;
            dataSearchCage.Refresh();
        }


        private void picRefresh_Click(object sender, EventArgs e)
        {
            txtSN.Text = "Cage Number";
            txtSN.ForeColor = Color.Gray;
            cmbCgaeMat.SelectedIndex = 0;
        }
    }
}
