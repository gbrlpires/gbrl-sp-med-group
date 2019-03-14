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
        public void Cadastrar(Usuarios usuario)
        {
            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();
            }
        }

        //Não sei se é o melhor jeito mas eu fiz sozinha <3
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
