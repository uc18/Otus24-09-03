using FamilyWallet.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.EntityFramework;

public class WalletDbContext : DbContext
{
    public WalletDbContext(DbContextOptions<WalletDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("userset");
            entity.Property(e => e.UserId).HasColumnName("userid");
            entity.Property(e => e.FirstName).HasColumnName("firstname");
            entity.Property(e => e.LastName).HasColumnName("lastname");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Phone).HasColumnName("phone");
            entity.Property(e => e.Login).HasColumnName("login");
            entity.Property(e => e.Password).HasColumnName("password");
            entity.Property(e => e.IsAdmin).HasColumnName("isadmin");
            entity.Property(e => e.IsActive).HasColumnName("isactive");
        });

        base.OnModelCreating(modelBuilder);
    }
}