using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.TipoValor
{
    internal class Numeradores2
    {
        public static void Executa()
        {
            System.Console.WriteLine(DiasDaSemana2.DOM);
            DiasDaSemana2 diasPresenciais = (DiasDaSemana2)8;
            System.Console.WriteLine(diasPresenciais);
            System.Console.ReadKey();
        }
    }
    [Flags]
    public enum DiasDaSemana2
    {
        DOM = 1,
        SEG = 2,
        TER = 4,
        QUA = 8,
        QUI = 16,
        SEX = 32,
        SAB = 64
    }
}
