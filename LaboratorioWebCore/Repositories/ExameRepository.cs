using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;

namespace LaboratorioWebCore.Repositories
{
    public class ExameRepository : RepositoryBase<Exame>
    {
        public ExameRepository(LaboratorioContexto Db) : base(Db)
        {
        }
    }
}