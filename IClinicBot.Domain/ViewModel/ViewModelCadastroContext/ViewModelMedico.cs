using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;

namespace IClinicBot.Domain.ViewModel.CadastroContextViewModel
{
    public class ViewModelMedico : ViewModelUser
    {
        public string SenhaParaCadastrar { get; set; }
        public string CRM { get; set; }
    }
}