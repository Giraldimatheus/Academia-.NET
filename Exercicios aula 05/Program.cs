using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_aula_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num;

            for(num = 0; num <= 10; num++)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            /*int num;

            for(num = 20; num >= 5; num--)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            /*int inicio;
            int fim;
            int i;

            Console.WriteLine("Voce deve digitar dois numero e o programa apresentara o intervalo entre eles ");
            Console.WriteLine("Qual o primeiro numero? ");
            inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o numero final? ");
            fim = int.Parse(Console.ReadLine());

            if(inicio < fim)
            {
                for (i = inicio; i <= fim; i++) 
                Console.WriteLine(i);
            }
            else if (inicio > fim)
            {
                for (i = inicio; i >= fim; i--)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            /*int x;
            int num1;
            int num2 = 100;

            Console.WriteLine("Escreva o valor de X ");
            x = int.Parse(Console.ReadLine());

            for(num1 = 0; num1 < num2; num1+=x)
            {
                Console.WriteLine($"{num1}");
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            /*int num;
            int idade;
            int somaIdades = 0;

            Console.WriteLine("Quantas pessoas vão compartilhar suas idades?");
            num = int.Parse(Console.ReadLine());

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Qual a idade?");
                idade= int.Parse(Console.ReadLine());
                somaIdades += idade;
            }

            double media = somaIdades / (double)num;

            Console.WriteLine($"A media das idades é: {media}");

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            /*int num;
            int maiorNum = int.MinValue;

            Console.WriteLine("Quantos numeros serão lidos? ");
            num = int.Parse(Console.ReadLine());

            for( int i = 0; i < num; i++ )
            {
                Console.WriteLine($"Digite o {i} numero: ");
                int numLido = int.Parse(Console.ReadLine());
                if (numLido > maiorNum)
                {
                    maiorNum = numLido;
                }
            }
            Console.WriteLine($"O maior numero lido foi {maiorNum}");

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            /*int num;
            int multiplicador;

            Console.WriteLine("Qual tabuada você deseja?");
            num = int.Parse(Console.ReadLine());

            for(int i = 1; i <=10; i++)
            {
                int resultado = num * i;
                Console.WriteLine($"A tabuda é {num} X {i}: {resultado}");
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            /*int x;
            int y;
            int totalx = 1;

            Console.WriteLine("Qual o valor de x? ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor de y? ");
            y = int.Parse(Console.ReadLine());

            for (int i = 0; i < y; i++) 
            {
                totalx *= x;
            }
            Console.WriteLine($"O valor de {x} elevado a {y}: {totalx}");

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            /*int num;
            int fatorial;

            Console.WriteLine("Qual numero será o fatorial?");
            fatorial = int.Parse(Console.ReadLine());

            for(int i = fatorial-1; i >= 1; i--) 
            {
                num = fatorial * i;

                Console.WriteLine($"O fatorial de {fatorial} X {i}: {num}");
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            int numAlunos;
            int qtdProvas;
            double nota;

            Console.WriteLine("Quantos alunos tem na turma? ");
            numAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas provas foram aplicadas aos alunos?");
            qtdProvas= int.Parse(Console.ReadLine());

            for(int i =0; i < numAlunos;i++)
            {
                double somaNotas = 0;

                for (int j = 0; j < qtdProvas; j++)
                {
                    Console.WriteLine($"Digite a nota da prova {j + 1} do aluno {i + 1}:");
                    nota = int.Parse(Console.ReadLine());
                    somaNotas += nota;
                }

                double media = somaNotas/ qtdProvas;
                Console.WriteLine($"A média do aluno {i + 1} é {media:F2}");


            }
            Console.ReadLine();

            /*double num;
            double pares=0;
            double impar=0;

            Console.WriteLine("Vamos verificar se os numeros são pares ou ímpares.");

            for(int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Qual o {i+1} numero?");
                num = double.Parse( Console.ReadLine() );

                if (num % 2 == 0)
                { 
                    pares++; 
                
                }
                else
                {
                    impar++;
                }
                
            }

            Console.WriteLine($"A quantidade de numeros pares foi: {pares}");
            Console.WriteLine($"A quantidade de numeros impares foi: {impar}");

            Console.ReadLine(); */

        }
    }
}
