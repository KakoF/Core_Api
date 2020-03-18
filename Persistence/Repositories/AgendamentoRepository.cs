using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Agendamento.API.Domain.Models;
using Agendamento.API.Domain.Repositories;
using Agendamento.API.Persistence.Contexts;

namespace Agendamento.API.Persistence.Repositories
{
    public class AgendamentoRepository : BaseRepository, IAgendamentoRepository
    {
        public AgendamentoRepository(AppDbContext context) : base(context)
        { }
        public async Task AddAsync(Domain.Models.Agendamento agendamento)
        {
          await _context.Agendamentos.AddAsync(agendamento);
        }

        public async Task<Domain.Models.Agendamento> FindByIdAsync(int id)
        {
            return await _context.Agendamentos.FindAsync(id);
        }

        public async Task<IEnumerable<Domain.Models.Agendamento>> ListAsync()
        {
            return await _context.Agendamentos.ToListAsync();
        }

        public void Remove(Domain.Models.Agendamento agendamento)
        {
            _context.Agendamentos.Remove(agendamento);
        }

        public void Update(Domain.Models.Agendamento agendamento)
        {
            _context.Agendamentos.Update(agendamento);
        }
    }
}