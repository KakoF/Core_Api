using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;

namespace Agendamento.API.Domain.Services
{
    public interface IAgendamentoService
    {
          Task<IEnumerable<Models.Agendamento>> ListAsync();
    }
}