using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;

namespace LaboratorioWebCore.Repositories
{
    public class ExameDaConsultaRepository : RepositoryBase<ExamesDaConsulta>
    {
        public readonly LaboratorioContexto Db;
        public ExameDaConsultaRepository(LaboratorioContexto Db) : base(Db)
        {
            this.Db = Db;
        }

        public override IEnumerable<ExamesDaConsulta> GetAll()
        {
            return Db.ExamesDaConsulta.ToList();
        }

        public override ExamesDaConsulta GetById(Guid id)
        {
            return Db.ExamesDaConsulta.FirstOrDefault(e=>e.ExamesDaConsultaId.Equals(id));
        }
    }
}