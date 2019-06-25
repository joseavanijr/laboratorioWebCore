using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;

namespace LaboratorioWebCore.Repositories
{
    public class ExameDoAtendimentoRepository : RepositoryBase<ExamesDoAtendimento>
    {
        public readonly LaboratorioContexto Db;

        public ExameDoAtendimentoRepository(LaboratorioContexto Db) : base(Db)
        {
            this.Db = Db;
        }

        public override IEnumerable<ExamesDoAtendimento> GetAll()
        {
            return Db.ExamesDoAtendimento.ToList();
        }

        public override ExamesDoAtendimento GetById(Guid id)
        {
            return Db.ExamesDoAtendimento.FirstOrDefault(e => e.ExameId.Equals(id));
        }
    }
}