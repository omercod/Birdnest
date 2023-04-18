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
    public partial class userControlAddBird : UserControl
    {
        string[] arrAmerica = {"North America", "Central America", "South America"};
        string[] arrEurope = {"West Europe", "East Europe" };
        string[] arrAustralia = {"Central Australia", "Coastal Cities"};
        public userControlAddBird()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddBird_TextChanged(object sender, EventArgs e)
        {

        }

        private void userControlAddBird_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxBirdSpe_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxBirdSpe.SelectedIndex)
            {
                case 0:
                    comboBoxBirdSubSpe.Items.Clear();
                    comboBoxBirdSubSpe.Items.AddRange(arrAmerica);
                    break;
                case 1:
                    comboBoxBirdSubSpe.Items.Clear();
                    comboBoxBirdSubSpe.Items.AddRange(arrEurope);
                    break;
                case 2:
                    comboBoxBirdSubSpe.Items.Clear();
                    comboBoxBirdSubSpe.Items.AddRange(arrAustralia);
                    break;
            }
        }
    }
}
