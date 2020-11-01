using prjRemax.Business;
using prjRemax.DataLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjRemax.GUI
{
    public partial class frmHouse : Form
    {
        private bool updatemode = false;
        private string currentSelectedSellerid = " ";
        private int latestHouseId = 12;
        public frmHouse()
        {
            InitializeComponent();
        }


        private void frmHouse_Load(object sender, EventArgs e)
        {
            disableFields(true, true, true, true, true, true, true, true, true, false, true, true, true, true);
            clsHouseData.setData(listHouse, dataGridViewHouse);
            setClientData();
        }

        public void setClientData()
        {
            comboBoxAgent.Items.Clear();
            comboBoxSeller.Items.Clear();
            comboBoxHouseType.Items.Clear();

            foreach (KeyValuePair<string, clsAgent> agent in clsAgentData.agentData)
            {
                comboBoxAgent.Items.Add(agent.Value.Name);

            }
            foreach (KeyValuePair<string, clsAdmin> admin in clsAdminData.adminData)
            {
                comboBoxAgent.Items.Add(admin.Value.Name);

            }
            foreach (KeyValuePair<string, clsClient> client in clsClientData.clientData)
            {
                //if(client.Value.clientType == "Seller" && frmLogin.Usermode == "Admin")
                if (client.Value.clientType == "Seller")

                {
                    comboBoxSeller.Items.Add(client.Value.Name);
                }
                //else if (frmLogin.Usermode == "Agent" && client.Value.ParentId == frmLogin.currentId)
                //{
                //    comboBoxSeller.Items.Add(client.Value.Name);

                //}

            }
            foreach (KeyValuePair<string, clsHouse> house in clsHouseData.houseData)
            {
                comboBoxHouseType.Items.Add(house.Value.HouseType);

            }
        }
        private void disableFields(bool id, bool housetype, bool numofrooms, bool numofbathrooms, bool price, bool city, bool postalcode, bool agent, bool seller, bool addbutton, bool deletebutton, bool updatebutton, bool cancelbutton, bool savebutton)
        {
            txtId.Enabled = !id;
            comboBoxHouseType.Enabled = !housetype;
            numberOfRooms.Enabled = !numofrooms;
            numberOfBathrooms.Enabled = !numofbathrooms;
            txtPrice.Enabled = !price;
            txtCity.Enabled = !city;
            txtPostalCode.Enabled = !postalcode;
            comboBoxAgent.Enabled = !agent;
            comboBoxSeller.Enabled = !seller;
            btnAdd.Enabled = !addbutton;
            btnCancel.Enabled = !cancelbutton;
            btnDelete.Enabled = !deletebutton;
            btnSave.Enabled = !savebutton;
            btnUpdate.Enabled = !updatebutton;
        }

        private void listHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedName = listHouse.SelectedItem.ToString();
            foreach (KeyValuePair<string, clsHouse> data in clsHouseData.houseData)
            {
                if (data.Value.HouseId == selectedName)
                {
                    disableFields(true, true, true, true, true, true, true, true, true, false, false, false, true, true);
                    txtId.Text = data.Value.HouseId;
                    comboBoxHouseType.Text = data.Value.HouseType;
                    numberOfRooms.Value = Convert.ToDecimal(data.Value.NumOfBedRooms);
                    numberOfBathrooms.Value = Convert.ToDecimal(data.Value.NumbofBathRooms);
                    txtPrice.Text = data.Value.Price;
                    txtCity.Text = data.Value.City;
                    txtPostalCode.Text = data.Value.PostalCode;
                    comboBoxAgent.SelectedItem = data.Value.AgentName;
                    currentSelectedSellerid = data.Value.SellerId;
                    comboBoxSeller.SelectedItem = data.Value.SellerName;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            updatemode = false;
            disableFields(true, false, false, false, false, false, false, true, false, true, true, true, false, false);
            clearFields();
            if (frmLogin.Usermode == "Agent")
            {
                comboBoxSeller.Items.Clear();
                foreach (KeyValuePair<string, clsClient> client in clsClientData.clientData)
                {
                    if (client.Value.clientType == "Seller" && client.Value.ParentId == frmLogin.currentId)
                    {
                        comboBoxSeller.Items.Add(client.Value.Name);
                    }
                }
            }
            txtId.Text = "h" + (latestHouseId + 1).ToString();
            comboBoxHouseType.SelectedIndex = 0;
            comboBoxSeller.SelectedIndex = 0;
        }

        private void clearFields()
        {
            txtId.Clear();
            numberOfRooms.Value = 0;
            numberOfBathrooms.Value = 0;
            txtPrice.Clear();
            txtCity.Clear();
            txtPostalCode.Clear();
            comboBoxAgent.SelectedItem = frmLogin.currentName;
            setHouseType();


        }

        private void setHouseType()
        {
            comboBoxHouseType.Items.Clear();
            comboBoxHouseType.Items.Add("Appartment");
            comboBoxHouseType.Items.Add("Condo");
            comboBoxHouseType.Items.Add("Studio");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete House " + txtId.Text + " ?", "DELETE", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (clsHouseData.removeHouse(txtId.Text))
                {
                    MessageBox.Show("Deleted");
                    ReloadForm();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatemode = true;
            disableFields(true, false, false, false, false, false, false, true, true, true, true, true, false, false);
            comboBoxAgent.SelectedItem = frmLogin.currentName;
            string name = comboBoxSeller.SelectedItem.ToString();
            string type = comboBoxHouseType.SelectedItem.ToString();
            comboBoxSeller.Items.Clear();
            comboBoxHouseType.Items.Clear();
            foreach (KeyValuePair<string, clsClient> client in clsClientData.clientData)
            {
                if (client.Value.clientType == "Seller")
                {
                    comboBoxSeller.Items.Add(client.Value.Name);
                }

            }
            comboBoxSeller.SelectedItem = name;
            foreach (KeyValuePair<string, clsHouse> house in clsHouseData.houseData)
            {
                comboBoxHouseType.Items.Add(house.Value.HouseType);

            }
            comboBoxHouseType.SelectedItem = type;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ReloadForm();
        }
        private void ReloadForm()
        {
            clearFields();
            disableFields(true, true, true, true, true, true, true, true, true, false, true, true, true, true);
            clsHouseData.setData(listHouse, dataGridViewHouse);
            setClientData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateData.isComboBoxSelected(comboBoxHouseType) && validateData.validateNonZero(numberOfRooms) && validateData.validateNonZero(numberOfBathrooms) && validateData.validatePrice(txtPrice) && validateData.isNameValid(txtCity) && validateData.isComboBoxSelected(comboBoxSeller))
            {
                clsHouse house = new clsHouse(txtId.Text, comboBoxHouseType.SelectedItem.ToString(), numberOfRooms.Value.ToString(), numberOfBathrooms.Value.ToString(), txtPrice.Text, txtCity.Text, txtPostalCode.Text, frmLogin.currentId, frmLogin.currentName, currentSelectedSellerid, comboBoxSeller.SelectedItem.ToString());
                if (updatemode)
                {
                    if (clsHouseData.updateHouse(house))
                    {
                        MessageBox.Show("successfully updated House Info in the system!");
                        ReloadForm();
                    }
                }
                else
                {
                    if (clsHouseData.AddHouse(house))
                    {
                        MessageBox.Show("successfully added House Information in the system!");
                        latestHouseId += 1;
                        ReloadForm();
                    }
                    else
                    {
                        MessageBox.Show("this house is aready exist in the system!");
                        txtId.Focus();
                    }
                }
            }
        }

        private void comboBoxSeller_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSelectedSellerid = clsClientData.getDatabySellerName(comboBoxSeller.SelectedItem.ToString());
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true; // blocking the caracter typed by the key
            }
        }
    }
}
