using CleanAr_Demo.Application.Commands.Models.Responses;
using CleanAr_Demo.Application.Features.Categories.Commands.CreateCategory;
using CleanAr_Demo.Application.Features.Categories.Queries.GetAllCategory;
using CleanAr_Demo.Application.Features.Categories.Queries.GetCategory;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanAr_Demo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCategoryCommand command)
        {
            var categoryId = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetById), new { id = categoryId }, categoryId);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var command = new GetCategoryQuery { Id = id };
            var category = await _mediator.Send(command);
            return Ok(category);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _mediator.Send(new GetAllCategoryQuery());
            return Ok(categories);
        }
    }
}
