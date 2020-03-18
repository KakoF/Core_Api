using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Agendamento.API.Domain.Models;
using Agendamento.API.Domain.Repositories;
using Agendamento.API.Persistence.Contexts;

namespace Agendamento.API.Persistence.Repositories
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        public UsuarioRepository(AppDbContext context) : base(context)
        { }
        public async Task AddAsync(Usuario usuario)
        {
          await _context.Usuarios.AddAsync(usuario);
        }

        public async Task<Usuario> FindByIdAsync(int id)
        {
            return await _context.Usuarios.FindAsync(id);
        }

        public async Task<IEnumerable<Usuario>> ListAsync()
        {
            return await _context.Usuarios.Include(b => b.Agendamentos).ToListAsync();
        }

        public void Remove(Usuario usuario)
        {
            _context.Usuarios.Remove(usuario);
        }

        public void Update(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
        }
    }
}