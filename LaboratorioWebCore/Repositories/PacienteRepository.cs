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
            return Db.Pacientes.Where(p=> p.PlanoDeSaudeId.Equals(planoId));
        }

        public IEnumerable<Paciente> GetByName(string nome)
        {
            return Db.Pacientes.Where(p=> p.Nome.Contains(nome));
        }

       
    }
}