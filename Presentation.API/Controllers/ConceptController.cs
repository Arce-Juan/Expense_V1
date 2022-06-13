using Core.Application.Features.Concepts.Commands.CreateConceptCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConceptController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> Post(CreateConceptCommand command)
        {
            return Ok(await Mediator.Send(command));
        }
    }
}
