using Microsoft.AspNetCore.Mvc;
using SpMedGroup.WebApi.Domains;
using SpMedGroup.WebApi.Interfaces;
using SpMedGroup.WebApi.Repositories;

namespace SpMedGroup.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultasController : ControllerBase
    {
  
        private IConsultaRepository ConsultaRepository { get; set; }

        public ConsultasController()
        {
            ConsultaRepository = new ConsultaRepository();
        }


        [HttpPost]
        public IActionResult AgendarConsulta(Consultas consulta)
        {
            try
            {
                ConsultaRepository.AgendarConsulta(consulta);
                return Ok(new
                {
                    mensagem = "Consulta agendada com sucesso"
                });
            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }
        }


    }
}