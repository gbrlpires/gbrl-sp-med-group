using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpMedGroup.WebApi.Domains
{
    public partial class Usuarios
    {
        public Usuarios()
        {
            Medicos = new HashSet<Medicos>();
            Pacientes = new HashSet<Pacientes>();
        }

        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Informe o seu e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe uma senha")]
        public string Senha { get; set; }

        public int? IdUsuariosTipos { get; set; }
        public UsuariosTipos IdUsuariosTiposNavigation { get; set; }
        public ICollection<Medicos> Medicos { get; set; }
        public ICollection<Pacientes> Pacientes { get; set; }
    }
}
