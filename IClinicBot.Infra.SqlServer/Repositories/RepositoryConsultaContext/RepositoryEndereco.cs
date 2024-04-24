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
    public class RepositoryEndereco : IRepositoryEndereco
    {
        private readonly SqlServerContext _context;

        public RepositoryEndereco(SqlServerContext context)
        {
            _context = context;
        }

        public List<Endereco> GetAllEndereco()
        {
            return _context.Enderecos.ToList();
        }

        public Endereco PostEndereco(ViewModelEndereco endereco)
        {
            var enderecoRepository = new Endereco
            {
                CEP = endereco.CEP,
                Numero = endereco.Numero
            };
            _context.Enderecos.Add(enderecoRepository);
            _context.SaveChanges();
            return enderecoRepository;
        }
    }
}
