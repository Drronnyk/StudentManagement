using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
    
    public DbSet<User>Users
    {
        get;
        set;
    }
     public DbSet<Student>Students
    {
        get;
        set;
    }
     public DbSet<Role>Roles
    {
        get;
        set;
    }
     public DbSet<Level>Levels
    {
        get;
        set;
    }
     public DbSet<Enrollement>Enrollements
    {
        get;
        set;
    }
     public DbSet<Departement>Departements
    {
        get;
        set;
    }
     public DbSet<Classroom>Classrooms
    {
        get;
        set;
    }
     public DbSet<AcademicYear>AcademicYears
    {
        get;
        set;
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>()
        .HasOne( u => u.Role)
        .WithMany(r => r.Users)
        .HasForeignKey(u => u.RoleId);
        modelBuilder.Entity<Classroom>()
        .HasOne(c => c.Departement )
        .WithMany(d => d.Classrooms )
        .HasForeignKey(c => c.DepartementId );
        modelBuilder.Entity<Classroom>()
        .HasOne(c => c.Level)
        .WithMany(l => l.Classrooms)
        .HasForeignKey(c => c.LevelId);
        modelBuilder.Entity<Enrollement>()
        .HasOne(e => e.Student)
        .WithMany(s => s.Enrollements)
        .HasForeignKey(e => e.StudentId);
        modelBuilder.Entity<Enrollement>()
        .HasOne(e => e.Classroom )
        .WithMany(c => c.Enrollements)
        .HasForeignKey(e =>e.ClassroomId);
        modelBuilder.Entity<Enrollement>()
        .HasOne(e => e.AcademicYear)
        .WithMany(a => a.Enrollements)
        .HasForeignKey(e => e.AcademicYearId);
        modelBuilder.Entity<User>()
        .HasIndex(u  => u.Email)
        .IsUnique();
        modelBuilder.Entity<Student>()
        .HasIndex(s => s.Email)
        .IsUnique();
        modelBuilder.Entity<Departement>()
        .HasIndex(d => d.Code)
        .IsUnique();
        modelBuilder.Entity<Student>()
        .HasIndex(s => s.RegistrationNumber)
        .IsUnique();

        


         

        
    
    }

    
}