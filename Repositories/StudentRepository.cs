using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;
using StudentManagementApi.Api.Helpers;

public class StudentRepository : GenericRepository<Student>, IStudentRepository
{
    private readonly AppDbContext _context;
    public StudentRepository(AppDbContext context) : base(context) {
        _context = context;
    }
    public async Task<Student?> GetByRegistrationNumber(string registrationNumber)
    {
        return await _context.Set<Student>().FirstOrDefaultAsync(r =>r.RegistrationNumber == registrationNumber);
    }
    public async Task<Student?> GetByEmail(string email)
    {
        return await _context.Set<Student>().FirstOrDefaultAsync(e => e.Email == email);
    }
    public async Task<Student?> GetWithEnrollment(int id)
    {
        return await _context.Set<Student>().Include(s => s.Enrollements).FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<IEnumerable<Student>> GetByDepartment(int departmentId)
    {
        return  _context.Set<Student>().Include(s => s.Enrollements).
        ThenInclude(e=>e.Classroom).ThenInclude(a => a.Departement)
        .Where(s => s.Enrollements.Any(e=>e.Classroom.DepartementId == departmentId));
    }

    public async Task<IEnumerable<Student>> GetByStatus(StudentStatus status)
    {
        return await _context.Set<Student>().Where(s =>s.Status == status).ToListAsync();
    }
    public async Task SoftDelete(int id)
    {
        var student = await _context.Set<Student>().FindAsync(id);
        if(student is null)
        return;
        student.IsDeleted = true;
        await Save();
    }
}