using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.ViewModel.ViewModelCadastroContext
{
    public class ViewModelPaciente : ViewModelUser
    {
        public string Peso { get; set; }
        public string Idade { get; set; }
        public string Tamanho { get; set; }
    }
}
