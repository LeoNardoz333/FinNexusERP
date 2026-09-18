using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FinNexus.Application.Common.Interfaces.Persistence;
using FinNexus.Infrastructure.Persistence.Context;
using FinNexus.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FinNexus.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );

            services.AddIdentityCore<ApplicationUser>()
                .AddRoles<IdentityRole<Guid>>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            return services;
        }
    }
}