using CadastroCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroCliente.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }


        //TABELA DE CLIENTES.
        public DbSet<ClienteModel> Clientes { get; set; }

        //TABELA DE FUNCIONÁRIOS.
        public DbSet<FuncionarioModel> Funcionarios { get; set; }   






    }
}
