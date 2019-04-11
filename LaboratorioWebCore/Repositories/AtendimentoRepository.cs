using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;

namespace LaboratorioWebCore.Repositories
{
    public class AtendimentoRepository : RepositoryBase<Atendimento>
    {
        public AtendimentoRepository(LaboratorioContexto Db) : base(Db)
        {
        }
    }
}