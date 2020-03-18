using System.ComponentModel;

namespace Agendamento.API.Domain.Models
{
    public enum EIntervalo: byte
    {
        [Description("Dia")]
        Dia = 1,
        [Description("Semana")]
        Semana = 7,
        [Description("Mês")]
        Mes = 30
    }
}