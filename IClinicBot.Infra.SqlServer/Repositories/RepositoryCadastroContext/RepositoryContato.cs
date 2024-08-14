using IClinicBot.Domain.Entidades.CadastroContext;
using IClinicBot.Domain.ViewModel.ViewModelCadastroContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryCadastroContext;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryCadastroContext
{
    public class RepositoryContato : IRepositoryContato
    {
        private readonly SqlServerContext _context;

        public RepositoryContato(SqlServerContext context)
        {
            _context = context;
        }

        public List<Contato> GetAllContato()
        {
            return _context.Contatos.ToList();
        }

        public bool PostContato(Contato contato)
        {
            try
            {
                _context.Contatos.Add(contato);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}