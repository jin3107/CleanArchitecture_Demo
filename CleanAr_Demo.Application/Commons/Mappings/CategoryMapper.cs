using CleanAr_Demo.Application.Commands.Models.Requests;
using CleanAr_Demo.Application.Commands.Models.Responses;
using CleanAr_Demo.Application.Features.Categories.Commands.CreateCategory;
using CleanAr_Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr_Demo.Application.Commands.Mappings
{
    public static class CategoryMapper
    {
        public static CategoryResponse ToResponse(Category category)
        {
            return new CategoryResponse
            {
                Id = category.Id,
                Name = category.Name,
            };
        }

        public static Category ToCreateEntity(CreateCategoryCommand request)
        {
            return new Category
            {
                Name = request.Name,
            };
        }

        public static CategoryRequest ToRequest(Category category)
        {
            return new CategoryRequest
            {
                Id = category.Id,
                Name = category.Name,
            };
        }
    }
}
