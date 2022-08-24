using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Exercicios
{
    internal class _Cadastro
    {
        public void Atividade()
        {
            System.Console.WriteLine("Bem vindo!");
            System.Console.WriteLine("Digite seu nome");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Digite seu sobrenome: ");
            string sobrenome = System.Console.ReadLine();
            System.Console.WriteLine("Digite sua idade: ");
            byte idade = Byte.Parse (System.Console.ReadLine()); //converter string para byte
            System.Console.WriteLine("obrigado, " + name + " " + sobrenome + ",(" + idade + ")");
        } 

    }
}

