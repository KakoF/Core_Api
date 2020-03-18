using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agendamento.API.Domain.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        public int Id {get;set;}
        public string Email {get;set;}
        public string Nome {get;set;}
        public string Senha {get;set;}
        public IList<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
    }
}