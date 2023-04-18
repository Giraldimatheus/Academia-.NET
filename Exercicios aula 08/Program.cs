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

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 9

            /*int[,] matriz = new int[3, 3];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }

            Console.WriteLine("Qual numero deseja pesquisar na matriz? ");
            int numero = int.Parse(Console.ReadLine());

            bool encontrado = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 ; j++)
                {
                    if(matriz[i, j] == numero)
                    {
                        encontrado = true;
                        Console.WriteLine($"O número {numero} está na posição [{i},{j}] da matriz.");
                    }
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"O número {numero} não existe na matriz.");
            }

            Console.WriteLine("Os elementos da matriz são: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(matriz[i, j] + " ");
                }
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 10

            /*int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz1[i, j] = random.Next(0, 100);
                    matriz2[i, j] = random.Next(0, 100);
                }
            }
            int somaTotal = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int soma = matriz1[i, j] + matriz2[i, j];
                    somaTotal += soma;
                }
            }

            double media = somaTotal / (3.0 * 3.0);

            Console.WriteLine("A média da soma dos elementos das matrizes é: " + media);
            Console.WriteLine("Os elementos acima da média são: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz1[i, j] > media)
                    {
                        Console.WriteLine($"Posição matriz 1 [{i},{j}]: {matriz1[i, j]}"); 
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz2[i, j] > media)
                    {
                        Console.WriteLine($"Posição matriz 2 [{i},{j}]: {matriz2[i, j]}");
                    }
                }
            }

            Console.WriteLine("Os elementos abaixo da média são: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz1[i,j] < media)
                    {
                        Console.WriteLine($"Posição matriz 1 [{i},{j}]: {matriz1[i, j]}");
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz2[i, j] < media)
                    {
                        Console.WriteLine($"Posição matriz 2 [{i},{j}]: {matriz2[i, j]}");
                    }
                }
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 11

            /*int[,] matriz1 = new int[4, 4];
            Random random = new Random();

            for (int i = 1; i < 4; i++)
            {
                for(int j = 1; j < 4; j++)
                {
                    matriz1[i, j] = random.Next(0, 50);
                }
            }
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("A divisão da matriz pela soma de seus indices, começa o indice no 1x1: ");
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    int somaIndices = i + j;
                    matriz1[i, j] = matriz1[i, j] / somaIndices; 
                }
            }
            for (int i = 1; i < 4; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    Console.Write(matriz1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 12

            /*int[,] matriz1 = new int[4, 3];
            Random random = new Random();
            double soma = 0;
            for(int i = 0; i< 4; i++)
            {
                for( int j = 0; j < 3; j++)
                {
                    matriz1[i, j] = random.Next(0, 50);
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz1[i,j] + " ");
                }
                Console.Write("\n");
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    soma = i + j;
                    if(soma % 2 == 0)
                    {
                        Console.Write($"posição {i}{j} { matriz1[i, j]}");
                    }
                    Console.Write("\n");
                }
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 13

            /*int[,] matriz = new int[5, 5];
            Random random = new Random();
            int soma1 = 0;
            int soma2 = 0;

            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(0, 10);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                soma1 += matriz[i, i];
            }
            for (int i = 0; i < 5; i++)
            {
                soma2 += matriz[i, 4-i];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"valor da soma da diagonal principal = {soma1}");
            Console.WriteLine($"valor da soma da diagonal secundária = {soma2}");

            Console.WriteLine();

            if(soma1 == soma2)
            {
                Console.WriteLine("As somas são iguais!");
            }


            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 14

            /*int[,] matriz = new int[5, 5];
            Random random = new Random();
            int[,] matriz2 = new int[5, 5];


            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(0, 10);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz2[i, j] = matriz[i, j];
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.Write(" Matriz principal = ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.Write(" Matriz secundaria = ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(matriz2[i, 4-i] + " ");
            }

            Console.WriteLine();

            bool diagonaisIguais = true;
            for (int i = 0; i < 5; i++)
            {
                if (matriz[i, i] != matriz2[i, 4 - i])
                {
                    diagonaisIguais = false;
                    break;
                }
            }
            if (diagonaisIguais)
            {
                Console.WriteLine("As diagonais principal e secundária são iguais!");
            }
            else
            {
                Console.WriteLine("As diagonais principal e secundária são diferentes!");
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 15

            /*int[,] matriz = new int[5, 5];
            int[,] matriz2 = new int[5, 5];
            int[,] matriz3 = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Matriz 1 = ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz2[i, j] = random.Next(0, 100);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Matriz 2 = ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz2[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz3[i, j] = matriz[i, j] + matriz2[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Matriz 1 + Matriz 2 = ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz3[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 16

            /*int[,] matriz = new int[3, 4];
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }

            Console.WriteLine("Matriz 3x4: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Matriz 4x3: ");
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 17

            int[,] matriz = new int[10, 10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = random.Next(0, 100);
                }
            }

            Console.WriteLine("Matriz 10x10: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            int linhaMaiorValor = 0;
            int maiorValor = matriz[0, 0];


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i, j] > maiorValor)
                    {
                        linhaMaiorValor = i;
                        maiorValor = matriz[i, j];
                    }
                }
            }

            int menorValor = matriz[linhaMaiorValor, 0];


            for (int j = 1; j < 10; j++)
            {
                if (matriz[linhaMaiorValor, j] < menorValor)
                {
                    menorValor = matriz[linhaMaiorValor, j];
                }
            }

            Console.WriteLine("O menor valor da linha do maior valor é: " + menorValor);
            Console.WriteLine("A linha do maior valor é: " + linhaMaiorValor);

            Console.ReadLine();
        }
    }
}

