using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;

namespace LaboratorioWebCore.Services
{
    public class ExameDoAtendimentoService : ServiceBase<ExamesDoAtendimento>
    {
        public ExameDoAtendimentoService(RepositoryBase<ExamesDoAtendimento> repositoryBase) : base(repositoryBase)
        {
        }
    }
}