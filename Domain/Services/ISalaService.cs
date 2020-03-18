using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;

namespace Agendamento.API.Domain.Services
{
    public interface ISalaService
    {
          Task<IEnumerable<Sala>> ListAsync();
    }
}