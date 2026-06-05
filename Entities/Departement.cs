public class Departement
{
    public int Id
    {
        get;
        set;
    }
    public string Name
    {
        get;
        set;
    }=string.Empty;

    public string Code
    {
        get;
        set;
    }=string.Empty;
    public string Description
    {
        get;
        set;
    }=string.Empty;
    public bool IsDeleted
    {
        get;
        set;
    }
    public ICollection<Classroom>Classrooms {get; set;} = new List<Classroom>();
}