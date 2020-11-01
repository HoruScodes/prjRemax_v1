using prjRemax.Business;
using prjRemax.DataLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjRemax.GUI
{
    public partial class frmClient : Form
    {
        private bool updatemode = false;
        private int latestCLientId = 6;
        public frmClient()
        {
            InitializeComponent();
        }

        private void lblAdminId_Click(object sender, EventArgs e)
        {

        }

        public void setClientData()
        {
            if (frmLogin.Usermode == "Agent")
            {
                comboBoxAgent.Items.Clear();
                comboBoxAgent.Items.Add(frmLogin.currentName);
                comboBoxAgent.Enabled = false;
            }
            else
            {
                foreach (KeyValuePair<string, clsAgent> agent in clsAgentData.agentData)
                {
                    comboBoxAgent.Items.Add(agent.Value.Name);

                }
                foreach (KeyValuePair<string, clsAdmin> admin in clsAdminData.adminData)
                {
                    comboBoxAgent.Items.Add(admin.Value.Name);

                }
            }
        }

        private void frmClient_Load(object sender, EventArgs e)
        {

            disableFields(true, true, true, true, true, true, true, false, true, true, true, true);
            clsClientData.setData(listClient, dataGridViewClient);
            setClientData();
        }

        private void disableFields(bool id, bool name, bool email, bool pass, bool phone, bool clienttype, bool agentname, bool addbutton, bool deletebutton, bool updatebutton, bool cancelbutton, bool savebutton)
        {
            txtId.Enabled = !id;
            txtName.Enabled = !name;
            txtEmail.Enabled = !email;
            txtPassword.Enabled = !pass;
            txtPhone.Enabled = !phone;
            btnAdd.Enabled = !addbutton;
            btnCancel.Enabled = !cancelbutton;
            btnDelete.Enabled = !deletebutton;
            btnSave.Enabled = !savebutton;
            btnUpdate.Enabled = !updatebutton;
            comboBoxClientType.Enabled = !clienttype;
            comboBoxAgent.Enabled = !agentname;
        }

        private void listClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = listClient.SelectedItem.ToString();
            foreach (KeyValuePair<string, clsClient> data in clsClientData.clientData)
            {
                if (data.Value.Name == selectedName)
                {
                    disableFields(true, true, true, true, true, true, true, false, false, false, true, true);
                    txtId.Text = data.Value.Id;
                    txtName.Text = data.Value.Name;
                    txtEmail.Text = data.Value.Email;
                    txtPassword.Text = data.Value.Password;
                    txtPhone.Text = data.Value.Phone;
                    comboBoxClientType.SelectedItem = data.Value.clientType;
                    comboBoxAgent.SelectedItem = data.Value.ParentName;
                }
            }
        }

        private void comboBoxClientType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            updatemode = false;
            clearFields();
            txtId.Text = "cl" + (latestCLientId + 1).ToString();
            disableFields(true, false, false, false, false, false, true, true, true, true, false, false);
        }

        private void clearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtId.Focus();
            comboBoxAgent.SelectedItem = frmLogin.currentName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateData.isNameValid(txtName) && validateData.isEmailValid(txtEmail) && validateData.isPhoneNumberValid(txtPhone) && validateData.isComboBoxSelected(comboBoxClientType))
            {
                clsClient newClient = new clsClient(txtId.Text, txtName.Text, txtEmail.Text, txtPhone.Text, txtPassword.Text, comboBoxClientType.SelectedItem.ToString(), frmLogin.Usermode, frmLogin.currentName, frmLogin.currentId);
                if (updatemode)
                {
                    if (clsClientData.updateClient(newClient))
                    {
                        MessageBox.Show("successfully updated Client : " + txtName.Text + " in the system!");
                        ReloadForm();
                    }
                }
                else
                {
                    if (clsClientData.AddClient(newClient))
                    {
                        MessageBox.Show("successfully added Client : " + txtName.Text + " in the system!");
                        latestCLientId += 1;
                        ReloadForm();
                    }
                    else
                    {
                        MessageBox.Show("the Client with the email: " + txtEmail.Text + " exist in the system!");
                        txtEmail.Focus();
                    }
                }
            }

        }

        private void ReloadForm()
        {
            clearFields();
            disableFields(true, true, true, true, true, true, true, false, true, true, true, true);
            clsClientData.setData(listClient, dataGridViewClient);
            setClientData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatemode = true;
            txtName.Focus();
            disableFields(true, false, false, false, false, false, true, true, true, true, false, false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete Client " + txtEmail.Text + " ?", "DELETE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (clsClientData.removeClient(txtEmail.Text))
                {
                    MessageBox.Show("Deleted");
                    ReloadForm();
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true; // blocking the caracter typed by the key
            }
        }
    }
}
