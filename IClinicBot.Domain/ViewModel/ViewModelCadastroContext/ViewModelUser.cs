using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Domain.ViewModel.ViewModelCadastroContext
{
    public class ViewModelUser
    {
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
