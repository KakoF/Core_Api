using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;

namespace Agendamento.API.Domain.Repositories
{
    public interface ISalaRepository 
    {
         Task<IEnumerable<Sala>> ListAsync();
         Task AddAsync(Sala sala);
         Task<Sala> FindByIdAsync(int id);
         void Update(Sala sala);
         void Remove(Sala sala);
    }
}