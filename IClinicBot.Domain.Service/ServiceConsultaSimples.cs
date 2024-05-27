using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.Service
{
    public class ServiceConsultaSimples
    {
        readonly IRepositoryPaciente _paciente;
        readonly IRepositoryConsultaPresencial _consultaPresencial;
        readonly IRepositoryAgenda _agenda;

        public ServiceConsultaSimples(IRepositoryPaciente paciente,IRepositoryConsultaPresencial consultaPresencial ,IRepositoryAgenda agenda)
        {
            _paciente = paciente;
            _consultaPresencial = consultaPresencial;
            _agenda = agenda;
        }

        public bool CadastrarConsultaSimples(DateTime data, string telefone, string nome, string idade, string especialidade, int formaPag)
        {
            var user = _paciente.FindPacienteByTelefone(telefone);
            if (user == null)
            {
                var newUser = new ViewModelPaciente
                {
                    NomeCompleto = nome,
                    Telefone = telefone,
                    Idade = idade
                };
                _paciente.PostPaciente(newUser);
            }

            var novaConsulta = new ViewModelConsultaPresencial
            {
                idPaciente = user.idCadastro,
                Tipo = 0,
            };
            _consultaPresencial.PostConsultaPresencial(novaConsulta);

            return true;
        }
    }
}
