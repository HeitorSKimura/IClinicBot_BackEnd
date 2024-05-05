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

        public ConsultaPresencial PostConsultaPresencial(ViewModelConsultaPresencial consultaPresencial)
        {
            var consultaRepository = new ConsultaPresencial
            {
                DataConsulta = consultaPresencial.DataConsulta,
                idEndereco = consultaPresencial.idEndereco,
                idPaciente = consultaPresencial.idPaciente,
                Descricao = consultaPresencial.Descricao,
                Tipo = consultaPresencial.Tipo,
            };
            _context.ConsultasPresencial.Add(consultaRepository);
            _context.SaveChanges();
            return consultaRepository;
        }
    }
}
