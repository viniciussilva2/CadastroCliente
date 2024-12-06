using CadastroCliente.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Repositories
{
    public interface IClienteRepository
    {
        Task<ClienteModel> AdicionarCliente(ClienteModel cliente);

        Task<ClienteModel> BuscarClientePorId(int id);

        Task<List<ClienteModel>> BuscarTodosClientes();
    }
}
