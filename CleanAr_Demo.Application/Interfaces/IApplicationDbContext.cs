using CleanAr_Demo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Product> Products { get; }
        DbSet<Category> Categories { get; }
        Task<int> SaveChangesAsync(CancellationToken ct = default);
    }
}
