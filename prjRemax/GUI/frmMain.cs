using System;
using System.Collections;
using System.Windows.Forms;

namespace prjRemax.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (frmLogin.Usermode == "Admin")
            {

            }
            else if (frmLogin.Usermode == "Agent")
            {
                Enable_btn(false, false, false, true, true, false, false);
            }
            else if (frmLogin.Usermode == "User")
            {
                Enable_btn(false, false, false, false, false, true, true);
            }
        }

        private void Enable_btn(bool menuSales, bool menuAdmin, bool menuAgent, bool menuClient, bool menuHouse, bool SearchAgent, bool SearchHouse)
        {
            this.salesTS.Enabled = menuSales;
            this.adminsTS.Enabled = menuAdmin;
            this.agentsTS.Enabled = menuAgent;
            this.clientsTS.Enabled = menuClient;
            this.houseTS.Enabled = menuHouse;
            this.searchagentsTS.Enabled = SearchAgent;
            this.searchhouseToolStripMenuItem.Enabled = SearchHouse;
        }

        private void adminsTS_Click(object sender, EventArgs e)
        {
            frmAdmin adminForm = new frmAdmin();
            adminForm.Show();
        }

        private void agentsTS_Click(object sender, EventArgs e)
        {
            frmAgent agentForm = new frmAgent();
            agentForm.Show();
        }

        private void clientsTS_Click(object sender, EventArgs e)
        {
            frmClient clientForm = new frmClient();
            clientForm.Show();
        }

        private void houseTS_Click(object sender, EventArgs e)
        {
            frmHouse houseForm = new frmHouse();
            houseForm.Show();
        }

        private void salesTS_Click(object sender, EventArgs e)
        {
            frmSales salesForm = new frmSales();
            salesForm.Show();
        }

        private void logOutTS_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Do You Want To LogOut?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                ArrayList openFormsCopy = new ArrayList(Application.OpenForms);
                foreach (Form fm in openFormsCopy)
                {
                    fm.Close();
                }
            }
        }

        private void exitTS_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult = MessageBox.Show("Do You Want To Exit this application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogresult == DialogResult.Yes)
            {
                ArrayList openFormsCopy = new ArrayList(Application.OpenForms);
                foreach (Form fm in openFormsCopy)
                {
                    fm.Close();
                }
            }
        }

        private void searchhouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchHouse formSearchHouse = new frmSearchHouse();
            formSearchHouse.Show();
        }

        private void searchagentsTS_Click(object sender, EventArgs e)
        {
            frmSearchAgent formSearchAgent = new frmSearchAgent();
            formSearchAgent.Show();
        }
    }
}
