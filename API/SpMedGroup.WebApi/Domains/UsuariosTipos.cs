using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpMedGroup.WebApi.Domains
{
    public partial class UsuariosTipos
    {
        public UsuariosTipos()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int UsuarioTipoId { get; set; }

        [Required(ErrorMessage = "Informe o Tipo de Usuário")]
        public string UsuarioTipo { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
