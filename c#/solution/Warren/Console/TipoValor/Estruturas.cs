using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.TipoValor
{
    internal class Estruturas
    {
        public static void Executa()
        {
            PessoaClasse p1 = new PessoaClasse();
            p1.Nome = "mika";
            PessoaStruct p2 = new PessoaStruct();
            p2.Nome = "yuuki";
            System.Console.WriteLine(p1.Nome);
            System.Console.WriteLine(p2.Nome);

            PessoaClasse p3 = new PessoaClasse();
            p3 = p1;
            PessoaStruct p4 = new PessoaStruct();
            p4 = p2;

            System.Console.WriteLine(p3.Nome);
            System.Console.WriteLine(p4.Nome);
            p1.Nome = "mika best summouner? eeeh?";
            p2.Nome = "yuuki worst black mage";
            System.Console.Write("----------------------------");
            System.Console.WriteLine(p1.Nome);
            System.Console.WriteLine(p2.Nome);
            System.Console.WriteLine(p3.Nome);
            System.Console.WriteLine(p4.Nome);

            System.Console.ReadKey();
            
        }
    }
    struct PessoaStruct
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public byte Idade { get; set; }
    }
    class PessoaClasse
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public byte Idade { get; set; }
    }
}
