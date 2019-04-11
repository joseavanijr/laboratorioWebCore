using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;

namespace LaboratorioWebCore.Services
{
    public class ExameService : ServiceBase<Exame>
    {
        public ExameService(RepositoryBase<Exame> repositoryBase) : base(repositoryBase)
        {
        }
    }
}