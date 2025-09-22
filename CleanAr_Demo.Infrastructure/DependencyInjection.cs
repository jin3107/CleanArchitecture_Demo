using CleanAr_Demo.Application.Interfaces;
using CleanAr_Demo.Infrastructure.Identity;
using CleanAr_Demo.Infrastructure.Persistences;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // DbContext (MySQL)
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    configuration.GetConnectionString("DefaultConnection"),
                    new MySqlServerVersion(new Version(8, 0, 43))));

            // Expose DbContext qua interface cho Application
            // Fix for CS0266 and CS1662:
            // The lambda must explicitly cast ApplicationDbContext to IApplicationDbContext
            services.AddScoped<IApplicationDbContext>(sp => (IApplicationDbContext)sp.GetRequiredService<ApplicationDbContext>());

            // Identity + store (nếu dùng)
            services
                .AddIdentity<ApplicationUser, IdentityRole>(opt =>
                {
                    opt.User.RequireUniqueEmail = false;
                    opt.Password.RequireDigit = false;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireUppercase = false;
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.SignIn.RequireConfirmedAccount = false;
                    opt.SignIn.RequireConfirmedPhoneNumber = false;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            // Services (Implementations)


            // Repositories
            

            return services;
        }
    }
}
