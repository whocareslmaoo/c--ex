using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.TipoReferencia
{
    internal class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public PessoaJuridica(string nome, string sobrenome, string Cnpj) : base(nome, sobrenome)
        {
            this.Cnpj = Cnpj;
        }

        public override string Saudacao()
        {
            return base.Saudacao() + " - " + this.Cnpj;
        }


    }
}
