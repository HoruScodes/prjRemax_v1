using prjRemax.DataLayer;
using System;
using System.Windows.Forms;

namespace prjRemax.GUI
{
    public partial class frmSearchHouse : Form
    {
        public frmSearchHouse()
        {
            InitializeComponent();
        }

        private void frmSearchHouse_Load(object sender, EventArgs e)
        {
            chkHouseRef.Checked = false;
            comboBoxHouseID.Enabled = false;
            clsHouseData.setHouseData(comboBoxHouseID);
            clsHouseData.setHouseDataGrid("all", dataGridViewHouse);
        }

        private void chkHouseRef_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHouseRef.Checked == true)
            {
                comboBoxHouseID.Enabled = true;
            }
            else if (chkHouseRef.Checked == false)
            {
                comboBoxHouseID.Enabled = false;
                clsHouseData.setHouseDataGrid("all", dataGridViewHouse);
            }
        }

        private void comboBoxHouseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedHouseID = comboBoxHouseID.SelectedItem.ToString();
            clsHouseData.setHouseDataGrid(selectedHouseID, dataGridViewHouse);
        }
    }
}
