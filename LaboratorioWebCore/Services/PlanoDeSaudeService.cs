using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;

namespace LaboratorioWebCore.Services
{
    public class PlanoDeSaudeService : ServiceBase<PlanoDeSaude>
    {
        public PlanoDeSaudeService(RepositoryBase<PlanoDeSaude> repositoryBase) : base(repositoryBase)
        {
        }
    }
}