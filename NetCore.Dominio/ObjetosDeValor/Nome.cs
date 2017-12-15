using Flunt.Validations;
using NetCore.Compartilhados.ObjetosDeValor;

namespace NetCore.Dominio.ObjetosDeValor
{
    public class Nome : ObjetoDeValor
    {
        public Nome(string primeiroNome, string sobrenome)
        {
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;

            Validar();
        }

        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }

        public override void Validar()
        {
            AddNotifications(new Contract()
                .IsNotNullOrEmpty(PrimeiroNome, "primeiroNome", "O nome é obrigatório")
                .IsNotNullOrEmpty(Sobrenome, "Sobrenome", "O sobrenome é obrigatório"));
        }
    }
}
