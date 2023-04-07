using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_aula_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // EXERCICIOS

            /*int num;

            Console.WriteLine("Digite um numero");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 9:
                    Console.WriteLine("o numero digitado é 9");
                    break;
                case 10:
                    Console.WriteLine("o numero digitado é 10");
                    break;
                default:
                    Console.WriteLine("o numero digitado não é 9 nem 10");
                    break;
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            /*double n1, n2, resultado;

            char op;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a operação: ");
            Console.WriteLine("Digite + para soma\nDigite - para subtração");
            Console.WriteLine("Digite x para multiplicação\nDigite / para divisão");
            op = char.Parse(Console.ReadLine());

            switch (op)

            {

                case '+':

                    resultado = n1 + n2;
                    Console.WriteLine("O resultado da soma de " + n1 + " e " + n2 + " = " + resultado);
                    break;

                case '-':
                    resultado = n1 - n2;
                    Console.WriteLine("O resultado da subtração de " + n1 + " e " + n2 + " = " + resultado);
                    break;

                case 'x':
                    resultado = n1 * n2;
                    Console.WriteLine("O resultado da multiplicação de " + n1 + " e " + n2 + " = " + resultado);
                    break;

                case '/':
                    resultado = n1 / n2;
                    Console.WriteLine("O resultado da divisão de " + n1 + " e " + n2 + " = " + resultado);
                    break;

                default:
                    Console.WriteLine("Operação inválida!");
                    break;


            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            /*int i;
            Console.WriteLine("digite um valor para i: ");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine(i + " é " + (i / 2 == 0 ? "par" : "impar"));

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 11

            /*double hora;
            double minutos;
            string horarioInformado;

            Console.WriteLine("Qual a hora informada? HH:mm ");
            horarioInformado = Console.ReadLine();


            if(!DateTime.TryParseExact(horarioInformado, "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateTime))
            {
                Console.WriteLine("Horário inválido.");
            }
            else
            {
                Console.WriteLine("Horário lido: {0}", dateTime.ToString("HH:mm"));
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 12

            /*int codigo;
            double horas;
            double horasExtras;

            Console.WriteLine("Qual seu codigo de funcionário? ");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas horas trabalhadas? ");
            horas = double.Parse(Console.ReadLine());

            

            if(horas < 50)
            {
                double salario = horas * 10;
                Console.WriteLine($"Seu salário foi de {salario} reais, este mês você não teve horas extras.");
            }
            else if(horas > 50)
            {
                horasExtras = (horas - 50) * 20;
                double salario = (horas - (horasExtras / 20)) * 10;
                Console.WriteLine($"Seu salario esse mês foi {salario} e suas horas extras {horasExtras} reais.");
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 13



        }
    }
}
