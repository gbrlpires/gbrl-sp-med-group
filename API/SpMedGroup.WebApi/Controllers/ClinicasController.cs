using Microsoft.AspNetCore.Mvc;
using SpMedGroup.WebApi.Domains;
using SpMedGroup.WebApi.Interfaces;
using SpMedGroup.WebApi.Repositories;

namespace SpMedGroup.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicasController : ControllerBase
    {

        private IClinicaRepository ClinicaRepository { get; set; }

        public ClinicasController()
        {
            ClinicaRepository = new ClinicaRepository();
        }

        [HttpPost]
        public IActionResult CadastrarClinica(Clinicas clinica)
        {
            try
            {
               ClinicaRepository.CadastrarClinica(clinica);
                return Ok(new
                {
                    mensagem = "Cadastro realizado com sucesso"
                });


            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }
        }

    }
}