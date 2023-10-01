using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TechSurvey.Entity.Concrete;

namespace TechSurvey.DAL.Contexts
{
    public class SqlDbContext : IdentityDbContext<AppUser, IdentityRole, string>
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SendSurveyDetails> SendSurveyDetails { get; set; }

        public SqlDbContext()
        {

        }
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=TechcareerSurveyDb;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
