using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartHint.Models;
using SmartHint.Repositories;

namespace SmartHint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        private readonly ICompradorRepository _repository;
        public CatalogController(ICompradorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Comprador>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Comprador>>> GetCompradores()
        {
            var compradores = await _repository.GetCompradores();
            return Ok("");
        }

        [HttpPost]
        [ProducesResponseType(typeof(Comprador), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<Comprador> CreateCompradores(Comprador comprador)
        {
          
            await _repository.CreateComprador(comprador);
            return comprador;
        }
        [HttpPut]
        [ProducesResponseType(typeof(Comprador), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Comprador>> UpdateCompradores([FromBody] Comprador comprador)
        {
            if (comprador is null)
                return BadRequest("Comprador Invalido");

            return Ok(await _repository.UpdateComprador(comprador));
        }
        [HttpDelete("{id:length(24)}", Name = "Deletar Comprador")]
        [ProducesResponseType(typeof(Comprador), StatusCodes.Status200OK)]

        public async Task<IActionResult> DeleteProductById(string id)
        {
            return Ok(await _repository.DeleteComprador(id));
        }
    }
}
