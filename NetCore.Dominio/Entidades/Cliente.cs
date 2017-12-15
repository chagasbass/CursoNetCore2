using NetCore.Compartilhados.Entidades;
using NetCore.Dominio.ObjetosDeValor;

namespace NetCore.Dominio.Entidades
{
    public class Cliente : Entidade
    {
        public Cliente(Nome nome, Documento documento, Email email, Telefone telefone, Endereco endereco)
        {
            Nome = nome;
            Documento = documento;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
        }

        public Nome Nome { get; set; }
        public Documento Documento { get; set; }
        public Email Email { get; set; }
        public Telefone Telefone { get; private set; }
        public Endereco Endereco { get; private set; }

        public override void Validar()
        {
            AddNotifications(Nome);
            AddNotifications(Documento);
            AddNotifications(Email);
            AddNotifications(Telefone);
            AddNotifications(Endereco);
        }

    }
}