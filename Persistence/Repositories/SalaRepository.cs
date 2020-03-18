using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Agendamento.API.Domain.Models;
using Agendamento.API.Domain.Repositories;
using Agendamento.API.Persistence.Contexts;

namespace Agendamento.API.Persistence.Repositories
{
    public class SalaRepository : BaseRepository, ISalaRepository
    {
        public SalaRepository(AppDbContext context) : base(context)
        { }
        public async Task AddAsync(Sala sala)
        {
          await _context.Salas.AddAsync(sala);
        }

        public async Task<Sala> FindByIdAsync(int id)
        {
            return await _context.Salas.FindAsync(id);
        }

        public async Task<IEnumerable<Sala>> ListAsync()
        {
            //return await _context.Salas.ToListAsync();
            return await _context.Salas.Include(b => b.Agendamentos).ToListAsync();
        }

        public void Remove(Sala sala)
        {
            _context.Salas.Remove(sala);
        }

        public void Update(Sala sala)
        {
            _context.Salas.Update(sala);
        }
    }
}