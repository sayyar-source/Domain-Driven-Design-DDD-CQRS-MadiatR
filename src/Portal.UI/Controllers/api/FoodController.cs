using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portal.Application.FoodApplication.Commands.Create;
using Portal.Application.FoodApplication.Queris.FindAll;
using Portal.Application.FoodApplication.Queris.FindBy;
using Portal.Application.Foods.Models;

namespace Portal.UI.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        IMediator _mediator;
        public FoodController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create(FoodAddInfo food)
        {
            var result = await _mediator.Send(new FoodCreateCommand() 
            {
                Description=food.Description,
                FoodType=food.FoodType,
                Name=food.Name,
                Price=food.Price
            });
            return Ok(result);
        }
        [HttpGet("findall")]
        public async Task<IActionResult> FindAll()
        {
            var result =await _mediator.Send(new GetAllFoodQuery());
            return Ok(result);

        }
        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result =await _mediator.Send(new FindFoodByIdQuery() { ID = id });
            return Ok(result);
        }
     
    }
}