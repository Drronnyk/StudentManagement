public class User
{
    public int Id
    {
        get;
        set;
    }
    public string Username
    {
        get;
        set;
    }=string.Empty;
    public string Email
    {
        get;
        set;
    }=string.Empty;
    public string PasswordHashed
    {
        get;
        set;
    }=string.Empty;
    public bool IsActived
    {
        get;
        set;
    }
    // Foreign Key --> Id in Role
    public int RoleId
    {
        get;
        set;
    }
    public DateTime? LastLogin
    {
        get;
        set;
    }
    public DateTime CreatedAt
    {
        get;
        set;
    }
}