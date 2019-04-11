using System;
using System.Collections.Generic;
using LaboratorioWebCore.Models;
using LaboratorioWebCore.Repositories;
// using LaboratorioWebCore.Repositories.ADO;

namespace LaboratorioWebCore.Services
{
    public class CidadeService : ServiceBase<Cidade>
    {
        // private readonly CidadeAdoRepository cidadeAdo = new CidadeAdoRepository();
        private readonly CidadeRepository cidadeRepository;

        public CidadeService(RepositoryBase<Cidade> repositoryBase, CidadeRepository cidadeRepository) : base(repositoryBase)
        {
            this.cidadeRepository = cidadeRepository;
        }

        // public Cidade FindByIdReadOnly(Guid id)
        // {
        //     return cidadeAdo.Buscar(id);
        // }
        // public IList<Cidade> FindAllReadOnly()
        // {
        //     return cidadeAdo.BuscarTodas();
        // }        
        // public IList<Cidade> FindByEstadoReadOnly(Estado estado)
        // {
        //     return cidadeAdo.BuscarPorEstado(estado);
        // }

        public IEnumerable<Cidade> GetByEstado(Estado estado)
        {
            return cidadeRepository.GetByEstado(estado);
        }
    }
}
