using System.ComponentModel.DataAnnotations;

namespace CadastroCliente.Models
{
    public class FuncionarioModel
    {

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public int Idade { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

    }
}
