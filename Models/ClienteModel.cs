using System.ComponentModel.DataAnnotations;

namespace CadastroCliente.Models
{
    public class ClienteModel
    {

        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public int Idade { get; set; }

    }
}
