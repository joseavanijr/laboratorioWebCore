﻿using System;
using System.Collections.Generic;
using System.Linq;
using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioWebCore.Repositories
{
    public class PlanoDeSaudeRepository : RepositoryBase<PlanoDeSaude>
    {
        //public readonly AtendimentoHospitalarContexto Db = new AtendimentoHospitalarContexto();

        public PlanoDeSaudeRepository(LaboratorioContexto Db) : base(Db)
        {
        }

        //public void Add(PlanoDeSaude obj)
        //{
        //    Db.Set<PlanoDeSaude>().Add(obj);
        //    Db.SaveChanges();
        //}

        //public void Update(PlanoDeSaude obj)
        //{
        //    Db.Entry(obj).State = EntityState.Modified;
        //    Db.SaveChanges();
        //}

        //public void Remove(PlanoDeSaude obj)
        //{
        //    Db.Set<PlanoDeSaude>().Remove(obj);
        //    Db.SaveChanges();
        //}

        //public PlanoDeSaude GetById(Guid id)
        //{
        //    return Db.Set<PlanoDeSaude>().Find(id);
        //}

        //public IEnumerable<PlanoDeSaude> GetAll()
        //{
        //    return Db.Set<PlanoDeSaude>().ToList();
        //}

    }
}