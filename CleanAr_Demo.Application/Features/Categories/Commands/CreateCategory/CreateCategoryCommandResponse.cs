using CleanAr_Demo.Application.Commands.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommandResponse : MediatR.IRequest<CategoryResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
