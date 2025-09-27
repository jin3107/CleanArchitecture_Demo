using CleanAr_Demo.Application.Commands.Models.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Features.Categories.Queries.GetAllCategory
{
    public class GetAllCategoryQuery : IRequest<List<CategoryResponse>>
    {
    }
}
