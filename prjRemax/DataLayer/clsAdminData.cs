using prjRemax.Business;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjRemax.DataLayer
{

    public class clsAdminData
    {
        public static Dictionary<string, clsAdmin> adminData;
        public clsAdminData()
        {
            adminData = new Dictionary<string, clsAdmin>();
            clsAdmin admin1 = new clsAdmin("ad01", "Rahul", "pipaliya1997@gmail.com", "1111111111", "12345");
            clsAdmin admin2 = new clsAdmin("ad02", "John", "john@gmail.com", "2222222222", "12345");
            clsAdmin admin3 = new clsAdmin("ad03", "Steve", "steve@gmail.com", "3333333333", "12345");
            adminData.Add("pipaliya1997@gmail.com", admin1);
            adminData.Add("12345", admin2);
            adminData.Add("123", admin3);

        }



        public static string loginAdmin(string email, string pwd)
        {
            if (Exist(email))
            {
                if (adminData[email].Password.Equals(pwd))
                {
                    return adminData[email].Email;
                }
                else
                {
                    return "pwdErr";
                }

            }
            return "notFoundErr";
        }

        public static bool AddAdmin(clsAdmin newAdminData)
        {
            if (!Exist(newAdminData.Email))
            {
                adminData.Add(newAdminData.Email, newAdminData);
                return true;
            }
            return false;
        }

        public static bool removeAdmin(string email)
        {
            if (!Exist(email))
            {
                return false;
            }
            adminData.Remove(email);
            return true;
        }

        public static bool updateAdmin(clsAdmin newAdminData)
        {
            if (Exist(newAdminData.Email))
            {
                adminData[newAdminData.Email] = newAdminData;
                return true;
            }
            return false;
        }
        public static bool Exist(string key)
        {
            return adminData.ContainsKey(key);
        }

        public static void setData(ListBox list, DataGridView dataGrid)
        {
            list.Items.Clear();
            dataGrid.Rows.Clear();
            foreach (KeyValuePair<string, clsAdmin> admin in adminData)
            {
                // do something with entry.Value or entry.Key
                list.Items.Add(admin.Value.Name);
                dataGrid.Rows.Add(admin.Value.Id, admin.Value.Name, admin.Value.Email, admin.Value.Password, admin.Value.Phone);
            }
        }
        public static clsAdmin getData(string email)
        {

            if (Exist(email))
            {
                return adminData[email];
            }

            return null;
        }
    }
}
