using StudentManagementApi.Api.Helpers;

public class UpdateStudentDto
{
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
     public int DepartmentId
    {
        get;
        set;
    }
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
    public string Photo    {
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
}