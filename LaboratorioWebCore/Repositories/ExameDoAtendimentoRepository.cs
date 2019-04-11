using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;

namespace LaboratorioWebCore.Repositories
{
    public class ExameDoAtendimentoRepository : RepositoryBase<ExamesDoAtendimento>
    {
        public ExameDoAtendimentoRepository(LaboratorioContexto Db) : base(Db)
        {
        }
    }
}