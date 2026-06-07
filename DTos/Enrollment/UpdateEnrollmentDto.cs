using StudentManagementApi.Api.Helpers;

public class UpdateEnrollmentDto
{
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