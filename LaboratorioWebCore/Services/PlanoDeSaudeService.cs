using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;
using System;
using System.Collections.Generic;

namespace LaboratorioWebCore.Services
{
    public class PlanoDeSaudeService
    {
        public readonly PlanoDeSaudeRepository planoRepository;

        public PlanoDeSaudeService(PlanoDeSaudeRepository pacienteRepository)
        {
            this.planoRepository = pacienteRepository;
        }
        public void Save(PlanoDeSaude objEntity)
        {
            planoRepository.Add(objEntity);
        }
        public void Update(PlanoDeSaude objEntity)
        {
            planoRepository.Update(objEntity);
        }
        public void Delete(PlanoDeSaude objEntity)
        {
            planoRepository.Remove(objEntity);
        }
        public void Delete(Guid id)
        {
            planoRepository.Remove(id);
        }
        public PlanoDeSaude GetById(Guid id)
        {
            return planoRepository.GetById(id);
        }
        public IEnumerable<PlanoDeSaude> GetAll()
        {
            return planoRepository.GetAll();
        }
        public void Dispose()
        {
            planoRepository.Dispose();
        }
    }
}