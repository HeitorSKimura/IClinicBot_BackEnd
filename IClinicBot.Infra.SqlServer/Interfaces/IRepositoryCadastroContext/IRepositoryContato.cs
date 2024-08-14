using IClinicBot.Domain.Entidades.CadastroContext;

namespace IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext
{
    public interface IRepositoryContato
    {
        List<Contato> GetAllContato();
        bool PostContato(Contato contato);
    }
}
