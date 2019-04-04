using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioWebCore.Repositories {
    public class RepositoryBase<TEntity> : IDisposable where TEntity : class {
        public readonly AtendimentoHospitalarContexto Db = new AtendimentoHospitalarContexto ();

        public void Add (TEntity obj) {

            Db.Set<TEntity> ().Add (obj);
            Db.SaveChanges ();
        }

        public void Update (TEntity obj) {
            Db.Entry (obj).State = EntityState.Modified;
            Db.SaveChanges ();

            //var objBanco = GetById(obj);
            //Db.Entry(objBanco).CurrentValues.SetValues(obj);
            //Db.SaveChanges();

            //var entry = Db.Entry(obj);
            //DbSet.Attach(obj);
            //entry.State = EntityState.Modified;
        }

        public void Remove (TEntity obj) {
            Db.Set<TEntity> ().Remove (obj);
            Db.SaveChanges ();
        }

        public void Remove (Guid id) {
            Remove (GetById (id));
        }

        public TEntity GetById (Guid id) {
            return Db.Set<TEntity> ().Find (id);
        }

        public IEnumerable<TEntity> GetAll () {
            return Db.Set<TEntity> ().ToList ();
        }

        public IEnumerable<TEntity> GetAllReadOnly () {
            return Db.Set<TEntity> ().AsNoTracking ();
        }

        public void Dispose () {
            Db.Dispose ();
            GC.SuppressFinalize (this);
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