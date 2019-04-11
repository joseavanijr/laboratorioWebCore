using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;

namespace LaboratorioWebCore.Repositories
{
    public class AgendamentoRepository : RepositoryBase<Agendamento>
    {
        public AgendamentoRepository(LaboratorioContexto Db) : base(Db)
        {
        }
    }
}