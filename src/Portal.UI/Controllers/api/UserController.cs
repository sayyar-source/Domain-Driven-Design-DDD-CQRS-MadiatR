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

namespace Portal.UI.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create(UserCreateCommand user)
        {
            try
            {
                var result =await _mediator.Send(user);
                return Ok(result);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _mediator.Send(new GetAllUserQuery());
            return Ok(result);
        }
        [HttpGet("findbyusername")]
        public async Task<IActionResult> FindByUsername(string username)
        {
            var result =await _mediator.Send(new FindUserByUsernameQuery() { Username = username });
            return Ok(result);
        }
    }
}