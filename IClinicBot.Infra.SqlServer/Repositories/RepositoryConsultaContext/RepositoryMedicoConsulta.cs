using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryConsultaContext
{
    public class RepositoryMedicoConsulta : IRepositoryMedicoConsulta
    {
        private readonly SqlServerContext _context;

        public RepositoryMedicoConsulta(SqlServerContext context)
        {
            _context = context;
        }

        public List<MedicoConsulta> GetAllMedicoConsulta()
        {
            return _context.MedicoConsultas.ToList();
        }

        public MedicoConsulta PostMedicoConsulta(int idMedico, int idCons)
        {
            var medico = _context.Medicos.First(i => i.idCadastro == idMedico);
            var consulta = _context.Consultas.First(i => i.idConsulta == idCons);

            var medicoConsulta = new MedicoConsulta
            {
                Medico = medico,
                Consulta = consulta
            };
            _context.Add(medicoConsulta);
            _context.SaveChanges();
            return medicoConsulta;
        }
    }
}
