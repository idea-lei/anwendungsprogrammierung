using apiProjekt.DataModel;
using Microsoft.EntityFrameworkCore;

namespace apiProjekt
{
    public class APIProjektDBContext: DbContext
    {
        public APIProjektDBContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamOfStudent> ExamsOfStudents { get;set; }
    }
}
