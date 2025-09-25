using CleanAr_Demo.Application.Commands.Mappings;
using CleanAr_Demo.Application.Commands.Models.Requests;
using CleanAr_Demo.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandHandler : MediatR.IRequestHandler<CreateCategoryCommand, CategoryRequest>
    {
        private readonly IApplicationDbContext _context;

        public CreateCategoryCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CategoryRequest> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = CategoryMapper.ToEntity(request);
            category.CreatedOn = DateTime.UtcNow;

            _context.Categories.Add(category);

            await _context.SaveChangesAsync(cancellationToken);
            var categoryRequest = CategoryMapper.ToRequest(category);
            return categoryRequest;
        }
    }
}
