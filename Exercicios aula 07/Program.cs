using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_aula_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[] vetor = new int[3]; 
            
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe um valor para a posição "+i+":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("O vetor possui na posição " + i + " o valor " + vetor[i]);
                Console.WriteLine("vetor[" + i + "] = " + vetor[i]);
            }
            
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 1


            /*int par = 0;
            int impar = 0;

            int[] vetor = new int[10]; 
            
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Digite um valor para a posição {i}:");
                vetor[i] = int.Parse(Console.ReadLine());
                if (vetor[i] %2 ==0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
                     
            }
            for(int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"vetor { i } = {vetor[i]}");
            }
            Console.WriteLine($"A quantidade de numeros pares foi de {par}");
            Console.WriteLine($"A quantidade de numeros impares foi de {impar}");
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 2


            /*int[] vetor1 = new int[20];
            int[] vetor2 = new int[20];
            int[] vetorSoma = new int[20];


            for( int i = 0; i < vetor1.Length; i++ )
            {
                Console.WriteLine(" Vetor 1 digite um valor para a posição "+i+":");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine("Vetor2 digite um valor para a posição "+i+": ");
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            for(int i =0; i < vetor2.Length; i++ )
            {
                vetorSoma[i] = vetor1[i] + vetor2[i];
                Console.WriteLine($"A soma do vetor1 + vetor2 na posição {i} foi " + vetorSoma[i]);
            }

            for(int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine($"vetor 1, posição {i} = {vetor1[i]}");
                Console.WriteLine($"vetor 2, posição {i} = {vetor2[i]}");
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 3 

            /*int[] vetor1 = new int[20];
            
            for(int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine("Digite um valor para a posição "+i+":");
                vetor1[i] = int.Parse(Console.ReadLine());

                int numero = vetor1[i];
                bool primo = true;

                for (int j = 2; j <= numero / 2; j++)
                {
                    if (numero % j == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if(primo == true && i >= 2)
                {
                    Console.WriteLine($"A posição {i} é primo, seu valor: {vetor1[i]}\n");
                }

            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 4

            /*int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] vetorTotal = new int[10];

            for(int i =0; i < vetor1.Length; i++)
            {
                Console.WriteLine($"Vetor 1 digite um valor para a posição {i}: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.WriteLine($"Vetor 2 digite um valor para a posição {i}:");
                vetor2[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < vetor1.Length; i++)
            {
                vetorTotal[i] = vetor1[i] * vetor2[i];
                Console.WriteLine($"O valor de {vetor1[i]} (vetor 1) X {vetor2[i]} (vetor 2) = {vetorTotal[i]}");
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 5

            /*int[] vetor1 = new int[8];
            int[] vetor2 = new int[8];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine($"Vetor 1 digite um valor para a posição {i}: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            int menorValor = vetor1[0]; //para descobrir o menor valor eu declarei ele sendo menor na primeira entrada

            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] < menorValor)
                {
                    menorValor = vetor1[i];
                }
            }
            vetor2[0] = menorValor;

            Console.WriteLine($"O menor valor do vetor é {menorValor}");

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 6

            /*int[] vetor1 = new int[3];
            int[] vetor2 = new int[3];

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine($"Vetor 1 digite um valor para a posição {i}: ");
                vetor1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Os vetores informados na ordem inversa, são:\n");
            for (int i = vetor1.Length -1; i>= 0; i--)
            {
                Console.WriteLine(vetor1[i]);

            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 7

            /*int[] vetor1 = new int[10];
            Random random = new Random();

            for ( int i = 0; i < vetor1.Length; i++ )
            {
                vetor1[i] = random.Next(0,50);
            }
            Console.WriteLine("Elementos do vetor: ");
            for ( int i = 0;i < vetor1.Length;i++ )
            {
                Console.Write(vetor1[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Apresentando os numeros pares primeiro: ");
            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] % 2 == 0) 
                {
                    Console.Write(vetor1[i]+" ");
                }
            }
            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] % 2 != 0)
                {
                    Console.Write(vetor1[i]+" ");
                }
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 9

            int[] vetor1 = new int[10];
            Random random = new Random();

            for(int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = random.Next(0, 100);
            }
            Console.WriteLine("Elementos do vetor: ");
            for(int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine(vetor1[i]+ " ");
            }
            Console.WriteLine("Elementos do vetorem ordem crescente: ");
            Array.Sort(vetor1);
            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.WriteLine(vetor1[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
