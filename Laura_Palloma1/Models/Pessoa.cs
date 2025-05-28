using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Laura_Palloma1.Models
{
    public class Pessoa
    {
        [Display(Name = "Código do Cliente")]
        public int PessoaId { get; set; }
        [Display(Name = "Nome do Cliente")]
        public string? Nome { get; set; }
        [EmailAddress(ErrorMessage = "Endereço de email inválido")]
        public string? Email { get; set; }

    }
}