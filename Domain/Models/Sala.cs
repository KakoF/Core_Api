using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agendamento.API.Domain.Models
{
    [Table("Salas")]
    public class Sala
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public IList<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
        
    }
}