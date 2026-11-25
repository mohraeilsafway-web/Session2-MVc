using GymManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GymManagementSystem.Configuration
{
    public class GymUserConfigurations<T> : IEntityTypeConfiguration<T> where T : GymUser
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(U => U.Name)
                   .HasColumnType("varchar")
                   .HasMaxLength(50);

            builder.Property(U => U.Phone)
                 .HasColumnType("varchar")
                 .HasMaxLength(11);
            builder.HasIndex(U => U.Email).IsUnique();
            builder.HasIndex(U => U.Phone).IsUnique();

            builder.ToTable(TB =>
            {
                TB.HasCheckConstraint("CK_Email", "Email like '_%@_%._%'");
                TB.HasCheckConstraint("CK_Phone", "Len(Phone)=11 And(Phone like '010%'or Phone like '011%'or Phone like '012%' or Phone like '015%' )");
            });
            builder.ComplexProperty(U => U.Aderess);

        }
    }
}
