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

        public Paciente PostPaciente(ViewModelPaciente paciente)
        {
            var pacienteRepository = new Paciente
            {
                NomeCompleto = paciente.NomeCompleto,
                CPF = paciente.CPF,
                Email = paciente.Email,
                Senha = paciente.Senha,
                Telefone = paciente.Telefone,
                Peso = paciente.Peso,
                Idade = paciente.Idade,
                Tamanho = paciente.Tamanho,
            };
            _context.Pacientes.Add(pacienteRepository);
            _context.SaveChanges();
            return pacienteRepository;
        }

        public Paciente FindPacienteByTelefone(string telefone)
        {
            var user = _context.Pacientes.FirstOrDefault(i => i.Telefone == telefone);
            return user;
        }
    }
}
