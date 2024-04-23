using IClinicBot.Domain.ConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryConsultaContext
{
    public class RepositoryMedicoExame
    {
        private readonly SqlServerContext _context;

        public RepositoryMedicoExame(SqlServerContext context)
        {
            _context = context;
        }

        public List<MedicoExame> GetAllMedicoExame()
        {
            return _context.MedicoExames.ToList();
        }

        public MedicoExame PostMedicoExame(int idMedico, int idExam)
        {
            var medico = _context.Medicos.First(i => i.idCadastro == idMedico);
            var exame = _context.Exames.First(i => i.idExame == idExam);

            var medicoExame = new MedicoExame
            {
                Medico = medico,
                Exame = exame
            };
            _context.Add(medicoExame);
            _context.SaveChanges();
            return medicoExame;
        }
    }
}
