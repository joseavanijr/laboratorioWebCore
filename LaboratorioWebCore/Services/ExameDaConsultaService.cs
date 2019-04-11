using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;

namespace LaboratorioWebCore.Services
{
    public class ExameDaConsultaService : ServiceBase<ExamesDaConsulta>
    {
        public ExameDaConsultaService(RepositoryBase<ExamesDaConsulta> repositoryBase) : base(repositoryBase)
        {
        }
    }
}