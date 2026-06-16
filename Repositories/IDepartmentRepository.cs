public interface IDepartementRepository : IGenericRepository<Departement>
{
    Task<Departement?>   GetByName(string departmentName);
}