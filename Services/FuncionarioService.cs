using CadastroCliente.Models;
using CadastroCliente.Repository;

namespace CadastroCliente.Services
{
    public class FuncionarioService : IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public async Task<FuncionarioModel> BuscarFuncionarioPorId(int id)
        {
            return await _funcionarioRepository.BucarFuncionarioPorId(id);
        }

        public async Task<List<FuncionarioModel>> BuscarTodosFuncionarios()
        {
            return await _funcionarioRepository.BuscarTodosFuncionarios();
        }

        public async Task<FuncionarioModel> DeletarFuncionario(int id)
        {
            return await _funcionarioRepository.DeletarFuncionario(id);
        }

        public async Task<FuncionarioModel> CriarFuncionario(FuncionarioModel funcionario)  
        {
            return await _funcionarioRepository.CriarFuncionario(funcionario);
        }
    }
}
