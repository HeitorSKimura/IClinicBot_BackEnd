using IClinicBot.Domain.Entidades.CadastroContext;
using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;

namespace IClinicBot.Domain.Interfaces.IServicesCadastroContext
{
    public interface IServiceContato
    {
        List<Contato> GetAllContato();
        Contato PostContato(ViewModelContato contato);
    }
}