using StudentManagementApi.Api.Helpers;

public class StudentDetailDto
{
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

    public DateTime DateOfBirth
    {
        get;
        set;
    }
    public string PlaceOfBirth
    {
        get;
        set;
    }=string.Empty;
    public string Nationality
    {
        get;
        set;
    }=string.Empty;
    public string Address
    {
        get;
        set;
    }=string.Empty;
    public string photo    {
        get;
        set;
    }=string.Empty;
    public string ParentName
    {
        get;
        set;
    }=string.Empty;
    public string ParentPhone
    {
        get;
        set;
    }=string.Empty;
    public bool CreatedAt
    {
        get;
        set;
    }
    public bool UpdateAt
    {
        get;
        set;
    }                                   



}