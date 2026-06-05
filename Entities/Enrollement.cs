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
    public int ClassroomId
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
    public Student Student
    {
        get;
        set;
    }= null!;
    public Classroom Classroom
    {
        get;
        set;
    }= null!;
     public AcademicYear AcademicYear
    {
        get;
        set;
    }= null!;
    
}