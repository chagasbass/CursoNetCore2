using Flunt.Validations;
using NetCore.Compartilhados.ObjetosDeValor;
using NetCore.Dominio.Enums;

namespace NetCore.Dominio.ObjetosDeValor
{
    public class Telefone:ObjetoDeValor
    {
        public Telefone(string numero, string dDD, ETipoTelefone tipoTelefone)
        {
            Numero = numero;
            DDD = dDD;
            TipoTelefone = tipoTelefone;

            Validar();
        }

        public string Numero { get; private set; }
        public string DDD { get; private set; }
        public ETipoTelefone TipoTelefone { get; private set; }

        public override void Validar()
        {
            AddNotifications(new Contract()
                .IsNotNullOrEmpty(Numero, "Numero", "Número inválido")
                .IsNotNullOrEmpty(DDD, "DDD", "DDD inválido"));
        }
    }
}