using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;

namespace LaboratorioWebCore.Services
{
    public class AtendimentoService : ServiceBase<Atendimento>
    {
        public AtendimentoService(RepositoryBase<Atendimento> repositoryBase) : base(repositoryBase)
        {
        }
    }
}