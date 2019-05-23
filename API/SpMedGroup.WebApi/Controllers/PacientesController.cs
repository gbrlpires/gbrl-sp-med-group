using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpMedGroup.WebApi.Domains;
using SpMedGroup.WebApi.Interfaces;
using SpMedGroup.WebApi.Repositories;

namespace SpMedGroup.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacientesController : ControllerBase
    {
        private IPacienteRepository PacienteRepository { get; set; }

        public PacientesController()
        {
            PacienteRepository = new PacienteRepository();
        }

        [HttpPost]
        public IActionResult Post(Pacientes paciente)
        {
            try
            {
                PacienteRepository.CadastrarPaciente(paciente);
                return Ok(new
                {
                    mensagem = "Usuário cadastrado com sucesso"
                });
            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(PacienteRepository.ListarPaciente());
            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }

        }




    }
}