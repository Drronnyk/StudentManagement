public class UserDto
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
     public string RoleName
    {
        get;
        set;
    }=string.Empty;
     public bool IsActived
    {
        get;
        set;
    }
    public DateTime LastLogin
    {
        get;
        set;
    }
}
