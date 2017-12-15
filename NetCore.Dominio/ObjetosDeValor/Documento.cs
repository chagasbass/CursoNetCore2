using Flunt.Validations;
using NetCore.Compartilhados.ObjetosDeValor;

namespace NetCore.Dominio.ObjetosDeValor
{
    public  class Documento:ObjetoDeValor
    {
        public Documento(string numero)
        {
            Numero = numero;

            Validar();
        }

        public string Numero { get; private set; }

        public override void Validar()
        {
            AddNotifications(new Contract()
                .IsNullOrEmpty(Numero, "Documento", "Documento inválido"));
        }
    }
}