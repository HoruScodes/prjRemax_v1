using prjRemax.Business;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjRemax.DataLayer
{

    class clsHouseData
    {
        public static Dictionary<string, clsHouse> houseData;

        public clsHouseData()
        {
            houseData = new Dictionary<string, clsHouse>();
            clsHouse house1 = new clsHouse("h01", "Appartment", "4", "1", "1000000", "Montreal", "H3H2E7", "ag01", "agent1", "cl01", "Aron");
            clsHouse house2 = new clsHouse("h02", "Condo", "4", "2", "1000000", "Montreal", "H3H2E8", "ag02", "agent2", "ad01", "Rahul");
            clsHouse house3 = new clsHouse("h03", "Studio", "1", "1", "1000000", "Montreal", "H3H2E9", "ag03", "agent3", "cl01", "Aron");
            clsHouse house4 = new clsHouse("h04", "Appartment", "4", "1", "1000000", "Montreal", "H3H2P4", "ag01", "agent1", "cl01", "Aron");
            clsHouse house5 = new clsHouse("h05", "Condo", "4", "2", "1000000", "Montreal", "H3H2P5", "ag02", "agent2", "ad01", "Rahul");
            clsHouse house6 = new clsHouse("h06", "Studio", "1", "1", "1000000", "Montreal", "H3H2P6", "ag03", "agent3", "cl01", "Aron");
            clsHouse house7 = new clsHouse("h07", "Appartment", "4", "1", "1000000", "Montreal", "H3H2E7", "ag01", "agent1", "cl01", "Aron");
            clsHouse house8 = new clsHouse("h08", "Condo", "4", "2", "1000000", "Montreal", "H3H3E7", "ag02", "agent2", "ad01", "Rahul");
            clsHouse house9 = new clsHouse("h09", "Studio", "1", "1", "1000000", "Montreal", "H3H4E7", "ag03", "agent3", "cl01", "Aron");
            clsHouse house10 = new clsHouse("h10", "Appartment", "4", "1", "1000000", "Montreal", "H3H2B1", "ag01", "agent1", "cl01", "Aron");
            clsHouse house11 = new clsHouse("h11", "Condo", "4", "2", "1000000", "Montreal", "H3H2B2", "ag02", "agent2", "ad01", "Rahul");
            clsHouse house12 = new clsHouse("h12", "Studio", "1", "1", "1000000", "Montreal", "H3H2B3", "ag03", "agent3", "cl01", "Aron");

            houseData.Add("h01", house1);
            houseData.Add("h02", house2);
            houseData.Add("h03", house3);
            houseData.Add("h04", house4);
            houseData.Add("h05", house5);
            houseData.Add("h06", house6);
            houseData.Add("h07", house7);
            houseData.Add("h08", house8);
            houseData.Add("h09", house9);
            houseData.Add("h10", house10);
            houseData.Add("h11", house11);
            houseData.Add("h12", house12);


        }

        public static bool AddHouse(clsHouse newHouseData)
        {
            if (!Exist(newHouseData.HouseId))
            {
                houseData.Add(newHouseData.HouseId, newHouseData);
                return true;
            }
            return false;
        }
        public static bool removeHouse(string houseid)
        {
            if (!Exist(houseid))
            {
                return false;
            }
            houseData.Remove(houseid);
            return true;
        }

        public static bool Exist(string houseid)
        {
            return houseData.ContainsKey(houseid);
        }

        public static bool updateHouse(clsHouse newHouseData)
        {
            if (Exist(newHouseData.HouseId))
            {
                houseData[newHouseData.HouseId] = newHouseData;
                return true;
            }
            return false;
        }

        public static void setData(ListBox list, DataGridView dataGrid)
        {
            list.Items.Clear();
            dataGrid.Rows.Clear();
            if (frmLogin.Usermode == "Admin")
            {
                foreach (KeyValuePair<string, clsHouse> house in houseData)
                {
                    // do something with entry.Value or entry.Key
                    list.Items.Add(house.Value.HouseId);
                    dataGrid.Rows.Add(house.Value.HouseId, house.Value.HouseType, house.Value.NumOfBedRooms, house.Value.NumbofBathRooms, house.Value.Price, house.Value.City, house.Value.PostalCode, house.Value.AgentID, house.Value.AgentName, house.Value.SellerId, house.Value.SellerName);
                }
            }
            else if (frmLogin.Usermode == "Agent")
            {
                foreach (KeyValuePair<string, clsHouse> house in houseData)
                {
                    // do something with entry.Value or entry.Key
                    if (house.Value.AgentID == frmLogin.currentId)
                    {
                        list.Items.Add(house.Value.HouseId);
                        dataGrid.Rows.Add(house.Value.HouseId, house.Value.HouseType, house.Value.NumOfBedRooms, house.Value.NumbofBathRooms, house.Value.Price, house.Value.City, house.Value.PostalCode, house.Value.AgentID, house.Value.AgentName, house.Value.SellerId, house.Value.SellerName);

                    }
                }
            }
        }

        public static void setHouseData(ComboBox houses)
        {
            houses.Items.Clear();
            foreach (KeyValuePair<string, clsHouse> house in houseData)
            {
                houses.Items.Add(house.Value.HouseId);
            }

        }

        public static void setHouseSellerData(ComboBox sellers)
        {
            sellers.Items.Clear();
            foreach (KeyValuePair<string, clsHouse> house in houseData)
            {
                if (!sellers.Items.Contains(house.Value.SellerId))
                {
                    sellers.Items.Add(house.Value.SellerId);
                }
            }

        }

        public static void setHouseDataGrid(string selectedHouseId, DataGridView dataGrid)
        {
            dataGrid.Rows.Clear();
            if (selectedHouseId == "all")
            {
                foreach (KeyValuePair<string, clsHouse> house in houseData)
                {
                    dataGrid.Rows.Add(house.Value.HouseId, house.Value.HouseType, house.Value.NumOfBedRooms, house.Value.NumbofBathRooms, house.Value.Price, house.Value.City, house.Value.PostalCode, house.Value.AgentID, house.Value.AgentName, house.Value.SellerId, house.Value.SellerName);
                }
            }
            else
            {
                foreach (KeyValuePair<string, clsHouse> house in houseData)
                {
                    if (house.Value.HouseId == selectedHouseId)
                    {
                        dataGrid.Rows.Add(house.Value.HouseId, house.Value.HouseType, house.Value.NumOfBedRooms, house.Value.NumbofBathRooms, house.Value.Price, house.Value.City, house.Value.PostalCode, house.Value.AgentID, house.Value.AgentName, house.Value.SellerId, house.Value.SellerName);
                    }
                }
            }

        }
    }
}
