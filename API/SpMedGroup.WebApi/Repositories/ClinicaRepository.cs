using SpMedGroup.WebApi.Domains;
using SpMedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Repositories
{
    public class ClinicaRepository : IClinicaRepository

    {
        public void CadastrarClinica(Clinicas clinica)
        {
            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                ctx.Clinicas.Add(clinica);
                ctx.SaveChanges();
            }
        }
    }
}
