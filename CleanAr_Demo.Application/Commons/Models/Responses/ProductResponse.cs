using MayNghien.Infrastructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Commands.Models.Responses
{
    public class ProductResponse : BaseDto
    {
        public string Name { get; set; }
        public string Provider { get; set; }

        public string CategoryName { get; set; }
    }
}
