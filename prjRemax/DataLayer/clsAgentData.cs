using prjRemax.Business;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjRemax.DataLayer
{

    class clsAgentData
    {
        public static Dictionary<string, clsAgent> agentData;

        public clsAgentData()
        {
            agentData = new Dictionary<string, clsAgent>();
            clsAgent agent1 = new clsAgent("ag01", "agent1", "agent1@gmail.com", "123456789", "password1", "ad01");
            clsAgent agent2 = new clsAgent("ag02", "agent2", "agent2@gmail.com", "9876543210", "password2", "ad02");
            clsAgent agent3 = new clsAgent("ag03", "agent3", "agent", "9876543210", "agent", "ad03");
            agentData.Add("agent1@gmail.com", agent1);
            agentData.Add("agent2@gmail.com", agent2);
            agentData.Add("agent", agent3);

        }

        public static string loginAgent(string email, string pwd)
        {
            if (Exist(email))
            {
                if (agentData[email].Password.Equals(pwd))
                {
                    return agentData[email].Email;
                }
                else
                {
                    return "pwdErr";
                }

            }
            return "notFoundErr";
        }

        public static bool AddAgent(clsAgent newAgentData)
        {
            if (!Exist(newAgentData.Email))
            {
                agentData.Add(newAgentData.Email, newAgentData);
                return true;
            }
            return false;
        }

        public static bool removeAgent(string email)
        {
            if (!Exist(email))
            {
                return false;
            }
            agentData.Remove(email);
            return true;
        }

        public static bool updateAgent(clsAgent newAgentData)
        {
            if (Exist(newAgentData.Email))
            {
                agentData[newAgentData.Email] = newAgentData;
                return true;
            }
            return false;
        }

        public static bool Exist(string key)
        {
            return agentData.ContainsKey(key);
        }

        public static void setData(ListBox list, DataGridView dataGrid)
        {
            list.Items.Clear();
            dataGrid.Rows.Clear();
            foreach (KeyValuePair<string, clsAgent> agent in agentData)
            {
                // do something with entry.Value or entry.Key
                list.Items.Add(agent.Value.Name);
                dataGrid.Rows.Add(agent.Value.Id, agent.Value.Name, agent.Value.Email, agent.Value.Password, agent.Value.Phone, agent.Value.AdminId);
            }
        }
        public static Dictionary<string, clsAgent> getAllData()
        {
            return agentData;
        }
        public static clsAgent getData(string email)
        {

            if (Exist(email))
            {
                return agentData[email];
            }

            return null;
        }

        public static void setAgentData(ComboBox agents)
        {
            agents.Items.Clear();
            if (frmLogin.Usermode == "Admin")
            {
                foreach (KeyValuePair<string, clsAdmin> admin in clsAdminData.adminData)
                {
                    if (!agents.Items.Contains(admin.Value.Id))
                    {
                        agents.Items.Add(admin.Value.Id);

                    }

                }
            }
            foreach (KeyValuePair<string, clsAgent> agent in agentData)
            {
                if (!agents.Items.Contains(agent.Value.Id))
                {
                    agents.Items.Add(agent.Value.Id);

                }
            }

        }

        public static void setAgentsDataGrid(string selectedAgentID, DataGridView GridAgent)
        {
            GridAgent.Rows.Clear();
            if (selectedAgentID == "all")
            {
                foreach (KeyValuePair<string, clsAgent> agent in agentData)
                {
                    GridAgent.Rows.Add(agent.Value.Id, agent.Value.Name, agent.Value.Email, agent.Value.Phone);
                }
            }
            else
            {
                foreach (KeyValuePair<string, clsAgent> agent in agentData)
                {
                    if (agent.Value.Id == selectedAgentID)
                    {
                        GridAgent.Rows.Add(agent.Value.Id, agent.Value.Name, agent.Value.Email, agent.Value.Phone);
                    }
                }
            }

        }
    }
}
