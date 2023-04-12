using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
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

            /*double altura;
            string genero;
            double pesoIdeal;
            string nome;

            Console.WriteLine("Qual seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual seu genêro? Masculino ou Feminino.");
            genero = Console.ReadLine().ToLower();
            Console.WriteLine("Qual sua altura?");
            altura = double.Parse(Console.ReadLine());

            if ( genero == "masculino")
            {
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine($"Olá {nome}, seu peso ideal é de: {pesoIdeal:F2} Kilos, obrigado!");
            }
            else if (genero == "feminino")
            {
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine($"Olá {nome}, seu peso ideal é de: {pesoIdeal:F2} Kilos, obrigado!");
            }
            else
            {
                Console.WriteLine("Por favor, informe apenas se o genêro é Masculino ou Feminino.");
            }*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 14

            /*double tamanhoArquivo;
            double velocidadeNet;
            double download;
            

            Console.WriteLine("Qual o tamanho do arquivo para Download? Em MB");
            tamanhoArquivo = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a velocidade da sua Internet? Em Mbps");
            velocidadeNet= double.Parse(Console.ReadLine());

            
            download = (tamanhoArquivo * 8) / velocidadeNet;
            double minutos = download / 60;
            Console.WriteLine($"O tempo de download foi de: {minutos:F2} minutos.");
            
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 15

            /*double area, qtde, vtotal, qtdeLatas, qtdeLatasCeilling, qtdeLatasFloor;

            Console.WriteLine("Digite a área a ser pintada?");
            area = double.Parse(Console.ReadLine());

            qtde = area / 3;
            qtdeLatas = qtde / 18;

            qtdeLatasCeilling = Math.Ceiling(qtdeLatas);

            qtdeLatasFloor = Math.Floor(qtdeLatas);

            Console.WriteLine($"A area de {area} precisará de {qtde} litros de tinta");
            Console.WriteLine($"Será necessario comprar {qtdeLatasCeilling} latas de tinta - Ceilling");
            Console.WriteLine($"Será necessario comprar {qtdeLatasFloor} latas de tinta - Floor");
            Console.WriteLine($"Será necessario comprar {qtdeLatas} latas de tinta");
            vtotal = qtdeLatasCeilling * 80;
            Console.WriteLine("Custará " + vtotal);

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 16

            int timeCasa;
            int timeFora;

            Console.WriteLine("Quantos gols fez o time da casa? ");
            timeCasa = int.Parse(Console.ReadLine());
            Console.WriteLine("Qauntos gols fez o time de fora? ");
            timeFora = int.Parse(Console.ReadLine());

            if(timeCasa - timeFora > 2)
            {
                Console.WriteLine("O time de casa se classificou");
            }
            if (timeCasa - timeFora == 1)
            {
                Console.WriteLine("Haverá um novo jogo! ");
            }
            if(timeFora - timeCasa > 2)
            {
                Console.WriteLine("O time de fora se classificou");
            }
            if (timeFora - timeCasa == 1)
            {
                Console.WriteLine("Haverá um novo jogo");
            }
            else
            {
                Console.WriteLine("Empate, haverá um novo jogo! ");
            }

            Console.ReadLine();
        }
    }
}
    

