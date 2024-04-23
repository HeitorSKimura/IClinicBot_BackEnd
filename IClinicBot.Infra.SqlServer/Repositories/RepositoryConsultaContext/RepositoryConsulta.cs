using IClinicBot.Domain.ConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryConsultaContext
{
    public class RepositoryConsulta
    {
        private readonly SqlServerContext _context;

        public RepositoryConsulta(SqlServerContext context)
        {
            _context = context;
        }

        public List<Consulta> GetAllConsulta()
        {
            return _context.Consultas.ToList();
        }
    }
}
