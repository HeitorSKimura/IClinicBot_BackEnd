using IClinicBot.Domain.CadastroContext;
using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext
{
    public interface IRepositoryEspecialidade
    {
        public List<Especialidade> GetAllEspecialidade();
        public Especialidade PostEspecialidade(ViewModelEspecialidade especialidade);
    }
}
