public class AcademicYearDto
{
     public int Id
    {
        get;
        set;
    }
    public string label
    {
        get;
        set;
    }=string.Empty;
    
    public DateTime StartDate
    {
        get;
        set;
    }
    public DateTime EndDate
    {
        get;
        set;
    }
}