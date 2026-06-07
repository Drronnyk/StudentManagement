using StudentManagementApi.Api.Helpers;

public class EnrollementDto
{
    public int Id
    {
        get;
        set;

    }
    public string StudentName
    {
        get;
        set;

    }=string.Empty;
    public string ClassroomName
    {
        get;
        set;

    }=string.Empty;
    public string AcademicYearLabel
    {
        get;
        set;

    }=string.Empty;
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
}