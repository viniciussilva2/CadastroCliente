using CadastroCliente.Models;

namespace CadastroCliente.Services
{
    public interface IFuncionarioService
    {
        Task<FuncionarioModel> BuscarFuncionarioPorId(int id);

        Task<List<FuncionarioModel>> BuscarTodosFuncionarios();

        Task<FuncionarioModel> CriarFuncionario(FuncionarioModel funcionario); 

        Task<FuncionarioModel> DeletarFuncionario(int id);
    }
}
