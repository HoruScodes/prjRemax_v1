using prjRemax.Business;
using prjRemax.DataLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjRemax.GUI
{
    public partial class frmAdmin : Form
    {
        private static int latestAdminId = 3;
        private bool updatemode = false;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            disableFields(true, true, true, true, true, false, true, true, true, true);

            clsAdminData.setData(listAdmin, dataGridView1);
        }

        private void disableFields(bool id, bool name, bool email, bool pass, bool phone, bool addbutton, bool deletebutton, bool updatebutton, bool cancelbutton, bool savebutton)
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
        }

        private void clearFields()
        {
            txtId.Clear();
            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtId.Clear();
            txtPassword.Clear();
            txtId.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = listAdmin.SelectedItem.ToString();
            foreach (KeyValuePair<string, clsAdmin> data in clsAdminData.adminData)
            {
                if (data.Value.Name == selectedName)
                {
                    disableFields(true, true, true, true, true, false, false, false, true, true);
                    txtId.Text = data.Value.Id;
                    txtName.Text = data.Value.Name;
                    txtEmail.Text = data.Value.Email;
                    txtPassword.Text = data.Value.Password;
                    txtPhone.Text = data.Value.Phone;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            updatemode = false;
            clearFields();
            txtId.Text = "ad" + (latestAdminId + 1).ToString();
            disableFields(true, false, false, false, false, true, true, true, false, false);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete admin " + txtEmail.Text + " ?", "DELETE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (clsAdminData.removeAdmin(txtEmail.Text))
                {
                    MessageBox.Show("Deleted");
                    ReloadForm();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateData.isNameValid(txtName) && validateData.isEmailValid(txtEmail) && validateData.isPhoneNumberValid(txtPhone))
            {
                //string adminId = updatemode == false ? "ad" + (latestAdminId + 1).ToString() : txtId.Text;
                clsAdmin newAdmin = new clsAdmin(txtId.Text, txtName.Text, txtEmail.Text, txtPhone.Text, txtPassword.Text);
                if (updatemode)
                {
                    if (clsAdminData.updateAdmin(newAdmin))
                    {
                        MessageBox.Show("successfully updated admin : " + txtName.Text + " in the system!");
                        ReloadForm();
                    }
                }
                else
                {
                    if (clsAdminData.AddAdmin(newAdmin))
                    {
                        MessageBox.Show("successfully added admin : " + txtName.Text + " in the system!");
                        latestAdminId += 1;
                        ReloadForm();
                    }
                    else
                    {
                        MessageBox.Show("the admin with the email: " + txtEmail.Text + " exist in the system!");
                        txtEmail.Focus();
                    }
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatemode = true;
            disableFields(true, false, false, false, false, true, true, true, false, false);
            txtName.Focus();
        }

        private void ReloadForm()
        {
            clearFields();
            disableFields(true, true, true, true, true, false, true, true, true, true);
            clsAdminData.setData(listAdmin, dataGridView1);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReloadForm();
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


