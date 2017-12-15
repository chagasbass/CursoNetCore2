using Flunt.Validations;
using NetCore.Compartilhados.ObjetosDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Dominio.ObjetosDeValor
{
    public class Endereco:ObjetoDeValor
    {
        public Endereco(string rua, string numero, string cidade, string bairro, string estado, string cep)
        {
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            Bairro = bairro;
            Estado = estado;
            Cep = cep;

            Validar();
        }

        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Cidade { get; private set; }
        public string Bairro { get; private set; }
        public string Estado { get; private set; }
        public string Cep { get; private set; }

        public override void Validar()
        {
            AddNotifications(new Contract()
                .IsNullOrEmpty(Numero, "Numero", "Numero inválido")
                .IsNullOrEmpty(Rua, "Rua", "Rua inválido")
                .IsNullOrEmpty(Cidade, "Cidade", "Cidade inválido")
                .IsNullOrEmpty(Bairro, "Bairro", "Bairro inválido")
                .IsNullOrEmpty(Estado, "Estado", "Estado inválido")
                .IsNullOrEmpty(Cep, "cep", "Cep inválido"));
        }
    }
}