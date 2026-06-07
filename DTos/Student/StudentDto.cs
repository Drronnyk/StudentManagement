using StudentManagementApi.Api.Helpers;

public class StudentDto{


 public int Id
    {
        get;
        set;
    }
    public string RegistrationNumber
    {
        get;
        set;
    }=string.Empty;
    public string FirstName
    {
        get;
        set;
    }=string.Empty;
    public string LastName
    {
        get;
        set;
    }=string.Empty;
    public char Gender
    {
        get;
        set;
    }
    public StudentStatus Status
    {
        get;
        set;
    }
    public string Phone
    {
        get;
        set;
    }=string.Empty;
    public string Email
    {
        get;
        set;
    }=string.Empty;
    public string DepartmentName
    {
        get;
        set;
    }=string.Empty;
 }