using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;

namespace LaboratorioWebCore.Repositories
{
    public class ExameRepository : RepositoryBase<Exame>
    {
        public readonly LaboratorioContexto Db;

        public ExameRepository(LaboratorioContexto Db) : base(Db)
        {
            this.Db = Db;
        }

        public override IEnumerable<Exame> GetAll()
        {
            return Db.Exames.ToList();
        }

        public override Exame GetById(Guid id)
        {
            return Db.Exames.FirstOrDefault(p => p.ExameId.Equals(id));
        }
    }
}