using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpMedGroup.WebApi.Domains
{
    public partial class Medicos
    {
        public Medicos()
        {
            Consultas = new HashSet<Consultas>();
        }

        public int MedicoId { get; set; }

        [Required(ErrorMessage = "Informe o nome do médico")]
        public string MedicoNome { get; set; }

        public int? IdMedicoUsuario { get; set; }

        [Required(ErrorMessage = "Informe o número do CRM")]
        public string Crm { get; set; }

        public int? IdMedicoEspecialidade { get; set; }

        public Especialidades IdMedicoEspecialidadeNavigation { get; set; }
        public Usuarios IdMedicoUsuarioNavigation { get; set; }
        public ICollection<Consultas> Consultas { get; set; }
    }
}
