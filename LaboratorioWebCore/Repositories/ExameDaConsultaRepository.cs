using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;

namespace LaboratorioWebCore.Repositories
{
    public class ExameDaConsultaRepository : RepositoryBase<ExamesDaConsulta>
    {
        public ExameDaConsultaRepository(LaboratorioContexto Db) : base(Db)
        {
        }
    }
}