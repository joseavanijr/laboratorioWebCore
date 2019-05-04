using System;
using System.Collections.Generic;
using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;
// using LaboratorioWebCore.Repositories.ADO;

namespace LaboratorioWebCore.Services
{
    public class PacienteService: IDisposable
    {
        public readonly PacienteRepository pacienteRepository;

        public PacienteService(PacienteRepository pacienteRepository)
        {
            this.pacienteRepository = pacienteRepository;
        }
        public void Save(Paciente objEntity)
        {
            pacienteRepository.Add(objEntity);
        }
        public void Update(Paciente objEntity)
        {
            pacienteRepository.Update(objEntity);
        }
        public void Delete(Paciente objEntity)
        {
            pacienteRepository.Remove(objEntity);
        }
        public void Delete(Guid id)
        {
            pacienteRepository.Remove(id);
        }
        public Paciente GetById(Guid id)
        {
            return pacienteRepository.GetById(id);
        }
        public IEnumerable<Paciente> GetAll()
        {
            return pacienteRepository.GetAll();
        }
        public void Dispose()
        {
            pacienteRepository.Dispose();
        }

        public IEnumerable<Paciente> GetByPlano(Guid planoId)
        {
            return pacienteRepository.GetByPlano(planoId);
        }

        public IEnumerable<Paciente> GetByName(string nome)
        {
            return pacienteRepository.GetByName(nome);
        }
    }
}