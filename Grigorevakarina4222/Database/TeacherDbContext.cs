using Grigorevakarina4222.Database.Configurations;
using Grigorevakarina4222.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Grigorevakarina4222.Database
{
    public class TeacherDbContext: DbContext
    {
        DbSet<Teacher> Teacher { get; set; }
        DbSet<AcademicDegree> AcademicDegree { get; set; }
        DbSet<JobPosition> JobPosition { get; set; }
        DbSet<Department> Department { get; set; }
        DbSet<Discipline> Discipline { get; set; }
        DbSet<WorkLoad> WorkLoad { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Добавляем конфигурации к таблицам
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new WorkLoadConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new AcademicDegreeConfiguration());
            modelBuilder.ApplyConfiguration(new JobPositionConfiguration());
        }
        public TeacherDbContext(DbContextOptions<TeacherDbContext> options) : base(options)
        { 

        }
    }
}
