using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryCadastroContext
{
    public class RepositoryEspecialidade : IRepositoryEspecialidade
    {
        private readonly SqlServerContext _context;

        public RepositoryEspecialidade(SqlServerContext context)
        {
            _context = context;
        }

        public List<Especialidade> GetAllEspecialidade()
        {
            return _context.Especialidades.ToList();
        }

        public Especialidade PostEspecialidade(ViewModelEspecialidade especialidade)
        {
            var repo = new Especialidade
            {
                Nome = especialidade.Nome,
            };

            _context.Especialidades.Add(repo);
            _context.SaveChanges();
            return repo;
        }
    }
}
