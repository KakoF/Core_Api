
using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;
using Agendamento.API.Domain.Repositories;
using Agendamento.API.Domain.Services;

namespace Agendamento.API.Services
{
    public class SalaService: ISalaService
    {
        private readonly ISalaRepository _salaRepository;

        public SalaService(ISalaRepository salaRepository){
            _salaRepository = salaRepository;
        }
        public async Task<IEnumerable<Sala>> ListAsync()
        {
            return await _salaRepository.ListAsync();
        }
    }
}