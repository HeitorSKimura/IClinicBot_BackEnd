using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext
{
    public interface IRepositoryConsultaChatBot
    {
        public List<ConsultaChatBot> GetAllConsultaChatBot();
        public ConsultaChatBot PostConsultaChatBot(ViewModelConsultaChatBot consultaChatBot);
    }
}
