using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;

namespace Agendamento.API.Domain.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> ListAsync();   

        Task<int> Registrar(Usuario usuario);     
    }
}