using prjRemax.Business;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prjRemax.DataLayer
{
    class clsSalesData
    {
        static Dictionary<string, clsSales> salesData;
        public clsSalesData()
        {
            salesData = new Dictionary<string, clsSales>();

        }

        public static void setData(DataGridView grid)
        {
            grid.Rows.Clear();
            foreach (KeyValuePair<string, clsSales> sale in salesData)
            {
                grid.Rows.Add(sale.Value.SalesId, sale.Value.AgentId, sale.Value.HouseRefId, sale.Value.BuyerID, sale.Value.SellerID, sale.Value.SellDate);
            }
        }

        public static void addSale(clsSales newSalesData)
        {
            salesData.Add(newSalesData.SalesId, newSalesData);

        }
    }
}
