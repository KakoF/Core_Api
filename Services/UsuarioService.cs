
using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;
using Agendamento.API.Domain.Repositories;
using Agendamento.API.Domain.Services;
using Core_Api.Helpers;

namespace Agendamento.API.Services
{
    public class UsuarioService: IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly AppSettings _appSettings;
        public UsuarioService(IUsuarioRepository usuarioRepository){
            _usuarioRepository = usuarioRepository;
        }
        public async Task<IEnumerable<Usuario>> ListAsync()
        {
            return await _usuarioRepository.ListAsync();
        }

        public Task<int> Registrar(Usuario usuario)
        {
            //var user = _usuarioRepository.(x => x.Username == username && x.Password == password);
            return _usuarioRepository.AddAsync(usuario);
        }
    }
}