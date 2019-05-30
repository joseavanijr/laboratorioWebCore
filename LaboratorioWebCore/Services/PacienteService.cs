using System;
using System.Collections.Generic;
using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;
// using LaboratorioWebCore.Repositories.ADO;

namespace LaboratorioWebCore.Services
{
    public class PacienteService: ServiceBase<Paciente>
    {
        public readonly PacienteRepository pacienteRepository;

        public PacienteService(PacienteRepository pacienteRepository):base(pacienteRepository)
        {
            this.pacienteRepository = pacienteRepository;
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