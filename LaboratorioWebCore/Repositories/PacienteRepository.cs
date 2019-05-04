using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioWebCore.Repositories
{
    public class PacienteRepository : IDisposable
    {
        public readonly LaboratorioContexto Db;

        public PacienteRepository(LaboratorioContexto Db)
        {
            this.Db = Db;
        }

        public void Add(Paciente obj)
        {

            Db.Set<Paciente>().Add(obj);
            Db.SaveChanges();
        }

        public void Update(Paciente obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();

            //var objBanco = GetById(obj);
            //Db.Entry(objBanco).CurrentValues.SetValues(obj);
            //Db.SaveChanges();

            //var entry = Db.Entry(obj);
            //DbSet.Attach(obj);
            //entry.State = EntityState.Modified;
        }

        public void Remove(Paciente obj)
        {
            Db.Set<Paciente>().Remove(obj);
            Db.SaveChanges();
        }

        public void Remove(Guid id)
        {
            Remove(GetById(id));
        }

        public Paciente GetById(Guid id)
        {
            return Db.Set<Paciente>().Find(id);
        }

        public IEnumerable<Paciente> GetAll()
        {
            return Db.Set<Paciente>().ToList();
        }

        public IEnumerable<Paciente> GetByPlano(Guid planoId)
        {
            return Db.Pacientes.Where(p=> p.PlanoDeSaudeId.Equals(planoId));
        }

        public IEnumerable<Paciente> GetByName(string nome)
        {
            return Db.Pacientes.Where(p=> p.Nome.Contains(nome));
        }

        public IEnumerable<Paciente> GetAllReadOnly()
        {
            return Db.Set<Paciente>().AsNoTracking();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}