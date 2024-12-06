using CadastroCliente.Models;
using CadastroCliente.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadastroCliente.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {

        private readonly IFuncionarioService _funcionarioService;

        public FuncionarioController(IFuncionarioService funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodosFuncionarios()
        {

            var funcionariosObtidos = await _funcionarioService.BuscarTodosFuncionarios();

            if (funcionariosObtidos == null)
            {
                return BadRequest("Não foi encontrado nenhum funcionário.");
            }

            return Ok(funcionariosObtidos);

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterFuncionarioPorId(int id)
        {
            var funcionarioId = await _funcionarioService.BuscarFuncionarioPorId(id);

            if (funcionarioId == null)
            {
                return BadRequest("Nenhum funcionário encontrado.");
            }

            return Ok(funcionarioId);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> ExcluirFuncionarioPorId(int id)
        {

            var funcionarioId = await _funcionarioService.DeletarFuncionario(id);

            if (funcionarioId == null)
            {
                return BadRequest("Não foi encontrado nenhum funcionário para deletar.");
            }

            return Ok(funcionarioId);

        }

        [HttpPost]
        public async Task<IActionResult> CriarFuncionario([FromBody] FuncionarioModel funcionario)
        {
            var funcionarioNovo = await _funcionarioService.CriarFuncionario(funcionario);

            if (funcionarioNovo == null)
            {
                return BadRequest("Não foi possível criar o funcionário");
            }

            return Ok(funcionarioNovo);
        }




    }
}
