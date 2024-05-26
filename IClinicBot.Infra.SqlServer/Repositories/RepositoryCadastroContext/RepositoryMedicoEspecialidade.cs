using IClinicBot.Domain.CadastroContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryCadastroContext
{
    public class RepositoryMedicoEspecialidade : IRepositoryMedicoEspecialidade
    {
        private readonly SqlServerContext _context;

        public RepositoryMedicoEspecialidade(SqlServerContext context)
        {
            _context = context;
        }

        public List<MedicoEspecialidade> GetAllMedicoEspecialidade()
        {
            return _context.MedicoEspecialidades.ToList();
        }

        public MedicoEspecialidade PostMedicoEspecialidade(int idmedico, int idespecialidade)
        {
            var medico = _context.Medicos.First(i => i.idCadastro == idmedico);
            var especialidade = _context.Especialidades.First(i => i.idEspecialidade == idespecialidade);

            var medicoE = new MedicoEspecialidade
            {
                Medico = medico,
                Especialidade = especialidade
            };

            _context.Add(medicoE);
            _context.SaveChanges();
            return medicoE;
        }
    }
}
