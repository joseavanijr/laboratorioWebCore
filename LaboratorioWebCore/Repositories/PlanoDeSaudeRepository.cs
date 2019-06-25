using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioWebCore.Repositories
{
    public class PlanoDeSaudeRepository : RepositoryBase<PlanoDeSaude>, IDisposable
    {
        public readonly LaboratorioContexto Db;

        public PlanoDeSaudeRepository(LaboratorioContexto Db):base(Db)
        {
            this.Db = Db;
        }

        public override IEnumerable<PlanoDeSaude> GetAll()
        {
            return Db.PlanosDeSaude.ToList();
        }

        public IEnumerable<PlanoDeSaude> GetByDescricao(string descricao)
        {
            return Db.PlanosDeSaude.Where(p=> p.Descricao.Contains(descricao));
        }

        public override PlanoDeSaude GetById(Guid id)
        {
            return Db.PlanosDeSaude.FirstOrDefault(p=>p.PlanoDeSaudeId.Equals(id));
        }
    }
}