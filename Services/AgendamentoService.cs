
using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;
using Agendamento.API.Domain.Repositories;
using Agendamento.API.Domain.Services;

namespace Agendamento.API.Services
{
    public class AgendamentoService: IAgendamentoService
    {
        private readonly IAgendamentoRepository _agendamentoRepository;

        public AgendamentoService(IAgendamentoRepository agendamentoRepository){
            _agendamentoRepository = agendamentoRepository;
        }
        public async Task<IEnumerable<Domain.Models.Agendamento>> ListAsync()
        {
            return await _agendamentoRepository.ListAsync();
        }
    }
}