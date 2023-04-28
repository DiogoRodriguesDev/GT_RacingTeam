using MediatR;
using Microsoft.AspNetCore.Mvc;
using ClassLibrary_GT_RT.Requests;
using GT_RT_BackEnd.Queries;
using ClassLibrary_GT_RT;

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

        [HttpGet("products/{search}")]
        //public async Task<IActionResult> GetProduct(string search)
        //{
        //    var result = await Mediator.Send(new GetProductQuery(new Models.ProductRequest
        //    {
        //        Search = search
        //    }));
        //    return Ok(result);
        //}
        [HttpPost("Pilotos")]
        public async Task<IActionResult> AddProduct([FromBody] Piloto product)
        {
            var result = await Mediator.Send(new AddProductCommand(product));
            return Ok(result);
        }

        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            await Mediator.Send(new DeletePilotoCommand(id));
            return Ok();
        }
        [HttpPut("product-edit/{id}")]
        public async Task<IActionResult> UpdateProduct([FromBody] Piloto product, int id)
        {
            var result = await Mediator.Send(new UpdatePilotoCommand(product, id));

            return Ok(result);
        }
    }
}
