using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlite("Data Source = StudentManagement.db ")
);
builder.Services.AddAutoMapper(typeof(MappingProfile));
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IDepartementRepository, DepartmentRepository>();
var app = builder.Build();
app.MapControllers();
app.Run();