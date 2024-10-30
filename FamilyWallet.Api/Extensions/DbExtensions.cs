using Domain.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace FamilyWallet.Extensions;

public static class DbExtensions
{
    public static IServiceCollection AddDbContext(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<WalletDbContext>(o => o.UseNpgsql(connectionString));
        return services;
    }
}