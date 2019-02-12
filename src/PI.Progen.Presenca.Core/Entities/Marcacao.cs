using System;

namespace PI.Progen.Presenca.Core.Entities
{
    public class Marcacao : Entity<Marcacao>
    {
        public Guid AlunoId { get; set; }
        public DateTime Data { get; set; }

        public static Marcacao Novo(Guid alunoId)
        {
            return new Marcacao
            {
                AlunoId = alunoId,
                Data = DateTime.Now
            };
        }
    }
}
