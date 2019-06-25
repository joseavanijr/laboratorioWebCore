using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;

namespace LaboratorioWebCore.Repositories
{
    public class AtendimentoRepository : RepositoryBase<Atendimento>
    {
        public readonly LaboratorioContexto Db;
        public AtendimentoRepository(LaboratorioContexto Db) : base(Db)
        {
            this.Db = Db;
        }

        public override IEnumerable<Atendimento> GetAll()
        {
            return Db.Atendimentos.ToList();
        }

        public override Atendimento GetById(Guid id)
        {
            return Db.Atendimentos.FirstOrDefault(a => a.AtendimentoId.Equals(id));
        }
    }
}