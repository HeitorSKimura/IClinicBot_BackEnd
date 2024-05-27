using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryConsultaContext
{
    public class RepositoryConsultaPresencial : IRepositoryConsultaPresencial
    {
        private readonly SqlServerContext _context;

        public RepositoryConsultaPresencial(SqlServerContext context)
        {
            _context = context;
        }

        public List<ConsultaPresencial> GetAllConsultaPresencial()
        {
            return _context.ConsultasPresencial.ToList();
        }

        public ConsultaPresencial PostConsultaPresencial(ConsultaPresencial consultaPresencial)
        {

            _context.ConsultasPresencial.Add(consultaPresencial);
            _context.SaveChanges();
            return consultaPresencial;
        }
    }
}
