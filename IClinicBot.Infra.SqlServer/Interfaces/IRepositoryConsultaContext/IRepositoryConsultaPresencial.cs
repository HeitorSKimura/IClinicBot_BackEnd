using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext
{
    public interface IRepositoryConsultaPresencial
    {
        public List<ConsultaPresencial> GetAllConsultaPresencial();
        public ConsultaPresencial PostConsultaPresencial(ConsultaPresencial consultaPresencial);
    }
}
