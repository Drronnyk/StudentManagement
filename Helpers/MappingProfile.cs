using AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Student,StudentDto>();
        CreateMap<CreateStudentDto, Student>();
        CreateMap<UpdateStudentDto, Student>();

        CreateMap<User,UserDto>();
        CreateMap<CreateUserDto, User>();
        CreateMap<UpdateUserDto, User>();

        CreateMap<Role,RoleDto>();
        CreateMap<CreateRoleDto, Role>();

        CreateMap<Level,LevelDto>();
        CreateMap<CreateLevelDto, Level>();
        CreateMap<UpdateLevelDto, Level>();

        CreateMap<Enrollement,EnrollementDto>();
        CreateMap<CreateEnrollmentDto, Enrollement>();
        CreateMap<UpdateEnrollmentDto, Enrollement>();


        CreateMap<Departement,DepartmentDto>();
        CreateMap<CreateDepartmentDto, Departement>();
        CreateMap<UpdateDepartmentDto, Departement>();

        CreateMap<Classroom,ClassroomDto>();
        CreateMap<CreateClassroomDto, Classroom>();
        CreateMap<UpdateClassroomDto, Classroom>();

        CreateMap<AcademicYear,AcademicYearDto>();
        CreateMap<CreateAcademicYearDto, AcademicYear>();
        CreateMap<UpdateAcademicYearDto, AcademicYear>();



        
    

    }
}