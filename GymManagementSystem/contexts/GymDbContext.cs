using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GymManagementSystem.contexts
{
    public class GymDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQL2025;Database=GymManagmentSystem;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }
        public DbSet<Session> Sessions { get; set; }
    }
}
