using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.TipoValor
{
    internal class Enumeradores
    {
        public static void Executa()
        {
            System.Console.WriteLine((byte)DiasDaSemana.SEX);
            System.Console.WriteLine(DiasDaSemana.DOM);

            DiasDaSemana seg = DiasDaSemana.SEG;
            System.Console.WriteLine(seg);
            System.Console.ReadKey();
        }
    }

    public enum DiasDaSemana
    {
        DOM,
        SEG,
        TER,
        QUA,
        QUI,
        SEX,
        SAB
    }
}
