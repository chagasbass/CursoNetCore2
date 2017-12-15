using Flunt.Validations;
using NetCore.Compartilhados.ObjetosDeValor;

namespace NetCore.Dominio.ObjetosDeValor
{
    public class Email:ObjetoDeValor
    {
        public Email(string endereco)
        {
            Endereco = endereco;
            Validar();
        }

        public string Endereco { get; private set; }

        public override void  Validar()
        {
            AddNotifications(new Contract()
                .IsNotNullOrEmpty(Endereco, "Email", "Email obrigatório")
                .IsEmail(Endereco, "Email", "Email inválido"));
        }
    }
}