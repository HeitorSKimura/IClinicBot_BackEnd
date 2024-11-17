using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.CadastroContextViewModel;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryCadastroContext
{
    public class RepositoryMedico : IRepositoryMedico
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

        public Medico GetMedicoByEmail(string email)
        {
            return _context.Medicos.FirstOrDefault(a => a.Email == email);
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
                Role = "medico"
            };

            _context.Medicos.Add(medicoRepository);
            _context.SaveChanges();
            return medicoRepository;
        }
    }
}
