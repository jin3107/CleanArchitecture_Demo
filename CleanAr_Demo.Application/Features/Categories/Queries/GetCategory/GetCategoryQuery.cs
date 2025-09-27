using MediatR;
using CleanAr_Demo.Application.Commands.Models.Responses;
using CleanAr_Demo.Application.Commands.Models.Requests;

namespace CleanAr_Demo.Application.Features.Categories.Queries.GetCategory
{
    public class GetCategoryQuery : IRequest<CategoryResponse>
    {
        public Guid Id { get; set; }
    }
}