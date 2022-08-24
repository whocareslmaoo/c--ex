using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.TipoReferencia
{
    internal class PessoaJuridicaRepository
    {  //crud - create, read, update, delete
        private List<PessoaJuridica> pessoas;

        public PessoaJuridicaRepository()
        {
            this.pessoas = new List<PessoaJuridica>();
        }

        public string Create(PessoaJuridica pessoa)
        {
            this.pessoas.Add(pessoa);
            return "Pessoa: " + pessoa.Nome + " Salva com sucesso";
        }
        public List<PessoaJuridica> Read()
        {
            
            return pessoas;
        }
        public string Update(PessoaJuridica pessoa)
        {
            return "Pessoas: " + pessoa.Nome + " alterada com sucesso";
        }

        public string Delete(int id)
        {
            return "Pessoa de id: " + id + " deletada com sucesso";
        }


    }
}
