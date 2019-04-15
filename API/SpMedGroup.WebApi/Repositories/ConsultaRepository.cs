using SpMedGroup.WebApi.Domains;
using SpMedGroup.WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SpMedGroup.WebApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        public void AgendarConsulta(Consultas consulta)
        {
            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {

                //tratar a conversao de data string para datetime no banco de dados
                ctx.Consultas.Add(consulta);
                ctx.SaveChanges();
            }
        }
    }
}
