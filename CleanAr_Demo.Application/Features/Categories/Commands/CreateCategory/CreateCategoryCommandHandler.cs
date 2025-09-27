using CleanAr_Demo.Application.Commands.Mappings;
using CleanAr_Demo.Application.Commands.Models.Responses;
using CleanAr_Demo.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : MediatR.IRequestHandler<CreateCategoryCommand, CategoryResponse>
    {
        private readonly IApplicationDbContext _context;

        public CreateCategoryCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = CategoryMapper.ToCreateEntity(request);
            category.CreatedOn = DateTime.UtcNow;

            _context.Categories.Add(category);

            await _context.SaveChangesAsync(cancellationToken);
            var categoryResponse = CategoryMapper.ToResponse(category);
            return categoryResponse;
        }
    }
}
