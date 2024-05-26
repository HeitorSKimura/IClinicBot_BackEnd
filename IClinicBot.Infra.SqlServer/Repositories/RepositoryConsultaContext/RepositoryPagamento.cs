using IClinicBot.Domain.ConsultaContext;
using IClinicBot.Domain.ViewModel.ViewModelConsultaContext;
using IClinicBot.Infra.SqlServer.Interfaces.IRepositoryConsultaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IClinicBot.Infra.SqlServer.Repositories.RepositoryConsultaContext
{
    public class RepositoryPagamento : IRepositoryPagamento
    {
        private readonly SqlServerContext _context;

        public RepositoryPagamento(SqlServerContext context)
        {
            _context = context;
        }

        public List<Pagamento> GetAllPagamento()
        {
            return _context.Pagamentos.ToList();
        }

        public Pagamento PostPagamento(ViewModelPagamento viewModel)
        {
            var pagamento = new Pagamento
            {
                Valor = viewModel.Valor,
                Tipo = viewModel.Tipo,
                Status = viewModel.Status,
                idConsulta = viewModel.idConsulta,
            };

            _context.Pagamentos.Add(pagamento);
            _context.SaveChanges();
            return pagamento;
        }
    }
}
