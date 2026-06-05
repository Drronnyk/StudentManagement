public class Level
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
        // Order ici represente la position dans la hierarchie
    public int Order 
    {
        get;
        set;
    }
    public bool isDeleted
    {
        get;
        set;
    }
    public ICollection<Classroom>Classrooms {get; set;} = new List<Classroom>();

}