using CleanAr_Demo.Application.Commands.Mappings;
using CleanAr_Demo.Application.Commands.Models.Responses;
using CleanAr_Demo.Application.Features.Categories.Commands.CreateCategory;
using CleanAr_Demo.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Features.Categories.Commands.GetCategory
{
    public class GetCategoryCommandHandler : IRequestHandler<CreateCategoryCommandResponse, CategoryResponse>
    {
        private readonly IApplicationDbContext _context;

        public GetCategoryCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CategoryResponse> Handle(CreateCategoryCommandResponse request, CancellationToken cancellationToken)
        {
            var category = await _context.Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Name == request.Name, cancellationToken);
            if (category == null)
                return new CategoryResponse { Name = string.Empty, Id = null };

            var categoryResponse = CategoryMapper.ToResponse(category);

            return categoryResponse;
        }
    }
}
