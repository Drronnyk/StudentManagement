using StudentManagementApi.Api.Helpers;

public interface IStudentService
{
    Task<IEnumerable<StudentDto>> GetAllStudents();

    Task<StudentDto?>  GetStudentById(int id);

    Task<StudentDto?>  GetStudentByRegistrationNumber(string matricule);

    Task<IEnumerable<StudentDto>> GetStudentByDepartement(string departmentName);

    Task<IEnumerable<StudentDto>> GetStudentByStatus(StudentStatus status);

    Task<StudentDto> CreateStudent(CreateStudentDto createStudentDtostudentDto);

    Task UpdateStudent(int id, UpdateStudentDto updateStudentDto);

    Task DeleteStudent(int id);

    Task<StudentDto?> RestoreStudent(int id);

    Task<StudentDto?>  ChangeStudentStatus(int id,StudentStatus status);

}