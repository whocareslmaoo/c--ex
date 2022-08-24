using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.TipoReferencia
{
    internal interface iRepository
    {
        string Create(Pessoa p);
        List<Pessoa> Read();
        string Update(Pessoa p);

        string Delete(Pessoa p);
    }
}
