using MayNghien.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Commands.Models.Requests
{
    public class ProductRequest : BaseDto
    {
        [Required]
        [StringLength(100, ErrorMessage = "Product name must not exceed 100 characters.")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Provider name must not exceed 100 characters.")]
        public string Provider { get; set; }
    }
}
