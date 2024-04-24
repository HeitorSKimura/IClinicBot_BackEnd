using IClinicBot.Domain.ConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext
{
    public interface IRepositoryMedicoConsulta
    {
        public List<MedicoConsulta> GetAllMedicoConsulta();
        public MedicoConsulta PostMedicoConsulta(int idMedico, int idCons);
    }
}
