using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_aula_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            for(int i = 0; true; i++)
            {
                if(i != 4 && i != 1 && i != 2 && i != 3)
                {
                    Console.WriteLine("Qual a opção desejada? 1 a 9");
                }
                else
                {
                    Console.WriteLine("Você digitou corretamente!");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
