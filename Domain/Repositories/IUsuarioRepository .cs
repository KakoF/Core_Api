using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;

namespace Agendamento.API.Domain.Repositories
{
    public interface IUsuarioRepository 
    {
         Task<IEnumerable<Usuario>> ListAsync();
         Task AddAsync(Usuario usuario);
         Task<Usuario> FindByIdAsync(int id);
         void Update(Usuario usuario);
         void Remove(Usuario usuario);
    }
}