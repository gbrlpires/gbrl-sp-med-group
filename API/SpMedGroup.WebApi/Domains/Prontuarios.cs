using System;
using System.Collections.Generic;

namespace SpMedGroup.WebApi.Domains
{
    public partial class Prontuarios
    {
        public Prontuarios()
        {
            Pacientes = new HashSet<Pacientes>();
        }

        public int ProntuarioId { get; set; }
        public string Altura { get; set; }
        public string PesoAtual { get; set; }
        public string ObservacoesProntuario { get; set; }

        public ICollection<Pacientes> Pacientes { get; set; }
    }
}
