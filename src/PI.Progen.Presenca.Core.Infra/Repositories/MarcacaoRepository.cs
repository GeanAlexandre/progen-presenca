using LiteDB;
using PI.Progen.Presenca.Core.Entities;
using PI.Progen.Presenca.Core.Interfaces.Repositories;

namespace PI.Progen.Presenca.Core.Infra.Repositories
{
    public class MarcacaoRepository : Repository<Marcacao>, IMarcacaoRepository
    {
        public MarcacaoRepository(LiteDatabase liteDb) 
            : base(liteDb)
        {
        }
    }
}
