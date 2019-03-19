using SpMedGroup.WebApi.Domains;
using SpMedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Atualizar(int id, Usuarios usuario)
        {
            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                //falta tratar caso não ache valor do Id
                Usuarios usuarioBuscado = ctx.Usuarios.Find(id);
                             
                usuarioBuscado.Email = usuario.Email;
                ctx.Usuarios.Update(usuarioBuscado);
                ctx.SaveChanges();
            }
        }

        public void Cadastrar(Usuarios usuario)
        {
            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
            }
        }

        //Não sei se é o melhor jeito mas eu fiz sozinha \o/
        public List<Usuarios> Listar()
        {
            List<Usuarios> UsuariosLista = new List<Usuarios>();

            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                UsuariosLista = ctx.Usuarios.ToList();
            }

            return UsuariosLista;
        }
    }
}
