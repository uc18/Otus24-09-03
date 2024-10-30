using Domain.EntityFramework;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.EntityFrameworkCore;


namespace FamilyWallet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        private IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var applicationSettings = Configuration.Get<ApplicationSettings>();
            services.AddEndpointsApiExplorer();
            services.AddSingleton((IConfigurationRoot)Configuration);
            services.AddDbContext<WalletDbContext>(optionsBuilder
                => optionsBuilder
                .UseNpgsql(applicationSettings.ConnectionString));

            services.AddControllers();
            services.AddSwaggerGen();
            services.AddCors();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

        }
    }
}
