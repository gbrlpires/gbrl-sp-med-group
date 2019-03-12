using System;
using System.Collections.Generic;

namespace SpMedGroup.WebApi.Domains
{
    public partial class Especialidades
    {
        public Especialidades()
        {
            Medicos = new HashSet<Medicos>();
        }

        public int EspecialidadeId { get; set; }
        public string EspecialidadeNome { get; set; }

        public ICollection<Medicos> Medicos { get; set; }
    }
}
