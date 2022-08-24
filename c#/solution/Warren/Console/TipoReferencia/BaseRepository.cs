using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.TipoReferencia
{
    internal class BaseRepository : iRepository
    {
        List<Pessoa> pessoas;
      

        public string Create(Pessoa p)
        {
            this.pessoas.Add(p);
            return "Pessoa: " + p.Nome + " Salva com sucesso";
        }

        public string Delete(int id)
        {
            return "Pessoa de id: " + id + " deletada com sucesso";
        }

        public List<Pessoa> Read()
        {
            return pessoas;
        }

        public string Update(Pessoa p)
        {
            return "Pesso: " + p.Nome + " alterada com sucesso";
        }
    }
}
