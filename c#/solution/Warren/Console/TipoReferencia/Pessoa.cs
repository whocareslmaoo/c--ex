﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.TipoReferencia
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

       
        public Pessoa(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        

        public virtual string Saudacao()
        {
            return "Ola, " + this.Nome + " " + this.Sobrenome;
        }
    }
}
