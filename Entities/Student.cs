using StudentManagementApi.Api.Helpers;

public class Student
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
    public char gender
    {
        get;
        set;
    }
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
    public string Photo
    {
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
    public StudentStatus StudentStatus
    {
        get;
        set;
    }
    public int? UserId
    {
        get;
        set;
    }
     public DateTime CreatedAt
    {
        get;
        set;
    }
     public DateTime UpdateAt
    {
        get;
        set;
    }
     public bool IsDeleted
    {
        get;
        set;
    }


}