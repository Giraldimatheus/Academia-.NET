using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercicios_aula_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int[,] matriz = new int[5, 3];

            for(int linha = 0; linha < 5; linha++)
            {
                Console.Write("Digite um valor para a primeira coluna: ");
                matriz[linha, 0] = int.Parse(Console.ReadLine());
                matriz[linha, 1] = matriz[linha, 0] + 10;
                matriz[linha, 2] = matriz[linha, 0] *2;
            }
            for (int linha = 0; linha < 5; linha++)
            {
                for(int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.ReadLine();

            }*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 2

            /*int[,] matriz = new int[3, 3];

            for(int i =0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Informe um valor para a posição [" + i + ", " + j + "]:");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                

            }
            Console.WriteLine("Matriz:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 3

            /*int[,] matriz = new int[4, 4];
            Random random = new Random();

            for ( int i = 0; i < 4; i++ )
            {
                for(int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                }
            }
            Console.WriteLine("Matriz diagonal principal: ");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i,i] + " ");
                }
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 4

            /*int[,] matriz = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(-50, 50);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz[i,j] % 2 == 0)
                    {
                        Console.WriteLine("Numeros pares: " + matriz[i,j]);
                    }
                    else
                    {
                        Console.WriteLine("Numeros impares: "+ matriz[i,j]);
                    }
                    if (matriz[i, j] > 0)
                    {
                        Console.WriteLine("Numeros positivos: " + matriz[i, j]);
                    }
                    else if (matriz[i, j] < 0)
                    {
                        Console.WriteLine("numeros negativos: " + matriz[i,j]);
                    }
                    else 
                    {
                        Console.WriteLine("Numero zero: " + matriz[i, j]);
                    }


                }
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 5

            /*int[,] matriz = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            Random random = new Random();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = random.Next(0, 50);
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz2[i, j] = random.Next(0, 50);
                }
            }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {matriz[i, j]}");
                    Console.Write($" {matriz2[i, j]}");
                }
            }

            Console.WriteLine("A soma das duas matrizes é: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{matriz[i, j] + matriz2[i, j]}");
                }
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 6

            /*int[,] matriz = new int[4, 4];
            Random random = new Random();
            int valorMaximo = int.MinValue;

            for (int i = 0; i < 4 ; i++)
            {
                for( int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(0, 9);
                    if (matriz[i, j] > valorMaximo)
                    {
                        valorMaximo = matriz[i, j];
                    }
                    Console.WriteLine(" "+matriz[i,j]);
                }

            }
            Console.WriteLine(" Maior valor da matriz: " + valorMaximo);
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 7

            /*int[,] matriz = new int[3,3];
            int[,] matriz2 = new int[3, 3];
            int[,] matriz3 = new int[3, 3];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = random.Next(0, 50);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz2[i, j] = random.Next(0, 50);
                }
            }

            Console.WriteLine("valores da matriz 1: ");
            for(int i = 0; i < 3;i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("valores da matriz 2: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{matriz2[i, j]} ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("o valor da matriz 3 = matriz - matriz 2 :");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz3[i, j] = matriz[i, j] - matriz2[i, j];
                    Console.Write($"{matriz3[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 8

            /*int[,] matriz = new int[4,4];
            Random random = new Random();

            for( int i = 0; i < 4; i++ )
            {
                for( int j = 0; j < 4; j++ )
                {
                    matriz[i,j] = random.Next(0,50);
                }
            }
            Console.WriteLine("Os elementos da matriz são: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(matriz[i,j]+ " ");
                }
            }
            Console.WriteLine("Os elementos da matriz na ordem inversa são: ");
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.WriteLine(matriz[i, j] + " ");
                }
            }

            Console.ReadLine();*/

        }
    }
}

