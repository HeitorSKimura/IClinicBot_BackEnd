using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;

namespace IClinicBot.Domain.ViewModel.CadastroContextViewModel
{
    public class ViewModelMedico : ViewModelUser
    {
        public string CRM { get; set; }
    }
}