using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;

namespace Agendamento.API.Domain.Repositories
{
    public interface IAgendamentoRepository 
    {
         Task<IEnumerable<Models.Agendamento>> ListAsync();
         Task AddAsync(Models.Agendamento agendamento);
         Task<Models.Agendamento> FindByIdAsync(int id);
         void Update(Models.Agendamento agendamento);
         void Remove(Models.Agendamento agendamento);
    }
}