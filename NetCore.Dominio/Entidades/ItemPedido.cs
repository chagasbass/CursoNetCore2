using Flunt.Validations;
using NetCore.Compartilhados.Entidades;

namespace NetCore.Dominio.Entidades
{
    public class ItemPedido:Entidade
    {
        public ItemPedido(Produto produto, decimal quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Preco = Produto.Preco;
        }

        public Produto Produto { get; private set; }
        public decimal Quantidade { get; private set; }
        public decimal Preco { get; private set; }

        public override void Validar()
        {
            AddNotifications(new Contract()
                .IsNull(Produto, "Produto", "Produto não informado")
                .IsLowerThan(1, Quantidade, "quantidade", "Quantidade não informada")
                .IsLowerOrEqualsThan(0, Preco, "preco", "Preço inválido para item"));
        }
    }
}