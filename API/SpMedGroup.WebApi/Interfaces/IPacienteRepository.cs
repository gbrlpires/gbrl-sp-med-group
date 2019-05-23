using SpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Interfaces
{
    interface IPacienteRepository
    {
        void CadastrarPaciente(Pacientes paciente);

        List<Pacientes> ListarPaciente();
    }
}
