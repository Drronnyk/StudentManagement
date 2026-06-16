using Microsoft.EntityFrameworkCore;

public class DepartmentRepository :GenericRepository<Departement>, IDepartementRepository
{
    private readonly AppDbContext _context;

    public DepartmentRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public async  Task<Departement?>   GetByName(string departmentName)
    {
        return await _context.Set<Departement>().FirstOrDefaultAsync(d => d.Name == departmentName);
    }
}