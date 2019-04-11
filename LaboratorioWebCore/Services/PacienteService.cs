using System;
using System.Collections.Generic;
using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;
// using LaboratorioWebCore.Repositories.ADO;

namespace LaboratorioWebCore.Services
{
    public class PacienteService: ServiceBase<Paciente>
    {
        // private readonly PacienteAdoRepository pacienteAdo = new PacienteAdoRepository();
        private readonly PacienteRepository pacienteRepository;

        public PacienteService(RepositoryBase<Paciente> repositoryBase) : base(repositoryBase)
        {
        }

        public IEnumerable<Paciente> GetByPlano(Guid planoId)
        {    
            return pacienteRepository.GetByPlano(planoId);
            //return pacienteAdo.BuscarPorPlano(planoId);
        }
        public IEnumerable<Paciente> GetByName(string nome)
        {
            //return pacienteAdo.BuscarPorNome(nome);
            return pacienteRepository.GetByName(nome);
        }
        
    }
}