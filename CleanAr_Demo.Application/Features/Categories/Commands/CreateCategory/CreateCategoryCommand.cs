using CleanAr_Demo.Application.Commands.Models.Requests;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Features.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand : MediatR.IRequest<CategoryRequest>
    {
        [Required]
        [StringLength(100, ErrorMessage = "Category name must not exceed 100 characters.")]
        public string Name { get; set; }
    }
}
