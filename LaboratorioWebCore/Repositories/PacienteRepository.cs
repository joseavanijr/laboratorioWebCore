using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioWebCore.Repositories
{
    public class PacienteRepository : RepositoryBase<Paciente>, IDisposable
    {
        public readonly LaboratorioContexto Db;

        public PacienteRepository(LaboratorioContexto Db): base(Db)
        {
            this.Db = Db;
        }

        public IEnumerable<Paciente> GetByPlano(Guid planoId)
        {
            return Db.Pacientes.Where(p=> p.PlanoDeSaudeId.Equals(planoId)).Include(p => p.Cidade).Include(p => p.PlanoDeSaude);
        }

        public IEnumerable<Paciente> GetByName(string nome)
        {
            return Db.Pacientes.Where(p=> p.Nome.Contains(nome)).Include(p=>p.Cidade).Include(p=>p.PlanoDeSaude);
        }

        public override Paciente GetById(Guid id)
        {
            return Db.Pacientes.Include(p=>p.PlanoDeSaude).FirstOrDefault(p => p.PacienteId.Equals(id));
        }

        public override IEnumerable<Paciente> GetAll()
        {
            return Db.Pacientes.Include(p => p.PlanoDeSaude).ToList();
        }
    }
}