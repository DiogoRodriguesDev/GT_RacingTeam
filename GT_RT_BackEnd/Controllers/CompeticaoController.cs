using MediatR;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary_GT_RT.Requests;
using GT_RT_BackEnd.Queries.Competicoes;
using ClassLibrary_GT_RT;
using GT_RT_BackEnd.Commands.CompeticaoCommands;
using GT_RT_BackEnd.Handlers.CompeticaoHandlers;

namespace GT_RT_BackEnd.Controllers
{
    public class CompeticaoController : Controller
    {

        IMediator Mediator { get; set; }

        public CompeticaoController(IMediator mediator)
        {
            Mediator = mediator;
        }


        [HttpGet("Competicoes")]
        public async Task<IActionResult> GetCompeticoes([FromQuery] CompeticaoRequest request)
        {
            var result = await Mediator.Send(new GetCompeticoesQuery
            {
                Search = request.Search
            });
            return Ok(result);
        }




        [HttpGet("Competicao-details/{id}")]
        public async Task<IActionResult> GetCompeticao(int id)
        {
            var result = await Mediator.Send(new GetCompeticaoQuery(new CompeticaoRequest
            {
                Id_Competicao = id
            }));
            return Ok(result);
        }

        [HttpGet("Competicaos/{search}")]
        //public async Task<IActionResult> GetCompeticao(string search)
        //{
        //    var result = await Mediator.Send(new GetCompeticaoQuery(new Models.CompeticaoRequest
        //    {
        //        Search = search
        //    }));
        //    return Ok(result);
        //}
        [HttpPost("Competicao")]
        public async Task<IActionResult> AddCompeticao([FromBody] Competicao Competicao)
        {
            var result = await Mediator.Send(new AddCompeticaoCommand(Competicao));
            return Ok(result);
        }

        [HttpDelete("Competicao/{id}")]
        public async Task<IActionResult> DeleteCompeticao(int id)
        {
            await Mediator.Send(new DeleteCompeticaoCommand(id));
            return Ok();
        }
        [HttpPut("Competicao-edit/{id}")]
        public async Task<IActionResult> UpdateCompeticao([FromBody] Competicao Competicao, int id)
        {
            var result = await Mediator.Send(new UpdateCompeticaoCommand(Competicao, id));

            return Ok(result);
        }
    }
}
