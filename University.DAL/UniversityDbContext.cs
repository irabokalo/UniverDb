

using System.Data.Entity;
using University.DAL.Models;

namespace University.DAL
{
    public class UniversityDbContext : DbContext
    {
        public UniversityDbContext() : base("name=UnivesityDb")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<UniversityDbContext>());
            Database.Initialize(true);
        }

        public DbSet<UniversityObject> UniversityObjects { get; set; }
        public DbSet<Entrant> Entrants { get; set; }
        public DbSet<ExcellentStudent> ExcellentStudents { get; set; }
        public DbSet<Graduate> Graduates { get; set; }
        public DbSet<Human> Humans { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Pair> Pairs { get; set; }
        public DbSet<Practice> Practices { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}