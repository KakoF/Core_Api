
using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;
using Agendamento.API.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Agendamento.API.Controllers
{
    [Route("/api/[controller]")]
    public class UsuarioController
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService){
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public async Task<IEnumerable<Usuario>> GetAllAsync(){
            var usuarios = await _usuarioService.ListAsync();
            return usuarios;
        }   
    }

}