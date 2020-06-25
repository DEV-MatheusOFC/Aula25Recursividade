using System;

namespace Aula_25___Recursividade
{
    public class Recursividade
    {

        public void GerarSequenciaFibonacci(int num1, int num2, int vezes){

            if(vezes > 0){
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(num1);
                GerarSequenciaFibonacci(num2, num1 + num2, vezes - 1);
            }
            Console.ResetColor();
        }

        public int GerarFatorial(int num){
            if(num ==1){
                Console.ForegroundColor = ConsoleColor.Green;
                return 1;
            }else{
                return num *GerarFatorial(num - 1);
            }
        }

    }
}