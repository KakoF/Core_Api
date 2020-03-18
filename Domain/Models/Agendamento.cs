using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Agendamento.API.Domain.Models
{
    [Table("Agendamentos")]
    public class Agendamento
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public DateTime DataInicio {get;set;}
        public DateTime DataFim {get;set;}
        public EIntervalo Intervalo {get;set;}
        public int UsuarioId {get;set;}
         public Usuario Usuario {get;set;}
        public int SalaId {get;set;}
        public Sala Sala {get;set;}
    }
}