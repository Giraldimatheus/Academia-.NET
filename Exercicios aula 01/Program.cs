using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_aula_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a;
            int b;

            Console.WriteLine("Digite valor para A:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor para B:");
            b = int.Parse(Console.ReadLine());

            int soma = a + b;

            int sub = a - b;

            int multi = a * b;

            double div = a / b;

            Console.WriteLine("O reultado da some e: " + soma);
            Console.WriteLine("O reultado da subtração e: " + sub);
            Console.WriteLine("O reultado da multiplicação e: " + multi);
            Console.WriteLine("O reultado da divisão e: " + div);

            //digita dois valores e mostrar media

            double valor1;
            double valor2;

            Console.WriteLine("Digite o 1 valor: ");
            valor1= double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2 valor: ");
            valor2= double.Parse(Console.ReadLine());

            double resultado = (valor1 + valor2) / 2;

            Console.WriteLine("O resultado foi: " + resultado);

            Console.ReadLine();

            double celsius;
            

            Console.WriteLine("Digite em Celsius: ");
            celsius = int.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Temperatura em Fahrenheit: {0}°F", fahrenheit);
            Console.ReadLine();*/

            int x;
            int y;

            Console.WriteLine("Digite o valor de x: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de y: ");
            y = int.Parse(Console.ReadLine());

            int aux = x;
            x = y;
            y = aux;

            Console.WriteLine("valor de x: " + y);
            Console.WriteLine("valor de y: " + x);

            Console.ReadLine();
        }
    }
}
