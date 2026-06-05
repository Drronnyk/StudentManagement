public class Classroom
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
    public int Capacity
    {
        get;
        set;
    }
    public int DepartementId
    {
        get;
        set;
    }
    public int LevelId
    {
        get;
        set;
    }
    public bool isDeleted
    {
        get;
        set;
    }
    public Departement Departement{ get; set;} = null!;
    public Level Level{ get; set;} = null!;
     public ICollection<Enrollement>Enrollements {get; set;} = new List<Enrollement>();
    
}
