using prjRemax.Business;
using prjRemax.DataLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjRemax.GUI
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }

        private static int currId = 0;
        private void frmSales_Load(object sender, EventArgs e)
        {
            reloadForm();
            //comboBoxSeller.Enabled = false;
            //dateTimePicker1.Enabled = false;
            //btnCancel.Enabled = false;
            //btnSell.Enabled = false;
        }

        private void comboBoxHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedHouse = comboBoxHouse.SelectedItem.ToString();
            foreach (KeyValuePair<string, clsHouse> house in clsHouseData.houseData)
            {
                if (house.Value.HouseId == selectedHouse)
                {
                    comboBoxSeller.SelectedItem = house.Value.SellerId;
                }
            }
        }

        private void disablefields(bool agentid, bool houseid, bool buyerid, bool sellerid, bool date, bool sell, bool cancel, bool save)
        {
            comboBoxAgentName.Enabled = !agentid;
            comboBoxHouse.Enabled = !houseid;
            comboBoxBuyer.Enabled = !buyerid;
            comboBoxSeller.Enabled = !sellerid;
            dateTimePicker1.Enabled = !date;
            btnSaleHouse.Enabled = !sell;
            btnCancel.Enabled = !cancel;
            btnSell.Enabled = !save;
        }

        private void btnSaleHouse_Click(object sender, EventArgs e)
        {
            if (validateData.isComboBoxSelected(comboBoxAgentName) && validateData.isComboBoxSelected(comboBoxHouse) && validateData.isComboBoxSelected(comboBoxBuyer) && validateData.isComboBoxSelected(comboBoxSeller))
            {
                disablefields(true, true, true, true, true, true, false, false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reloadForm();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            currId += 1;
            string contractId = "ctr" + currId.ToString();
            string agentId = comboBoxAgentName.SelectedItem.ToString();
            string houseId = comboBoxHouse.SelectedItem.ToString();
            string buyersId = comboBoxBuyer.SelectedItem.ToString();
            string sellersId = comboBoxSeller.SelectedItem.ToString();
            DateTime dealDate = dateTimePicker1.Value;
            clsSales sale = new clsSales(contractId, agentId, houseId, buyersId, sellersId, dealDate);
            clsSalesData.addSale(sale);
            clsHouseData.removeHouse(houseId);
            MessageBox.Show("HOUSEEE SOLDDD!!!");
            reloadForm();
        }

        private void reloadForm()
        {
            dataGridViewSales.Rows.Clear();
            clsSalesData.setData(dataGridViewSales);
            clsAgentData.setAgentData(comboBoxAgentName);
            clsHouseData.setHouseData(comboBoxHouse);
            clsHouseData.setHouseSellerData(comboBoxSeller);
            clsClientData.setHouseBuyerData(comboBoxBuyer);
            comboBoxAgentName.SelectedIndex = 0;
            comboBoxBuyer.SelectedIndex = 0;
            comboBoxSeller.SelectedIndex = 0;
            comboBoxHouse.SelectedIndex = 0;
            disablefields(false, false, false, true, true, false, true, true);
        }
    }
}
