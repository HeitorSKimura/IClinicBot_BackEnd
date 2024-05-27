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
    public class RepositoryPaciente : IRepositoryPaciente
    {
        private readonly SqlServerContext _context;

        public RepositoryPaciente(SqlServerContext context)
        {
            _context = context;
        }

        public List<Paciente> GetAllPaciente()
        {
            return _context.Pacientes.ToList();
        }

        public int PostPaciente(Paciente paciente)
        {
            _context.Pacientes.Add(paciente);
            var id = _context.SaveChanges();
            return id;
        }

        public Paciente FindPacienteByTelefone(string telefone)
        {
            var user = _context.Pacientes.FirstOrDefault(i => i.Telefone == telefone);
            return user;
        }
    }
}
