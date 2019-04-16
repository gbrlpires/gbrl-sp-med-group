using SpMedGroup.WebApi.Domains;
using SpMedGroup.WebApi.Interfaces;
using System.Collections.Generic;
using System.Linq;



namespace SpMedGroup.WebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Atualizar(int id, Usuarios usuario)
        {
            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
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

        public List<Usuarios> Listar()
        {
            List<Usuarios> UsuariosLista = new List<Usuarios>();

            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                UsuariosLista = ctx.Usuarios.ToList();
            }

            return UsuariosLista;
        }

        public void Deletar(int id)
        {
            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                Usuarios usuarioBuscado = ctx.Usuarios.Find(id);
                ctx.Usuarios.Remove(usuarioBuscado);
                ctx.SaveChanges();
            }
        }
        
        public Usuarios BuscarPorId(int id)
        {
            Usuarios usuario = new Usuarios();

            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                usuario = ctx.Usuarios.Find(id);
            }
     
            return usuario;

        }
    }
}
