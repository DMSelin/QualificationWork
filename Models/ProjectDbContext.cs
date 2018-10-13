using Microsoft.EntityFrameworkCore;

namespace QualificationWork.Models
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Nomenclature> Nomenclatures { get; set; }
        public DbSet<Branche> Branches { get; set; }
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
