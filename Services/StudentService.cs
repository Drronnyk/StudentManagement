using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentManagementApi.Api.Helpers;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _repository;
    private readonly IMapper _mapper;
    private readonly IDepartementRepository _departmentRepository;

    public StudentService(IStudentRepository repository, IMapper mapper, IDepartementRepository departmentRepository)
    {
        _repository = repository;
        _mapper = mapper;
        _departmentRepository = departmentRepository;
    }
    public async Task<IEnumerable<StudentDto>> GetAllStudents()
    {
     var AllStudent =   await _repository.GetAll();
     return _mapper.Map<IEnumerable<StudentDto>>(AllStudent);
    }
    public async Task<StudentDto?>  GetStudentById(int id)
    {
        var student = await _repository.GetById(id);
        return _mapper.Map<StudentDto>(student);

    }
    public async Task<StudentDto?>  GetStudentByRegistrationNumber(string matricule)
    {
        var student  = await _repository.GetByRegistrationNumber(matricule);
        return _mapper.Map<StudentDto>(student);

    }
    public async Task<IEnumerable<StudentDto>> GetStudentByDepartement(string departmentName)
    {
        var NameDepartement = await _departmentRepository.GetByName(departmentName);
        if(NameDepartement is null)
        return new List<StudentDto>();
        var students =  await _repository.GetByDepartment(NameDepartement.Id);
        return _mapper.Map<IEnumerable<StudentDto>>(students);
    }
    public async Task<IEnumerable<StudentDto>> GetStudentByStatus(StudentStatus status)
    {
        var students = await _repository.GetByStatus(status);
        return _mapper.Map<IEnumerable<StudentDto>> (students);
    }
    public async Task<StudentDto> CreateStudent(CreateStudentDto createStudentDto)
    {
        var student = _mapper.Map<Student>(createStudentDto);
        await _repository.Add(student);
        await _repository.Save();
        return _mapper.Map<StudentDto>(student);
    }
    public async Task UpdateStudent(int id, UpdateStudentDto updateStudentDto)
    {
        var students = await _repository.GetById(id);
        if(students is null)
        return;
        _mapper.Map(updateStudentDto,students);
        await _repository.Update(students);
        await _repository.Save();
        
    }
    public async  Task DeleteStudent(int id)
    {
        var student = await _repository.GetById(id);
        if(student is null)
        return;
        await _repository.SoftDelete(student.Id);
        await _repository.Save();
    }
    public async Task<StudentDto?> RestoreStudent(int id)
    {
        var student  = await _repository.GetDeleteById(id);
        if(student is null)
        return null;
       var StudentRestored = await _repository.Restore(student.Id);
       if(StudentRestored is null)
       return null;
       await _repository.Save();
       return _mapper.Map<StudentDto>(StudentRestored);

        
    }
    public async Task<StudentDto?>  ChangeStudentStatus(int id,StudentStatus newStatus)
    {
        var Student = await _repository.GetById(id);
        if( Student is null)
        return null ;
        Student.Status = newStatus;
        await _repository.Update(Student);
        await _repository.Save();
        return _mapper.Map<StudentDto>(Student);
       

    }

}