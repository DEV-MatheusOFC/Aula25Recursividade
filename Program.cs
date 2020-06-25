using System;

namespace Aula_25___Recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade rec = new Recursividade();
            rec.GerarSequenciaFibonacci(0,1,15);
            System.Console.WriteLine(rec.GerarFatorial(5));
        }
    }
}
