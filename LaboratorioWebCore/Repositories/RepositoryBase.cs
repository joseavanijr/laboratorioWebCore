using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioWebCore.Repositories {
    public abstract class RepositoryBase<TEntity> : IDisposable where TEntity : class {

        public readonly LaboratorioContexto Db;

        public RepositoryBase(LaboratorioContexto Db)
        {
            this.Db = Db;
        }

        public void Add (TEntity obj) {

            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void Update (TEntity obj) {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();

            //var objBanco = GetById(obj);
            //Db.Entry(objBanco).CurrentValues.SetValues(obj);
            //Db.SaveChanges();

            //var entry = Db.Entry(obj);
            //DbSet.Attach(obj);
            //entry.State = EntityState.Modified;
        }

        public void Remove (TEntity obj) {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Remove (Guid id) {
            Remove(GetById(id));
        }

        public abstract TEntity GetById(Guid id);

        public abstract IEnumerable<TEntity> GetAll();
        

        public void Dispose () {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}

// class MyContext : DbContext
// {
//     public override int SaveChanges()
//     {
//         var entities = from e in ChangeTracker.Entries()
//                        where e.State == EntityState.Added
//                            || e.State == EntityState.Modified
//                        select e.Entity;
//         foreach (var entity in entities)
//         {
//             var validationContext = new ValidationContext(entity);
//             Validator.ValidateObject(entity, validationContext);
//         }

//         return base.SaveChanges();
//     }
// }