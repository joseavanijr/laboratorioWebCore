using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioWebCore.Repositories
{
    public class PlanoDeSaudeRepository : IDisposable
    {
        public readonly LaboratorioContexto Db;

        public PlanoDeSaudeRepository(LaboratorioContexto Db)
        {
            this.Db = Db;
        }

        public void Add(PlanoDeSaude obj)
        {

            Db.Set<PlanoDeSaude>().Add(obj);
            Db.SaveChanges();
        }

        public void Update(PlanoDeSaude obj)
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

        public void Remove(PlanoDeSaude obj)
        {
            Db.Set<PlanoDeSaude>().Remove(obj);
            Db.SaveChanges();
        }

        public void Remove(Guid id)
        {
            Remove(GetById(id));
        }

        public PlanoDeSaude GetById(Guid id)
        {
            return Db.Set<PlanoDeSaude>().Find(id);
        }

        public IEnumerable<PlanoDeSaude> GetAll()
        {
            return Db.Set<PlanoDeSaude>().ToList();
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