using MediatR;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary_GT_RT.Requests;
using GT_RT_BackEnd.Queries.Corridas;
using ClassLibrary_GT_RT;
using GT_RT_BackEnd.Commands.CorridaCommands;
using GT_RT_BackEnd.Handlers.CorridaHandlers;

namespace GT_RT_BackEnd.Controllers
{
    public class CorridaController : Controller
    {

        IMediator Mediator { get; set; }

        public CorridaController(IMediator mediator)
        {
            Mediator = mediator;
        }


        [HttpGet("Corridas")]
        public async Task<IActionResult> GetCorridas([FromQuery] CorridaRequest request)
        {
            var result = await Mediator.Send(new GetCorridasQuery
            {
                Search = request.Search
            });
            return Ok(result);
        }




        [HttpGet("Corrida-details/{id}")]
        public async Task<IActionResult> GetCorrida(int id)
        {
            var result = await Mediator.Send(new GetCorridaQuery(new CorridaRequest
            {
                Id_corrida = id
            }));
            return Ok(result);
        }

        [HttpGet("Corridas/{search}")]
        //public async Task<IActionResult> GetCorrida(string search)
        //{
        //    var result = await Mediator.Send(new GetCorridaQuery(new Models.CorridaRequest
        //    {
        //        Search = search
        //    }));
        //    return Ok(result);
        //}
        [HttpPost("Corridas")]
        public async Task<IActionResult> AddCorrida([FromBody] Corrida Corrida)
        {
            var result = await Mediator.Send(new AddCorridaCommand(Corrida));
            return Ok(result);
        }

        [HttpDelete("Corridas/{id}")]
        public async Task<IActionResult> DeleteCorrida(int id)
        {
            await Mediator.Send(new DeleteCorridaCommand(id));
            return Ok();
        }
        [HttpPut("Corrida-edit/{id}")]
        public async Task<IActionResult> UpdateCorrida([FromBody] Corrida Corrida, int id)
        {
            var result = await Mediator.Send(new UpdateCorridaCommand(Corrida, id));

            return Ok(result);
        }
    }
}
