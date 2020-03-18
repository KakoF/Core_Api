
using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;
using Agendamento.API.Domain.Repositories;
using Agendamento.API.Domain.Services;

namespace Agendamento.API.Services
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository){
            _usuarioRepository = usuarioRepository;
        }
        public async Task<IEnumerable<Usuario>> ListAsync()
        {
            return await _usuarioRepository.ListAsync();
        }
    }
}