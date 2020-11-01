namespace prjRemax.Business
{
    class clsHouse
    {
        private string vHouseId;
        private string vHouseType;
        private string vNumOfBedRooms;
        private string vNumbofBathRooms;
        private string vPrice;
        private string vCity;
        private string vPostalCode;
        private string vAgentID;
        private string vAgentName;
        private string vsellerID;
        private string vSellerName;


        public string HouseId { get; set; }
        public string HouseType { get; set; }
        public string NumOfBedRooms { get; set; }
        public string NumbofBathRooms { get; set; }
        public string Price { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string AgentID { get; set; }
        public string AgentName { get; set; }
        public string SellerName { get; set; }

        public string SellerId { get; set; }




        public clsHouse(string houseid, string housetype, string numofrooms, string numofbathrooms, string price, string cityname, string postalcode, string agentid, string agentname, string sellerid, string sellerName)
        {
            HouseId = houseid;
            HouseType = housetype;
            NumOfBedRooms = numofrooms;
            NumbofBathRooms = numofbathrooms;
            Price = price;
            City = cityname;
            PostalCode = postalcode;
            AgentID = agentid;
            AgentName = agentname;
            SellerName = sellerName;
            SellerId = sellerid;
        }
    }


}
