using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.ViewModel.CadastroContextViewModel
{
    public class ViewModelMedico : ViewModelUser
    {
        public string CRM { get; set; }
    }
}
