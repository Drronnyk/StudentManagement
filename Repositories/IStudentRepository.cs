using StudentManagementApi.Api.Helpers;

public interface IStudentRepository : IGenericRepository<Student>
{
    Task<Student?> GetByRegistrationNumber(string registrationNumber);
    Task<Student?> GetByEmail(string email);

    Task<Student?> GetWithEnrollment(int id);

    Task<IEnumerable<Student>> GetByDepartment(int departmentId);

    
    Task<IEnumerable<Student>> GetByStatus(StudentStatus status);

    Task<Student?> GetDeleteById(int id);

    Task<Student?> Restore(int id);

    Task SoftDelete(int id);
}