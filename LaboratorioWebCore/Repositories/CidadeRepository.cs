using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LaboratorioWebCore.Repositories
{
    public class CidadeRepository : RepositoryBase<Cidade>
    {
        public readonly LaboratorioContexto Db;

        public CidadeRepository(LaboratorioContexto Db) : base(Db)
        {
            this.Db = Db;
        }

        public override IEnumerable<Cidade> GetAll()
        {
            return Db.Cidades.ToList();
        }

        public IEnumerable<Cidade> GetByEstado(Estado estado)
        {
            return Db.Cidades.Where(c => c.Estado==estado);
        }

        public override Cidade GetById(Guid id)
        {
            return Db.Cidades.FirstOrDefault(c => c.CidadeId.Equals(id));
        }
    }
}