using System;
using System.ComponentModel.DataAnnotations;

namespace MvcCliente.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Matricula { get; set; }
        public int Idade { get; set; }
        public string Profissão { get; set; }
        public string Senha { get; set; }
    }
}