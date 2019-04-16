using SpMedGroup.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Interfaces
{
    interface IConsultaRepository
    {
        void AgendarConsulta(Consultas consulta);

        List<Consultas> ListarConsulta();

        void AtualizarStatusConsulta(int id, Consultas consulta);
    }
}
