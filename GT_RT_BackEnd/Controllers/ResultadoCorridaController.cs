using MediatR;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary_GT_RT.Requests;
using GT_RT_BackEnd.Queries.ResultadoCorridas;
using ClassLibrary_GT_RT;
using GT_RT_BackEnd.Commands.ResultadoCorridaCommands;
using GT_RT_BackEnd.Handlers.ResultadoCorridaHandlers;

namespace GT_RT_BackEnd.Controllers
{
    public class ResultadoCorridaController : Controller
    {

        IMediator Mediator { get; set; }

        public ResultadoCorridaController(IMediator mediator)
        {
            Mediator = mediator;
        }


        [HttpGet("ResultadoCorrida")]
        public async Task<IActionResult> GetResultadoCorridas([FromQuery] ResultadoCorridaRequest request)
        {
            var result = await Mediator.Send(new GetResultadoCorridasQuery
            {
                Search = request.Search
            });
            return Ok(result);
        }

 



        [HttpGet("ResultadoCorrida-details/{id}")]
        public async Task<IActionResult> GetResultadoCorrida(int id)
        {
            var result = await Mediator.Send(new GetResultadoCorridaQuery(new ResultadoCorridaRequest
            {
                Id_ResultadoCorridas = id
            }));
            return Ok(result);
        }

        [HttpGet("ResultadoCorridas/{search}")]
        //public async Task<IActionResult> GetResultadoCorrida(string search)
        //{
        //    var result = await Mediator.Send(new GetResultadoCorridaQuery(new Models.ResultadoCorridaRequest
        //    {
        //        Search = search
        //    }));
        //    return Ok(result);
        //}
        [HttpPost("ResultadoCorridas")]
        public async Task<IActionResult> AddResultadoCorrida([FromBody] ResultadoCorrida ResultadoCorrida)
        {
            var result = await Mediator.Send(new AddResultadoCorridaCommand(ResultadoCorrida));
            return Ok(result);
        }

        [HttpDelete("ResultadoCorridas/{id}")]
        public async Task<IActionResult> DeleteResultadoCorrida(int id)
        {
            await Mediator.Send(new DeleteResultadoCorridaCommand(id));
            return Ok();
        }
        [HttpPut("ResultadoCorrida-edit/{id}")]
        public async Task<IActionResult> UpdateResultadoCorrida([FromBody] ResultadoCorrida ResultadoCorrida, int id)
        {
            var result = await Mediator.Send(new UpdateResultadoCorridaCommand(ResultadoCorrida, id));

            return Ok(result);
        }
    }
}
