public class CreateClassroomDto
{
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
}