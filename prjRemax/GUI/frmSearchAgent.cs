using prjRemax.DataLayer;
using System;
using System.Windows.Forms;

namespace prjRemax.GUI
{
    public partial class frmSearchAgent : Form
    {
        public frmSearchAgent()
        {
            InitializeComponent();
        }

        private void frmSearchAgent_Load(object sender, EventArgs e)
        {
            chkAgentID.Checked = false;
            comboBoxAgentID.Enabled = false;
            clsAgentData.setAgentData(comboBoxAgentID);
            clsAgentData.setAgentsDataGrid("all", GridAgent);
        }

        private void chkAgentID_CheckedChanged(object sender, EventArgs e)
        {


            if (chkAgentID.Checked == true)
            {
                comboBoxAgentID.Enabled = true;
            }
            else if (chkAgentID.Checked == false)
            {
                comboBoxAgentID.Enabled = false;
                clsAgentData.setAgentsDataGrid("all", GridAgent);
            }
        }

        private void comboBoxAgentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedAgentID = comboBoxAgentID.SelectedItem.ToString();
            clsAgentData.setAgentsDataGrid(selectedAgentID, GridAgent);
        }

    }
}
