using CleanAr_Demo.Application.Commands.Models.Responses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand : MediatR.IRequest<CategoryResponse>
    {
        public string Name { get; set; }
    }
}
