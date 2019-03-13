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
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        // conheço as ações
        private IUsuarioRepository UsuarioRepository { get; set; }

        public UsuariosController()
        {
            // tem acesso as implementações
            UsuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        // quem eu recebo para cadastrar
        public IActionResult Post(Usuarios usuario)
        {
            try
            {
                // chamo a interface, e envio o que eu quiser
                UsuarioRepository.Cadastrar(usuario);
                return Ok();
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
                //Essa request aqui ta bem errada tb, arrumar
                UsuarioRepository.Listar();
                return Ok();
            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }

        }
        
    }
}