using Microsoft.EntityFrameworkCore;

namespace CRUDwithASP.Models
{
    public class DatabaseEntities : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("server= DESKTOP-626PATH\\SQLEXPRESS; database =taskfive;Integrated Security=True; TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
        }
     public   DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseResult> CoursesResult { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Trainne> Trainnes { get; set; }

    }
}
