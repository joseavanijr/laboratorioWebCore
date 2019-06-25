using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;

namespace LaboratorioWebCore.Repositories
{
    public class AgendamentoRepository : RepositoryBase<Agendamento>
    {
        public readonly LaboratorioContexto Db;
        public AgendamentoRepository(LaboratorioContexto Db) : base(Db)
        {
            this.Db = Db;
        }

        public override IEnumerable<Agendamento> GetAll()
        {
            return Db.Agendamentos.ToList();
        }

        public override Agendamento GetById(Guid id)
        {
            return Db.Agendamentos.FirstOrDefault(a => a.AgendamentoId.Equals(id));
        }
    }
}