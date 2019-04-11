using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;

namespace LaboratorioWebCore.Services
{
    public class AgendamentoService : ServiceBase<Agendamento>
    {
        public AgendamentoService(RepositoryBase<Agendamento> repositoryBase) : base(repositoryBase)
        {
        }
    }
}