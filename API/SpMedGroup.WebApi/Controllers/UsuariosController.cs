
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
                return Ok(UsuarioRepository.Listar());
            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }

        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, Usuarios usuario)
        {
            try
            {

                UsuarioRepository.Atualizar(id, usuario);
                return Ok(new
                {
                    mensagem = "Dados atualizados com sucesso"
                });
            }

            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                UsuarioRepository.Deletar(id);
                return Ok(new
                {
                    mensagem = "Usuário Removido com sucesso"
                });
            }

            catch (System.Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {

            try
            {
                return Ok(UsuarioRepository.BuscarPorId(id));

            }
            catch (System.Exception)
            {

                return NotFound();
            }
        }

    }
}