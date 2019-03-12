using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpMedGroup.WebApi.Domains
{
    public partial class StatusConsultas
    {
        public StatusConsultas()
        {
            Consultas = new HashSet<Consultas>();
        }

        public int StatusId { get; set; }

        [Required(ErrorMessage = "Informe o status da consulta")]
        public string StatusTipo { get; set; }

        public ICollection<Consultas> Consultas { get; set; }
    }
}
