using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFA.EF.CodeFirst.Workshop.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext()
        {
            Database.SetInitializer<StudentContext>(new DropCreateDatabaseIfModelChanges<StudentContext>());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddress { get; set; }
        public DbSet<Standard> Standards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasKey(x => x.StudentKey)
                .Property(x => x.StudentName).HasMaxLength(300);
            base.OnModelCreating(modelBuilder);
        }
    }
}
