using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpMedGroup.WebApi.Domains
{
    public partial class Clinicas
    {
        public int ClinicaId { get; set; }

        [Required(ErrorMessage = "Informe o nome da Clínica")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "Informe o endereço da Clínica")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Informe o CEP da Clínica")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe o telefone da Clínica")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Informe a Razão Social da Clínica")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Informe o CNPJ da Clínica")]
        public string Cnpj { get; set; }
    }
}
