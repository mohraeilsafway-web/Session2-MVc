using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configuration
{
    public class MemberShipConfigurations : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            builder.Property(M => M.CreatedAt)
                   .HasDefaultValueSql("GetDate()");


            builder.HasOne(M=>M.Plan)
                   .WithMany(P=>P.MemberShips)
                   .HasForeignKey(M=>M.PlanId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
