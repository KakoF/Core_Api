using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Models;
using Agendamento.API.Domain.Services;
using Microsoft.AspNetCore.Mvc;
namespace Agendamento.API.Controllers
{
    [Route("/api/[controller]")]
    public class SalaController
    {
        private readonly ISalaService _salaService;
         public SalaController(ISalaService salaService){
            _salaService = salaService;
        }

         [HttpGet]
          public async Task<IEnumerable<Sala>> GetAllAsync(){
            var salas = await _salaService.ListAsync();
            return salas;
        }   
    }
}