using CadastroCliente.Models;

namespace CadastroCliente.Repository
{
    public interface IFuncionarioRepository
    {
        Task<FuncionarioModel> BucarFuncionarioPorId(int id);

        Task<List<FuncionarioModel>> BuscarTodosFuncionarios();

        Task<FuncionarioModel> CriarFuncionario(FuncionarioModel funcionario);

        Task<FuncionarioModel> DeletarFuncionario(int id);
    }
}
