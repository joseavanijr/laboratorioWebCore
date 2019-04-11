using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;

namespace LaboratorioWebCore.Repositories
{
    public class PacienteRepository : RepositoryBase<Paciente>
    {
        public PacienteRepository(LaboratorioContexto Db) : base(Db)
        {
        }

        public IEnumerable<Paciente> GetByPlano(Guid planoId)
        {
            return Db.Pacientes.Where(p => p.PlanoDeSaudeId == planoId);
        }

        public IEnumerable<Paciente> GetByName(string nome)
        {
            return Db.Pacientes.Where(p => p.Nome.Contains(nome));
        }
    }
}