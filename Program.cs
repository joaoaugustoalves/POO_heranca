using System;
using POO_heranca.Classe;

namespace POO_heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia a subclasse PessoaFisica
            PessoaFisica pf = new PessoaFisica();


            // Atribuidos um cpf ao objeto
            pf.cpf = "000.000.000-00";

            pf.nome = "Paulo";

            //Chamamos nosso metodo de saudação dento de um ConsoleWriteLine
            Console.WriteLine(pf.DarBoasVindas(pf.nome));

            // Chamamos nosso metodo de validade da subclasse
            Console.WriteLine(pf.ValidarCPF(pf.cpf) );
        }
    }
}
