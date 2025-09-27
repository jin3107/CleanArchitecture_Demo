using CleanAr_Demo.Application.Commands.Mappings;
using CleanAr_Demo.Application.Commands.Models.Responses;
using CleanAr_Demo.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Features.Categories.Queries.GetAllCategory
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQuery, List<CategoryResponse>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllCategoryQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryResponse>> Handle(GetAllCategoryQuery request, CancellationToken cancellationToken)
        {
            var categories = await _context.Categories.AsNoTracking().ToListAsync();
            return categories.Select(CategoryMapper.ToResponse).ToList();
        }
    }
}
