using StudentManagementApi.Api.Helpers;

public class Enrollement
{
    public int Id
    {
        get;
        set;

    }
    public int StudentId
    {
        get;
        set;

    }
    public int ClassId
    {
        get;
        set;

    }
    public int AcademicYearId
    {
        get;
        set;

    }
    public DateTime EnrollmentDate
    {
        get;
        set;

    }
    public EnrollementStatus Status
    {
        get;
        set;

    }
    public string Observations
    {
        get;
        set;

    }=string.Empty;
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