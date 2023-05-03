using MediatR;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary_GT_RT.Requests;
using GT_RT_BackEnd.Queries;
using ClassLibrary_GT_RT;
using GT_RT_BackEnd.Commands.PilotoCommands;

namespace GT_RT_BackEnd.Controllers
{
    public class PilotoController : Controller
    {

        IMediator Mediator { get; set; }

        public PilotoController(IMediator mediator)
        {
            Mediator = mediator;
        }

        
        [HttpGet("Pilotos")]
        public async Task<IActionResult> GetPilotos([FromQuery] PilotoRequest request)
        {
            var result = await Mediator.Send(new GetPilotosQuery
            {
                Search = request.Search
            });
            return Ok(result);
        }

        [HttpGet("Piloto-details/{id}")]
        public async Task<IActionResult> GetPiloto(int id)
        {
            var result = await Mediator.Send(new GetPilotoQuery(new PilotoRequest
            {
                Id_piloto = id
            }));
            return Ok(result);
        }

        [HttpGet("pilotos/{search}")]
        //public async Task<IActionResult> GetProduct(string search)
        //{
        //    var result = await Mediator.Send(new GetProductQuery(new Models.ProductRequest
        //    {
        //        Search = search
        //    }));
        //    return Ok(result);
        //}
        [HttpPost("Pilotos")]
        public async Task<IActionResult> AddPiloto([FromBody] Piloto piloto)
        {
            var result = await Mediator.Send(new AddPilotoCommand(piloto));
            return Ok(result);
        }

        [HttpDelete("pilotos/{id}")]
        public async Task<IActionResult> DeletePiloto(int id)
        {
            await Mediator.Send(new DeletePilotoCommand(id));
            return Ok();
        }
        [HttpPut("piloto-edit/{id}")]
        public async Task<IActionResult> UpdatePiloto([FromBody] Piloto piloto, int id)
        {
            var result = await Mediator.Send(new UpdatePilotoCommand(piloto, id));

            return Ok(result);
        }
    }
}
