using CleanAr_Demo.Application.Commands.Mappings;
using CleanAr_Demo.Application.Commands.Models.Requests;
using CleanAr_Demo.Application.Commands.Models.Responses;
using CleanAr_Demo.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CleanAr_Demo.Application.Features.Categories.Queries.GetCategory
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, CategoryResponse>
    {
        private readonly IApplicationDbContext _context;

        public GetCategoryQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CategoryResponse> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var category = await _context.Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == request.Id, cancellationToken);

            if (category == null)
                return new CategoryResponse { Name = string.Empty, Id = null };

            var categoryResponse = CategoryMapper.ToResponse(category);
            return categoryResponse;
        }
    }
}
