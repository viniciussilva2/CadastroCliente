using CadastroCliente.Models;
using CadastroCliente.Repositories; 
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

      
        public async Task<ClienteModel> AdicionarCliente(ClienteModel cliente)
        {
            return await _clienteRepository.AdicionarCliente(cliente);
        }

        public async Task<ClienteModel> BuscarClientePorId(int id)
        {
            return await _clienteRepository.BuscarClientePorId(id);
        }

    
        public async Task<List<ClienteModel>> BuscarTodosClientes()
        {
            return await _clienteRepository.BuscarTodosClientes();
        }
    }
}
