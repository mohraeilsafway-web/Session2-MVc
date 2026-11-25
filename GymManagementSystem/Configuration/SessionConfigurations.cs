using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configuration
{
    public class SessionConfigurations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.Property(S => S.CreatedAt)
                   .HasDefaultValueSql("GetDate()");
            builder.ToTable(TB =>
            {
                TB.HasCheckConstraint("CK_Capacity", "Capacity Between 1 And 25");
                TB.HasCheckConstraint("CK_EndDate", "EndDate > StartDate");

            });
        }
    }
}
