using LaboratorioWebCore.Contexto;
using LaboratorioWebCore.Models;
using System.Collections.Generic;
using System.Linq;

namespace LaboratorioWebCore.Repositories
{
    public class CidadeRepository : RepositoryBase<Cidade>
    {
        public CidadeRepository(LaboratorioContexto Db) : base(Db)
        {
        }

        public IEnumerable<Cidade> GetByEstado(Estado estado)
        {
            return Db.Cidades.Where(c => c.Estado==estado);
        }
    }
}