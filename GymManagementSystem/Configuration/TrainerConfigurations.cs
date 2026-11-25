using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configuration
{
    public class TrainerConfigurations : GymUserConfigurations<Trainer> ,IEntityTypeConfiguration<Trainer>
    {
        public void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(T => T.CreatedAt)
                   .HasDefaultValueSql("GetDate()");
            base.Configure(builder);
        }
    }
}
