using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configuration
{
    public class PlanConfigurations : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(P => P.CreatedAt)
                   .HasDefaultValueSql("GetDate()");
            builder.ToTable(TB =>
            {
                TB.HasCheckConstraint("CK_DurationDays", "DurationDays Between 1 And 365");
            });
        }
    }
}
