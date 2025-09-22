using CleanAr_Demo.Application.Interfaces;
using CleanAr_Demo.Domain.Entities;
using CleanAr_Demo.Infrastructure.Identity;
using MayNghien.Infrastructures.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Infrastructure.Persistences
{
    public class ApplicationDbContext
        : BaseContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products => Set<Product>();
        public DbSet<Category> Categories => Set<Category>();

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // bạn có thể custom logic ở đây
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}