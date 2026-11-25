using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configuration
{
    public class MemberConfigurations : GymUserConfigurations<Member>, IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(M => M.CreatedAt)
                   .HasColumnName("JoinDate")
                   .HasDefaultValueSql("GetDate()");

            base.Configure(builder);

        }
    }
}
