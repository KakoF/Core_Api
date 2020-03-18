using System.Threading.Tasks;
using Agendamento.API.Domain.Models;
using Agendamento.API.Domain.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace Agendamento.API.Controllers
{
    [Route("/api/[controller]")]
    public class SessionController: ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public SessionController(IUsuarioService usuarioService){
            _usuarioService = usuarioService;
        }
        [AllowAnonymous]
        [HttpPost("registrar")]
        public async Task<IActionResult> AuthenticateAsync([FromBody]Usuario model)
        {
            //return Ok(2);
            var id = await _usuarioService.Registrar(model);
            return Ok(id);
            //return Ok(usuario);
            /*if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);*/
        }

        /*[AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody]AuthenticateModel model)
        {
            var user = await _userService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }*/

    }
}