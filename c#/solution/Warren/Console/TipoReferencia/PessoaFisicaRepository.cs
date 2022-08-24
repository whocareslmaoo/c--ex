using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.TipoReferencia
{
    internal class PessoaFisicaRepository
    {  //crud - create, read, update, delete
        private List<PessoaFisica> pessoas;

        public PessoaFisicaRepository()
        {
            this.pessoas = new List<PessoaFisica>();
        }

        public string Create(PessoaFisica pesssoa)
        {
            this.pessoas.Add(pesssoa);
            return "Pessoa: " + pesssoa.Nome + " Salva com sucesso";
        }
        public List<PessoaFisica> Read()
        {
            
            return pessoas;
        }
        public string Update(PessoaFisica pessoa)
        {
            return "Pessoas: " + pessoa.Nome + " alterada com sucesso";
        }

        public string Delete(int id)
        {
            return "Pessoa de id: " + id + " deletada com sucesso";
        }


    }
}
