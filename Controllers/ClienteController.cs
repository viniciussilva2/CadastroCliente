using CadastroCliente.Models;
using CadastroCliente.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCliente.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {

        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }


        [HttpPost]
        public async Task<IActionResult> AdicionarCliente([FromBody] ClienteModel cliente)
        {
            if(cliente == null)
            {
                return BadRequest("Cliente não pode ser nulo");
            }

            var clienteAdicionado = await _clienteService.AdicionarCliente(cliente);

            return CreatedAtAction(nameof(BuscarClientePorId), new { id = clienteAdicionado.Id }, clienteAdicionado);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> BuscarClientePorId(int id)
        {
            var cliente = await _clienteService.BuscarClientePorId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpGet]
        public async Task<IActionResult> BuscarTodosClientes()
        {

            var clientes = await _clienteService.BuscarTodosClientes();

            if(clientes == null)
            {
                return BadRequest("Não foram encontrados clientes");
            }

            return Ok(clientes);
        }



    }
}
