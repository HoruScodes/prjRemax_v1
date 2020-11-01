using prjRemax.DataLayer;
using prjRemax.GUI;
using System;
using System.Windows.Forms;

namespace prjRemax
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            grpboxLogin.Hide();
            txtPassword.PasswordChar = '*';
            new clsAdminData();
            new clsAgentData();
            new clsClientData();
            new clsHouseData();
            new clsSalesData();

        }

        public static string usermode = "";
        public static string currentId = "";
        public static string currentName = "";
        public static string Usermode
        {
            get { return usermode; }
            set { usermode = value; }
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Usermode = "Client";

            //frmMain fr = new frmMain();
            //fr.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
            Usermode = "Admin";
            grpboxLogin.Show();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
            Usermode = "Agent";
            grpboxLogin.Show();
        }

        private void btnUser_Click_1(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
            Usermode = "User";
            grpboxLogin.Hide();
            MessageBox.Show("welcome " + Usermode + " !");
            frmMain fr = new frmMain();
            fr.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (usermode == "Admin")
            {
                string status = clsAdminData.loginAdmin(txtEmail.Text, txtPassword.Text);
                if (status == txtEmail.Text)
                {
                    grpboxLogin.Hide();
                    MessageBox.Show("welcome Admin : " + status + " !");
                    currentId = clsAdminData.getData(txtEmail.Text).Id;
                    currentName = clsAdminData.getData(txtEmail.Text).Name;
                    frmMain fr = new frmMain();
                    fr.ShowDialog();
                }
                else if (status == "pwdErr")
                {
                    MessageBox.Show("Wrong Password, Try Again!");
                }
                else if (status == "notFoundErr")
                {
                    MessageBox.Show("it appears that this account does not exist in our system!");
                }
            }
            else if (usermode == "Agent")
            {
                string status = clsAgentData.loginAgent(txtEmail.Text, txtPassword.Text);
                if (status == txtEmail.Text)
                {
                    grpboxLogin.Hide();
                    currentId = clsAgentData.getData(txtEmail.Text).Id;
                    currentName = clsAgentData.getData(txtEmail.Text).Name;
                    MessageBox.Show("welcome Agent : " + status + " !");
                    frmMain fr = new frmMain();
                    fr.ShowDialog();
                }
                else if (status == "pwdErr")
                {
                    MessageBox.Show("Wrong Password, Try Again!");
                }
                else if (status == "notFoundErr")
                {
                    MessageBox.Show("it appears that this account does not exist in our system!");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
