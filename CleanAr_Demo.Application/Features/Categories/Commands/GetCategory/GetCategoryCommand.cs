using MediatR;
using CleanAr_Demo.Application.Commands.Models.Responses;

namespace CleanAr_Demo.Application.Features.Categories.Commands.GetCategory
{
    public class GetCategoryCommand : IRequest<CategoryResponse>
    {
        public Guid Id { get; set; }
    }
}