using IClinicBot.Domain.CadastroContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext
{
    public interface IRepositoryMedicoEspecialidade
    {
        public List<MedicoEspecialidade> GetAllMedicoEspecialidade();
        public MedicoEspecialidade PostMedicoEspecialidade(int idmedico, int idespecialidade);
    }
}
