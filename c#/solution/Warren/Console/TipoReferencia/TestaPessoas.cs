using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.TipoReferencia
{
    internal class TestaPessoas
    {
        public static void Executa()
        {
            PessoaJuridica pessoaFisica = new PessoaJuridica("yuuki", "play", "tonight");
            PessoaJuridica pessoaFisica2 = new PessoaJuridica("mika", "play", "tonight");
            PessoaJuridica pessoaFisica3 = new PessoaJuridica("yuuki and mika", "will play", "tonight");
    
            PessoaJuridicaRepository repository = new PessoaJuridicaRepository();
            string msg = repository.Create(pessoaFisica);
            System.Console.WriteLine(msg);

            repository.Create(pessoaFisica2);
            repository.Create(pessoaFisica3);

            List<PessoaJuridica> pessoas = repository.Read();
            foreach (PessoaJuridica p in pessoas)
            {
                System.Console.WriteLine(p.Saudacao());
            }




            System.Console.Read();
        }

        public static void ExecutaFisica()
        {
            PessoaFisica pessoaFisica = new PessoaFisica("yuuki", "play", "tonight");
            PessoaFisica pessoaFisica2 = new PessoaFisica("mika", "play", "tonight");
            PessoaFisica pessoaFisica3 = new PessoaFisica("yuuki and mika", "will play", "tonight");

            PessoaFisicaRepository repository = new PessoaFisicaRepository();
            string msg = repository.Create(pessoaFisica);
            System.Console.WriteLine(msg);

            repository.Create(pessoaFisica2);
            repository.Create(pessoaFisica3);

            List<PessoaFisica> pessoas = repository.Read();
            foreach (PessoaFisica p in pessoas)
            {
                System.Console.WriteLine(p.Saudacao());
            }




            System.Console.Read();
        }

    }

}
