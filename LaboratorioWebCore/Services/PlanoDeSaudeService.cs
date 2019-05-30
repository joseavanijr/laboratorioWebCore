using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;
using System;
using System.Collections.Generic;

namespace LaboratorioWebCore.Services
{
    public class PlanoDeSaudeService: ServiceBase<PlanoDeSaude>
    {
        public readonly PlanoDeSaudeRepository planoRepository;

        public PlanoDeSaudeService(PlanoDeSaudeRepository planoRepository):base(planoRepository)
        {
            this.planoRepository = planoRepository;
        }
        public IEnumerable<PlanoDeSaude> GetByDescricao(string descricao)
        {
            return planoRepository.GetByDescricao(descricao);
        }
    }
}