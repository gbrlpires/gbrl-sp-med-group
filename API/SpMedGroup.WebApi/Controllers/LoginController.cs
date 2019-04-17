using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SpMedGroup.WebApi.Domains;
using SpMedGroup.WebApi.Interfaces;
using SpMedGroup.WebApi.Repositories;
using SpMedGroup.WebApi.ViewModels;

namespace SpMedGroup.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }

        public LoginController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult LoginUsuario(LoginViewModel login)
        {
            try
            {
                using (SpMedGroupContext ctx = new SpMedGroupContext())
                {
                    Usuarios usuarioBuscado = ctx.Usuarios.Find(login.Email, login.Senha);

                    if(usuarioBuscado == null)
                    {
                        return NotFound(new
                        {
                            mensagem = "Email ou senha inválido"
                        });
                    }

                    //__Autenticação Via Token__
                    //Payload
                    var claims = new[]
                    {
                        new Claim(JwtRegisteredClaimNames.Email, usuarioBuscado.Email),
                        new Claim(JwtRegisteredClaimNames.Jti, usuarioBuscado.UsuarioId.ToString()),
                        new Claim(ClaimTypes.Role, usuarioBuscado.IdUsuariosTipos.ToString())
                    };

                    //Chave de acesso do Token
                    var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("spmedgroup-auth-key"));

                    //Header
                    var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                    //Gera o Token
                    var token = new JwtSecurityToken(
                        issuer: "SpMedGroup.WebApi",
                        audience: "SpMedGroup.WebApi",
                        claims: claims,
                        expires: DateTime.Now.AddMinutes(30),
                        signingCredentials: creds
                        );

                    //Retorna Ok com o Token
                    return Ok(new
                    {
                        token = new JwtSecurityTokenHandler().WriteToken(token)
                    });
                }
            }
            catch (System.Exception ex)
            {

                return BadRequest();
            }
        }

    }
}