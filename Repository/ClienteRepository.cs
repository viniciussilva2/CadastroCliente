using CadastroCliente.Models;
using CadastroCliente.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CadastroCliente.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;


        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ClienteModel> AdicionarCliente(ClienteModel cliente)
        {
            await _context.Clientes.AddAsync(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }


        public async Task<ClienteModel> BuscarClientePorId(int id)
        {
            return await _context.Clientes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<ClienteModel>> BuscarTodosClientes()
        {
            return await _context.Clientes.ToListAsync();
        }
    }
}
