using FamilyWallet.Domain;
using Microsoft.EntityFrameworkCore;

namespace Domain.EntityFramework;

public class WalletDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<WalletAndGroup> WalletsAndGroups { get; set; }

    public WalletDbContext(DbContextOptions<WalletDbContext> options) : base(options)
    {

    }
}