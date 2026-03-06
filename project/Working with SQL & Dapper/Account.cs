// Do not modify this file

class Account
{
    public Int64 ID { get; set; }
    public string Email { get; set; }
    public string FullName { get; set; }

    public Account(Int64 id, string email, string fullname)
    {
        ID = id;
        Email = email;
        FullName = fullname;
    }

    public override string ToString()
    {
        return $"{FullName}";
    }
}
