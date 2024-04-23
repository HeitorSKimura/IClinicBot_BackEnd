using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.ViewModel.CadastroContextViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryCadastroContext
{
    public class RepositoryMedico
    {
        private readonly SqlServerContext _context;

        public RepositoryMedico(SqlServerContext context)
        {
            _context = context;
        }

        public List<Medico> GetAllMedico()
        {
            return _context.Medicos.ToList();
        }

        public Medico PostMedico(ViewModelMedico medico)
        {
            var medicoRepository = new Medico
            {
                NomeCompleto = medico.NomeCompleto,
                CPF = medico.CPF,
                Email = medico.Email,
                Senha = medico.Senha,
                CRM = medico.CRM,
            };
            _context.Medicos.Add(medicoRepository);
            _context.SaveChanges();
            return medicoRepository;
        }
    }
}
