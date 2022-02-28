using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccessLayer.Models;

namespace DataAccessLayer.EntityMappers
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("persons");
            builder.HasKey(x => x.PersonId)
                   .HasName("pk_user");
            builder.Property(x => x.PersonId)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("person_id")
                   .HasColumnType("INT");
            builder.Property(x => x.Name)
                   .HasColumnName("name")
                   .HasColumnType("NVARCHAR(250)")
                   .IsRequired();
            builder.Property(x => x.Gender)
                   .HasColumnName("gender")
                   .HasColumnType("NVARCHAR(50)")
                   .IsRequired();
            builder.Property(x => x.Age)
                  .HasColumnName("age")
                  .HasColumnType("INT")
                  .IsRequired();
            builder.Property(x => x.Identification)
                  .HasColumnName("identification")
                  .HasColumnType("NVARCHAR(15)")
                  .IsRequired();
            builder.Property(x => x.Address)
                  .HasColumnName("address")
                  .HasColumnType("NVARCHAR(150)")
                  .IsRequired();
            builder.Property(x => x.Phone)
                  .HasColumnName("phone")
                  .HasColumnType("NVARCHAR(15)")
                  .IsRequired();
        }
    }
}
