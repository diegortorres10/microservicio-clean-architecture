using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccessLayer.Models;

namespace DataAccessLayer.EntityMappers
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("clients");
            builder.HasKey(x => x.ClientId)
                   .HasName("pk_client");
            builder.Property(x => x.ClientId)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("client_id")
                   .HasColumnType("INT");
            builder.Property(x => x.Password)
                   .HasColumnName("password")
                   .HasColumnType("NVARCHAR(25)")
                   .IsRequired();
            builder.Property(x => x.State)
                   .HasColumnName("state")
                   .HasColumnType("BIT");
            builder.HasOne(x => x.Person)
                   .WithOne(x => x.Client)
                   .HasForeignKey<Client>(x => x.PersonId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("fk_client_account");
        }
    }
}
