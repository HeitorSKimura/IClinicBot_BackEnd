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
    public class RepositoryExame : IRepositoryExame
    {
        private readonly SqlServerContext _context;

        public RepositoryExame(SqlServerContext context)
        {
            _context = context;
        }

        public List<Exame> GetAllExame()
        {
            return _context.Exames.ToList();
        }

        public Exame PostExame(ViewModelExame exame)
        {
            var exameRepository = new Exame
            {
                DataExame = exame.DataExame,
                idPaciente = exame.idPaciente
            };
            _context.Exames.Add(exameRepository);
            _context.SaveChanges();
            return exameRepository;
        }
    }
}
