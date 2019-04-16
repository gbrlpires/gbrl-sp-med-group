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
                ctx.Consultas.Add(consulta);
                ctx.SaveChanges();
            }
        }

        public void AtualizarStatusConsulta(int id, Consultas consulta)
        {
            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                Consultas consultaBuscada = ctx.Consultas.Find(id); //consultabuscada está dando nulo aqui

                //Se o Id do Status for Nulo ou a consulta já tiver sido cancelada, o status não é atualizado.
                if (consulta.IdConsultaStatus != 2 && consulta.IdConsultaStatus != null)
                    {
                        ctx.Consultas.Update(consultaBuscada);
                        ctx.SaveChanges();
                    }
            }
        }

        public List<Consultas> ListarConsulta()
        {
            List<Consultas> ConsultasLista = new List<Consultas>();

            using (SpMedGroupContext ctx = new SpMedGroupContext())
            {
                ConsultasLista = ctx.Consultas.ToList();
            }
            return ConsultasLista;
        }


    }
}
