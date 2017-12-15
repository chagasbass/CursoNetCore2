using Flunt.Validations;
using NetCore.Compartilhados.Entidades;

namespace NetCore.Dominio.Entidades
{
    public class Produto:Entidade
    {
        public Produto(string titulo, string descricao, string imagem, decimal preco, string quantidadeEmEstoque)
        {
            Titulo = titulo;
            Descricao = descricao;
            Imagem = imagem;
            Preco = preco;
            QuantidadeEmEstoque = quantidadeEmEstoque;

            Validar();
        }

        public string Titulo { get; private set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Preco { get; private set; }
        public string QuantidadeEmEstoque { get; set; }

        public override void Validar()
        {
            AddNotifications(new Contract()
                .IsNotNullOrEmpty(Titulo, "Titulo", "O Titulo é obrigatório")
                .IsNotNullOrEmpty(Descricao, "Descricao", "A Descrição é obrigatória")
                .IsNotNullOrEmpty(Imagem, "Imagem", "A Imagem é obrigatória")
                .IsLowerOrEqualsThan(0,Preco, "Preco", "O Preco é obrigatório")
                .IsNotNullOrEmpty(QuantidadeEmEstoque, "QuantidadeEmEstoque", "A Quantidade Em Estoque é obrigatória"));
        }
    }
}