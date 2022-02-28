using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityMappers
{
    public class MovementMap : IEntityTypeConfiguration<Movement>
    {
        public void Configure(EntityTypeBuilder<Movement> builder)
        {
            builder.ToTable("movements");
            builder.HasKey(x => x.MovementId)
                   .HasName("pk_movement");
            builder.Property(x => x.MovementId)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("movement_id")
                   .HasColumnType("INT");
            builder.Property(x => x.MovementDate)
                   .HasColumnName("movement_date")
                   .HasColumnType("DATETIME")
                   .IsRequired();
            builder.Property(x => x.MovementType)
                   .HasColumnName("movement_type")
                   .HasColumnType("NVARCHAR(100)")
                   .IsRequired();
            builder.Property(x => x.MovementValue)
                   .HasColumnName("movement_value")
                   .HasColumnType("REAL")
                   .IsRequired();
            builder.Property(x => x.Balance)
                   .HasColumnName("balance")
                   .HasColumnType("REAL");
            builder.HasOne(x => x.Account)
                   .WithOne(x => x.Movement)
                   .HasForeignKey<Movement>(x => x.AccountId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("fk_movement_account");
        }
    }
}
