namespace PI.Progen.Presenca.Core.Entities
{
    public class Aluno : Entity<Aluno>
    {
        public string Nome { get; private set; }
        public string QrCode { get; private set; }

        public static Aluno Novo(string nome)
        {
            return new Aluno
            {
                Nome = nome,
                QrCode = "qrcode-tbd"
            };
        }
    }
}
