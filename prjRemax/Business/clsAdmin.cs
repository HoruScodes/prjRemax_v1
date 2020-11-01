namespace prjRemax.Business
{
    public class clsAdmin
    {
        // -- FIELDS will store the values of PROPERTIES
        private string vId;
        private string vName;
        private string vEmail;
        private string vPhone;
        private string vPassword;


        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }

        public clsAdmin(string id, string name, string email, string phone, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Password = password;
        }

    }
}
