using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.EntityMappers
{
    public class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("accounts");
            builder.HasKey(x => x.AccountId)
                   .HasName("pk_account");
            builder.Property(x => x.AccountId)
                   .ValueGeneratedOnAdd()
                   .HasColumnName("account_id")
                   .HasColumnType("INT");
            builder.Property(x => x.AccountNumber)
                   .HasColumnName("account_number")
                   .HasColumnType("INT")
                   .IsRequired();
            builder.Property(x => x.AccountType)
                   .HasColumnName("account_type")
                   .HasColumnType("NVARCHAR(100)")
                   .IsRequired();
            builder.Property(x => x.InitialBalance)
                   .HasColumnName("initial_balance")
                   .HasColumnType("REAL");
            builder.Property(x => x.State)
                  .HasColumnName("state")
                  .HasColumnType("BIT");
            builder.HasOne(x => x.Client)
                   .WithOne(x => x.Account)
                   .HasForeignKey<Account>(x => x.ClientId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("fk_account_client");
        }
    }
}
