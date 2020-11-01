using System;

namespace prjRemax.Business
{
    class clsSales
    {
        private int vSalesId;
        private int vAgentId;
        private int vHouseRefId;
        private int vBuyerId;
        private int vSellerId;
        private DateTime vSellDate;

        public string SalesId { get; set; }
        public string AgentId { get; set; }
        public string HouseRefId { get; set; }
        public string BuyerID { get; set; }
        public string SellerID { get; set; }
        public DateTime SellDate { get; set; }

        public clsSales(string salesid, string agentid, string houserefid, string buyerid, string sellerid, DateTime selldate)
        {
            SalesId = salesid;
            AgentId = agentid;
            HouseRefId = houserefid;
            BuyerID = buyerid;
            SellerID = sellerid;
            SellDate = selldate;
        }

    }
}
