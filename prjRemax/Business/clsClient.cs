namespace prjRemax.Business
{
    class clsClient
    {
        private string vId;
        private string vName;
        private string vEmail;
        private string vPhone;
        private string vPassword;
        private string vType;
        private string vParentType;
        private string vParentName;

        private string vParentId;

        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string clientType { get; set; }
        public string ParentType { get; set; }
        public string ParentName { get; set; }

        public string ParentId { get; set; }

        public clsClient(string id, string name, string email, string phone, string password, string type, string parenttype, string parentname, string parentId)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Password = password;
            clientType = type;
            ParentType = parenttype;
            ParentName = parentname;
            ParentId = parentId;
        }

    }
}
