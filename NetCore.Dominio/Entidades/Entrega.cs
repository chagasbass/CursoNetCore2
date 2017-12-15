using NetCore.Compartilhados.Entidades;
using NetCore.Dominio.Enums;
using System;

namespace NetCore.Dominio.Entidades
{
    public class Entrega:Entidade
    {
        public Entrega(DateTime dataEstimada)
        {
            DataCriacao = DateTime.Now;
            DataEstimada = dataEstimada;
            Status = EStatusEntrega.AGUARDANDO;
        }

        public DateTime DataCriacao { get; private set; }
        public DateTime DataEstimada { get; private set; }
        public EStatusEntrega Status { get; private set; }

        public override void Validar()
        {
            
        }
    }
}