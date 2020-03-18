using System.Collections.Generic;
using System.Threading.Tasks;
using Agendamento.API.Domain.Services;
using Microsoft.AspNetCore.Mvc;
namespace Agendamento.API.Controllers
{
    [Route("/api/[controller]")]
    public class AgendamentoController
    {
         private readonly IAgendamentoService _agendamentoService;
         public AgendamentoController(IAgendamentoService agendamentoService){
            _agendamentoService = agendamentoService;
        }

         [HttpGet]
          public async Task<IEnumerable<Domain.Models.Agendamento>> GetAllAsync(){
            var agendamentos = await _agendamentoService.ListAsync();
            return agendamentos;
        }   
    }
}