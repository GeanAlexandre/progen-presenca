using LiteDB;
using PI.Progen.Presenca.Core.Entities;
using PI.Progen.Presenca.Core.Interfaces.Repositories;

namespace PI.Progen.Presenca.Core.Infra.Repositories
{

    public class AlunoRepository : Repository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(LiteDatabase liteDb)
            : base(liteDb)
        { }
    }
}
