using CleanAr_Demo.Application.Commands.Models.Requests;
using CleanAr_Demo.Application.Commands.Models.Responses;
using CleanAr_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Commands.Mappings
{
    public static class ProductMapper
    {
        public static ProductResponse ToResponse(Product product)
        {
            return new ProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Provider = product.Provider,
            };
        }

        public static Product ToEntity(ProductRequest request)
        {
            return new Product
            {
                Name = request.Name,
                Provider = request.Provider,
            };
        }

        public static ProductRequest ToRequest(Product product)
        {
            return new ProductRequest
            {
                Id = product.Id,
                Name = product.Name,
                Provider = product.Provider,
            };
        }
    }
}
