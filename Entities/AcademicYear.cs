public class AcademicYear
{
    public int Id
    {
        get;
        set;
    }
    //Label : exemple 2024-2025
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
    public bool IsActive
    {
        get;
        set;
    }
}