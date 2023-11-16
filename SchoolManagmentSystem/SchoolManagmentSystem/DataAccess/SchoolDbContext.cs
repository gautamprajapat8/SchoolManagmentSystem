using Microsoft.EntityFrameworkCore;
using SchoolManagmentSystem.Models;
using System.Runtime.Remoting.Contexts;

namespace SchoolManagmentSystem.DataAccess
{
    public class SchoolDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectMark> SubjectMarks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace "your_connection_string" with your actual SQL Server connection string
            string connectionString = "Server=localhost;Database=BPKTechnologies;User=root;Password=gautam;";

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
