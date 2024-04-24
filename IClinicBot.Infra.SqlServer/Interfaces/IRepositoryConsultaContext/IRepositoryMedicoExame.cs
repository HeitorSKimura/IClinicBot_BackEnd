using IClinicBot.Domain.ConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext
{
    public interface IRepositoryMedicoExame
    {
        public List<MedicoExame> GetAllMedicoExame();
        public MedicoExame PostMedicoExame(int idMedico, int idExam);
    }
}
