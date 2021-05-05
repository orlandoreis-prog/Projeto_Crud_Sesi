using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFiebSesi.Models
{
    public class Colaborador
    {
        [Key]
        public int FuncionarioId { get; set; }

        [Required,MaxLength(100, ErrorMessage = "Nome não pode exceder 100 caracteres")]
        public string Nome { get; set; }

        public string CPF { get; set; }

        [Required, EmailAddress (ErrorMessage = "Email com formato inválido")]
        public string Email { get; set; }

        [Required, Phone(ErrorMessage = "Telefone com formato inválido")]        
        public int Telefone { get; set; }

        public int Habilitacao { get; set; }

        public int Categoria { get; set; }

        public int LinguaEstrangeria { get; set; }

        public int Estado { get; set; }

        public int Cidade { get; set; }

        public int Cep { get; set; }

        public int Logradouro { get; set; }

        public int Numero { get; set; }

        public int Complemento { get; set; }

        public int Cargo { get; set; }

        [Required, Range(0, 999.99)]
        public int SalarioProposto { get; set; }

        

    }
}
