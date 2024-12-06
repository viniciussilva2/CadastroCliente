using CadastroCliente.Data;
using CadastroCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroCliente.Repository

{
    public class FuncionarioRepository : IFuncionarioRepository
    {

        private readonly AppDbContext _context;


        public FuncionarioRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<FuncionarioModel> BucarFuncionarioPorId(int id)
        {
            return await _context.Funcionarios.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<List<FuncionarioModel>> BuscarTodosFuncionarios()
        {
            return await _context.Funcionarios.ToListAsync();
        }
              

        public async Task<FuncionarioModel> DeletarFuncionario(int id)
        {

            var funcionario = await _context.Funcionarios.Where(x => x.Id == id).FirstOrDefaultAsync();

            if (funcionario == null)
            {
                return null;
            }

            _context.Funcionarios.Remove(funcionario);
            await _context.SaveChangesAsync();

            return funcionario;
        
        }

        public async Task<FuncionarioModel> CriarFuncionario(FuncionarioModel funcionario)
        {
          
            if (funcionario == null)
            {
                return null;  
            }

            try
            {
                _context.Funcionarios.Add(funcionario);
                await _context.SaveChangesAsync();
                return funcionario;  
            }
            catch (Exception ex)
            {
                
                return null;
            }
        }


    }
}
