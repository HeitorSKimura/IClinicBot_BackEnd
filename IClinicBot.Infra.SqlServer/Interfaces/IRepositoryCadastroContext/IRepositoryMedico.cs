using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.CadastroContextViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext
{
    public interface IRepositoryMedico
    {
        public List<Medico> GetAllMedico();
        public Medico GetMedicoByEmail(string email);
        public Medico PostMedico(ViewModelMedico medico);
    }
}
