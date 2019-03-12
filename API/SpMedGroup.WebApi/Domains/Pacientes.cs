using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpMedGroup.WebApi.Domains
{
    public partial class Pacientes
    {
        public Pacientes()
        {
            Consultas = new HashSet<Consultas>();
        }

        public int PacienteId { get; set; }

        [Required(ErrorMessage = "Informe o Nome do paciente")]
        public string PacienteNome { get; set; }

        public int? IdPacienteUsuario { get; set; }

        [Required(ErrorMessage = "Informe o RG do paciente")]
        public string Rg { get; set; }

        [Required(ErrorMessage = "Informe o CPF do paciente")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento do paciente")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Informe o endereço do paciente")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe o CEP do paciente")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe o telefone do paciente")]
        public string Telefone { get; set; }

        public int? IdPacienteProntuario { get; set; }

        public Prontuarios IdPacienteProntuarioNavigation { get; set; }
        public Usuarios IdPacienteUsuarioNavigation { get; set; }
        public ICollection<Consultas> Consultas { get; set; }
    }
}
