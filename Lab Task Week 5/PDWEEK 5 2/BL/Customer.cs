class CustomerBL
{
    public string username;
    public string password;
    public string email;
    public string address;
    public string contact;

    public CustomerBL(string username, string password, string email, string address, string contact)
    {
        this.username = username;
        this.password = password;
        this.email = email;
        this.address = address;
        this.contact = contact;
    }
}