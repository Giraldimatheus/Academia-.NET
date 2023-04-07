using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_aula_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //EXERCICIOS DE IF E ELSE


            /*double L1, L2, L3;

            Console.WriteLine("Digite o lado 1: ");
            L1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 2: ");
            L2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o lado 3: ");
            L3= double.Parse(Console.ReadLine());

            if((L1 <=L2+L3)&&(L2 <= L1+L3) && (L3 <= (L1 + L2)))
            {
                Console.Write("Os lados representam um triangulo");

                if (L1==L2&& L2==L3)
                {
                    Console.WriteLine(" equilatero");
                }
                else if (L1==L2 || L2==L3 || L1 == L3)
                {
                    Console.WriteLine(" isósceles!");
                }
                else 
                {
                    Console.WriteLine(" escaleno");
                }
            }*/


            //--------------------------------------------------------------------------------------------------------


            /*Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            Área do triangulo = (base * altura) / 2; 
            Teste se a base ou a altura digitada não foi igual a zero.*/

            /*float base1;
            float altura;

            Console.WriteLine("Digite o valor da base do triangulo: ");
            base1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do triangulo: ");
            altura = float.Parse(Console.ReadLine());

            if (base1 > 0 && altura > 0)
            {
                float area = (altura * base1);
                Console.WriteLine("O valor da área foi de: " + area);
            }

            else
            {
                Console.WriteLine("Os valores precisam ser maiores que 0");
            }

            Console.ReadLine();*/


            //--------------------------------------------------------------------------------------------------------


            /* EXERCICIO 4 - Escrever um algoritmo para ler quatro valores inteiros, 
             * calcular a sua média, e escrever na tela os que são superiores à média.*/

            /*float n1, n2, n3, n4;

            Console.WriteLine("digite n1: ");
            n1= float.Parse(Console.ReadLine());
            Console.WriteLine("digite o n2: ");
            n2= float.Parse(Console.ReadLine());
            Console.WriteLine("digite o n3: ");
            n3= float.Parse(Console.ReadLine());
            Console.WriteLine("digite o n4: ");
            n4= float.Parse(Console.ReadLine());

            float media = (n1+n2+n3+n4)/4;

            Console.WriteLine("O valor da media é de: " + media);

            if(n1 > media)
            {
                Console.WriteLine(n1 + " é maior que média " + media);
            }
            if(n2 > media)
            {
                Console.WriteLine(n2 + " é maior que média " + media);
            }
            if(n3 > media)
            {
                Console.WriteLine( n3 + " é maior que média " + media);
            }
            if (n4 > media)
            {
                Console.WriteLine(n4 + " é maior que média " + media);
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            //EXERCICIO 5 MEDIA DO ALUNO
            /*float nota1;
            float nota2;
            float exame;

            Console.WriteLine("Qual foi a primeira nota do aluno? ");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual foi a segunda nota do aluno? ");
            nota2= float.Parse(Console.ReadLine());

            Console.WriteLine((nota1+nota2)/2 >= 7 ? "Aprovado" : "reprovado, terá que fazer exame.");

            if ((nota1 + nota2) / 2 < 7)
            {
                Console.WriteLine("O aluno fez exame, qual foi a nota? ");
                exame = float.Parse(Console.ReadLine());
                Console.WriteLine(exame >= 7 ? "Aprovado" : "reprovado");
            }

            
            
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            //EXERCICIO 6

            /*string nome;
            float peso;
            float altura;

            Console.WriteLine("Qual seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual seu peso? ");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual sua altura? ");
            altura= float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);

            if (imc < 18)
            {
                Console.WriteLine(nome + " Baixo peso");
            }
            if (imc > 18 && imc < 25)
            {
                Console.WriteLine(nome + " Peso normal");
            }
            if(imc  > 25 && imc < 30)
            {
                Console.WriteLine(nome + " Sobrepeso");
            }
            if (imc > 30 && imc < 35)
            {
                Console.WriteLine(nome + " Obesidade");
            }
            if(imc > 35)
            {
                Console.WriteLine(nome + " Obesidade grau sério");
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 7

            /*string palavra;
            string frase;

            Console.WriteLine("Escreva uma frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Qual palavra você quer identificar se existe na frase? ");
            palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine($"A palavra {palavra} se encontra na frase");
            }
            else
            {
                Console.WriteLine($"A palavra {palavra} não se encontra na frase");
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 8

            /*string nome;
            double salarioBase;
            double vendas;
            double salarioFinal;

            Console.WriteLine("Qual o nome do funcionario? ");
            nome = Console.ReadLine();
            Console.WriteLine("Qual o salario base do funcionario? ");
            salarioBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual foi o total de vendas do funcionário? ");
            vendas = double.Parse(Console.ReadLine());

            if(vendas < 500)
            {
                salarioFinal = salarioBase + (vendas * 0.05);
                Console.WriteLine("O seu salario final foi: " + salarioFinal);
            }
            else if(vendas > 500 && vendas <1000)
            {
                salarioFinal = salarioBase + (vendas * 0.07);
                Console.WriteLine("O seu salario final foi: " + salarioFinal);
            }
            else if(vendas > 1000 && vendas < 4999.99)
            {
                Console.WriteLine("Voce não ganhou nada");
            }
            else if(vendas > 5000)
            {
                salarioFinal = salarioBase + (vendas * 0.10);
                Console.WriteLine("O seu salario final foi: " + salarioFinal);
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 9

            /*double valor1;
            double valor2;
            double valor3;

            Console.WriteLine("Qual o valor da primeira medição de glicemia? ");
            valor1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da segunda medição de glicemia? ");
            valor2= double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor da terceira medição de glicemia? ");
            valor3= double.Parse(Console.ReadLine());

            if (valor1 < 65 || valor2 < 65 || valor3 < 65)
            {
                Console.WriteLine("Você está correndo risco de hipoglicemia");
            }
            else if (valor1 > 65 && valor1 < 150 || valor2 > 65 && valor2 < 150 || valor3 > 65 && valor3 < 150)
            {
                Console.WriteLine("Sua glicemia está normal");
            }
            else if (valor1 > 150 || valor2 > 150 || valor3 > 150)
            {
                Console.WriteLine("Você está com hiperglicemia");
            }

            double media = (valor1 + valor2 + valor3)/ 3;

            if(media < 80)
            {
                Console.WriteLine($"Sua media esta {media} você precisa diminuir duas doses de insulina.");
            }
            else if(media > 80 && media < 150)
            {
                Console.WriteLine($"Sua media foi de {media} você não precisa se preocupar.");
            }
            else if(media > 150)
            {
                Console.WriteLine($"Sua media foi de {media} você precisa aumentar duas doses de insulina.");
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 10

            /*string nome1;
            string nome2;
            int idade1;
            int idade2;
            double altura1;
            double altura2;

            Console.WriteLine("Qual o nome do primeiro atleta? ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Qual o nome do segundo atleta? ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Qual a idade do primeiro atleta? ");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a idade do segundo atleta? ");
            idade2= int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a altura do primeiro atleta? ");
            altura1= double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a altura do segundo atleta? ");
            altura2= double.Parse(Console.ReadLine());

            Console.WriteLine(idade1 < idade2 ? "O atleta mais novo é: " + nome1 : "O atleta mais novo é: " + nome2);
            Console.WriteLine(altura1 > altura2 ? "O atleta mais alto é: " + nome1 : "O atleta mais alto é: " + nome2);

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------



        }
    }
}
