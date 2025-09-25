using MayNghien.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Commands.Models.Requests
{
    public class CategoryRequest : BaseDto
    {
        [Required]
        [StringLength(100, ErrorMessage = "Category name must not exceed 100 characters.")]
        public string Name { get; set; }
    }
}
