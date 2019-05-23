using SpMedGroup.WebApi.Domains;
using SpMedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        public void CadastrarPaciente(Pacientes paciente)
        {
            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                ctx.Pacientes.Add(paciente);
                ctx.SaveChanges();
            }
        }

        public List<Pacientes> ListarPaciente()
        {
            List<Pacientes> PacientesLista = new List<Pacientes>();

            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                PacientesLista = ctx.Pacientes.ToList();
            }

            return PacientesLista;
        }
    }
}
