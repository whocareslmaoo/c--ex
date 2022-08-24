using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.TipoValor
{
    internal class TipoNumerico2
    {
        public static void Executa()
        {
            char letra = 'y';
            System.Console.WriteLine("Char: "+letra);
            char charMin = char.MinValue;
            char charMax = char.MaxValue;
            System.Console.WriteLine("Char min: " + charMin);
            System.Console.WriteLine("Char max: " + charMax);
            System.Console.WriteLine("Letra Y: " + (byte)letra);
        }
    }
}
