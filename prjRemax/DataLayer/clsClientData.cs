using prjRemax.Business;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjRemax.DataLayer
{
    class clsClientData
    {
        public static Dictionary<string, clsClient> clientData;

        public clsClientData()
        {
            clientData = new Dictionary<string, clsClient>();
            clsClient client1 = new clsClient("cl01", "Aron", "Aron@gmail.com", "12345", "Aron", "Seller", "Agent", "agent1", "ag01");
            clsClient client2 = new clsClient("cl02", "Glenn", "Glenn@gmail.com", "12345", "Glenn", "Buyer", "Agent", "agent1", "ag01");
            clsClient client3 = new clsClient("cl03", "Mitchell", "Mitchell@gmail.com", "12345", "Mitchell", "Seller", "Admin", "Rahul", "ad01");
            clsClient client4 = new clsClient("cl04", "Pat", "Pat@gmail.com", "12345", "Pat", "Buyer", "Agent", "agent2", "ag02");
            clsClient client5 = new clsClient("cl05", "Marcus", "Marcus@gmail.com", "12345", "Marcus", "Seller", "Agent", "agent3", "ag03");
            clsClient client6 = new clsClient("cl06", "Alex", "Alex@gmail.com", "12345", "Alex", "Buyer", "Admin", "John", "ad02");
            clientData.Add("Aron@gmail.com", client1);
            clientData.Add("Glenn@gmail.com", client2);
            clientData.Add("Mitchell@gmail.com", client3);
            clientData.Add("Pat@gmail.com", client4);
            clientData.Add("Marcus@gmail.com", client5);
            clientData.Add("Alex@gmail.com", client6);
        }

        public static string loginClient(string email, string pwd)
        {
            if (Exist(email))
            {
                if (clientData[email].Password.Equals(pwd))
                {
                    return clientData[email].Email;
                }
                else
                {
                    return "pwdErr";
                }

            }
            return "notFoundErr";
        }


        public static bool AddClient(clsClient newClientData)
        {
            if (!Exist(newClientData.Email))
            {
                clientData.Add(newClientData.Email, newClientData);
                return true;
            }
            return false;
        }

        public static bool removeClient(string email)
        {
            if (!Exist(email))
            {
                return false;
            }
            clientData.Remove(email);
            return true;
        }
        public static bool updateClient(clsClient newClientData)
        {
            if (Exist(newClientData.Email))
            {
                clientData[newClientData.Email] = newClientData;
                return true;
            }
            return false;
        }
        public static bool Exist(string key)
        {
            return clientData.ContainsKey(key);
        }

        public static void setData(ListBox list, DataGridView dataGrid)
        {
            list.Items.Clear();
            dataGrid.Rows.Clear();
            if (frmLogin.Usermode == "Admin")
            {
                foreach (KeyValuePair<string, clsClient> client in clientData)
                {
                    // do something with entry.Value or entry.Key
                    list.Items.Add(client.Value.Name);
                    dataGrid.Rows.Add(client.Value.Id, client.Value.Name, client.Value.Email, client.Value.Phone, client.Value.Password, client.Value.clientType, client.Value.ParentType, client.Value.ParentName, client.Value.ParentId);
                }
            }
            else if (frmLogin.Usermode == "Agent")
            {
                foreach (KeyValuePair<string, clsClient> client in clientData)
                {
                    if (client.Value.ParentId == frmLogin.currentId)
                    {
                        list.Items.Add(client.Value.Name);
                        dataGrid.Rows.Add(client.Value.Id, client.Value.Name, client.Value.Email, client.Value.Phone, client.Value.Password, client.Value.clientType, client.Value.ParentType, client.Value.ParentName, client.Value.ParentId);
                    }

                }
            }
        }

        public static string getDatabySellerName(string name)
        {

            foreach (KeyValuePair<string, clsClient> client in clientData)
            {
                if (name == client.Value.Name)
                {
                    return client.Value.Id;
                }
            }

            return null;
        }

        public static void setHouseBuyerData(ComboBox buyers)
        {
            buyers.Items.Clear();
            foreach (KeyValuePair<string, clsClient> client in clientData)
            {
                if (client.Value.clientType == "Buyer" && !buyers.Items.Contains(client.Value.Id))
                {
                    buyers.Items.Add(client.Value.Id);
                }
            }

        }
    }
}
