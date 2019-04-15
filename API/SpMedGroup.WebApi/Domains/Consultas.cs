using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpMedGroup.WebApi.Domains
{
    public partial class Consultas
    {
        public int ConsultaId { get; set; }

        [Required(ErrorMessage = "Informe o médico que atenderá a consulta")]
        public int? IdConsultaMedico { get; set; }

        [Required(ErrorMessage = "Informe o paciente que será atendido")]
        public int? IdConsultaPaciente { get; set; }

        [Required(ErrorMessage = "Informe uma data para a consulta")]
        [DataType(DataType.Date)]
        public DateTime DataConsulta { get; set; }

        [Required(ErrorMessage = "Informe um horário para a consulta")]
        //Conferir Datatype.Time - serve para mostrar apenas a hora?
        [DataType(DataType.Time)]
        public TimeSpan HoraConsulta { get; set; }

        public int? IdConsultaStatus { get; set; }
        public string ObservacoesConsulta { get; set; }

        public Medicos IdConsultaMedicoNavigation { get; set; }
        public Pacientes IdConsultaPacienteNavigation { get; set; }
        public StatusConsultas IdConsultaStatusNavigation { get; set; }
    }
}
