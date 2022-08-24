using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    internal class BemVindo
    {
        public static void Mensagem()
        {
            System.Console.WriteLine("hey mika: ");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("see you later, " + name);
            System.Console.ReadLine();

        }
    }
}
