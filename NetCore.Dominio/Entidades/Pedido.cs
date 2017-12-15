using Flunt.Validations;
using NetCore.Compartilhados.Entidades;
using NetCore.Dominio.Enums;
using System;
using System.Collections.Generic;

namespace NetCore.Dominio.Entidades
{
    public class Pedido:Entidade
    {
        public Pedido(Cliente cliente)
        {
            DataCriacao = DateTime.Now;
            Status = EStatusPedido.CRIADO;
            ItemsDoPedido = new List<ItemPedido>();
            Entregas = new List<Entrega>();
            Cliente = cliente;
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8).ToUpper();
        }

        public string Numero { get; private set; }
        public DateTime  DataCriacao { get; private set; }
        public EStatusPedido Status { get; private set; }
        public IReadOnlyCollection<ItemPedido> ItemsDoPedido { get; private set; }
        public IReadOnlyCollection<Entrega> Entregas { get; private set; }
        public Cliente Cliente { get; private set; }

        public override void Validar()
        {
            AddNotifications(new Contract()
                .IsNull(ItemsDoPedido, "Items do pedido", "Nenhum item inserido no pedido")
                .IsNull(Entregas, "Entregas", "Entrega não efetuada")
                .IsNull(Cliente, "cliente", "Cliente não informado"));
        }

        public void RealizarPedido()
        {

        }

        public void InserirItem(ItemPedido item)
        {
            //valida item
            //add no pedido
        }
    }
}