using CadastroCliente.Models;
using System.Threading.Tasks;

namespace CadastroCliente.Services
{
    public interface IClienteService
    {
        Task<ClienteModel> AdicionarCliente(ClienteModel cliente); 

        Task<ClienteModel> BuscarClientePorId(int id);

        Task<List<ClienteModel>> BuscarTodosClientes();
    }
}
