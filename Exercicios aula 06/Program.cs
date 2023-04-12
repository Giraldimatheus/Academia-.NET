using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_aula_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int opcao = 0;

            for (int i = 0; true; i++)
            {
                if (opcao > 4 || opcao < 1)
                {
                    Console.WriteLine("Qual a opção desejada? 1 a 4");
                    opcao = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Você digitou corretamente! Opção " + opcao);
                    break;
                }
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            /*int num;
            string input;
            int par = 0;
            int impar = 0;
            int bol = 0;
            bool s = true;
            
            while (s)
            {
                for (int i = 0; true; i++)
                {
                    Console.WriteLine("Digite um numero inteiro positivo: ");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out num) && num > 1)
                    {
                        Console.WriteLine($"Você digitou o numero corretamente! Numero {input}\n");
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Entrada inválida! Digite o número corretamente. \n");
                    }
                }

                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 == 0)
                    {
                        par++;
                    }
                    else
                    {
                        impar++;
                    }
                }
                Console.WriteLine($"O número de números pares entre 1 e {num} é: {par}\n");

                Console.WriteLine("Voce deseja continuar o programa? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == "s")
                {
                    s = true;
                }
                else
                {
                    s = false;
                }
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 2

            /*int num;
            bool s = true;
            int par=0;
            int impar=0;

            while(s)
            {
                List<int> list = new List<int>();

                for(int i = 0; i < 3 ; i++)
                {
                    Console.WriteLine("Digite um número");
                    list.Add(int.Parse(Console.ReadLine()));

                    if (list[list.Count - 1] % 2 == 0)
                    {
                        par++;
                    }
                    else
                    {
                        impar++;
                    }

                }
                Console.WriteLine($"Os numeros pares foram: {par}\n");
                Console.WriteLine($"Os numeros impares foram: {impar}\n");
                Console.WriteLine("Os numeros digitados foram:");
                foreach (int nume in list)
                {
                    Console.WriteLine(nume + "");
                }
                

                for (; ; )
                {
                    Console.WriteLine("Deseja continuar o programa? (s/n)");
                    string resposta = Console.ReadLine();
                    if (resposta == "s")
                    {
                        s = true;
                        break;
                    }
                    else if (resposta == "n")
                    {
                        s = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Você não digitou corretamente!");
                    }
                }*/


            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 3

            /*int num;
            bool s = true;

            while (s)
            {
                List<int> list = new List<int>();
                for(; ; )
                {
                    Console.WriteLine("Digite um número: ");
                    list.Add(int.Parse(Console.ReadLine()));

                    if (list[list.Count -1] % 2 == 0)
                    {
                        Console.WriteLine("Esse número é par");
                    }
                    else
                    {
                        Console.WriteLine("Esse é um número impar");
                    }

                    Console.WriteLine("Se quiser continuar digite s ");
                    string resposta = Console.ReadLine();

                    if (resposta == "s")
                    {
                        s = true;
                    }
                    else
                    {
                        s = false;
                    }
                }

                
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 4

            /*int ze=0;
            int joao=0;
            int branco=0;
            string voto;
            bool fim = true;


            while (fim)
            {
                Console.WriteLine("Em quem vai votar? ");
                voto = Console.ReadLine();
                
                if(voto == "ze")
                {
                    ze++;
                }
                else if (voto == "joao")
                {
                    joao++;
                }
                else if (voto == "branco")
                {
                    branco++;
                }
                else
                {
                    Console.WriteLine("Voce digitou errado. Você deve votar ze, joao ou branco");
                }

                Console.WriteLine("Se deseja continuar aperte Enter, senão fim");
                string resposta = Console.ReadLine();
                if(resposta == "fim")
                {
                    fim = false;
                }
                else
                {
                    fim = true;
                }
            }

            Console.WriteLine("A quantidade de votos em joao foi de: "+ joao+" votos");
            Console.WriteLine("A quantidade de votos em ze foi de: " + ze + " votos");
            Console.WriteLine("A quantidade de votos em branco foi de: " + branco + " votos");

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 5

            /*int ze = 0;
            int joao = 0;
            int branco = 0;
            int nulo=0;
            string voto;
            bool fim = true;


            while (fim)
            {
                Console.WriteLine("Em quem vai votar? ");
                voto = Console.ReadLine();

                if (voto == "ze")
                {
                    ze++;
                }
                else if (voto == "joao")
                {
                    joao++;
                }
                else if (voto == "branco")
                {
                    branco++;
                }
                else
                {
                    nulo++;
                }

                Console.WriteLine("Se deseja continuar aperte Enter, senão fim");
                string resposta = Console.ReadLine();
                if (resposta == "fim")
                {
                    fim = false;
                }
                else
                {
                    fim = true;
                }
            }

            Console.WriteLine("A quantidade de votos em joao foi de: " + joao + " votos");
            Console.WriteLine("A quantidade de votos em ze foi de: " + ze + " votos");
            Console.WriteLine("A quantidade de votos em branco foi de: " + branco + " votos");

            int totalVotos = joao+ze+nulo+branco;
            Console.WriteLine($"O total de votos foi de {totalVotos} votos ");

            if ( ze > joao && ze > branco )
            {
                Console.WriteLine("O maior numero de votos foi de ze, com " + ze + "votos");
            }
            else if ( joao> ze && joao>branco )
            {
                Console.WriteLine("O maior numero de votos foi de joao, com " + joao + "votos");
            }
            else if(ze == joao)
            {
                Console.WriteLine("Empate");
            }
            else
            {
                Console.WriteLine("o maior numero de votos foi em branco " + branco + " votos");
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 6

            /*int idade=0;
            bool s = true;

            while (s)
            {
                
                for (; ; )
                {
                    Console.WriteLine("Qual a idade? ");
                    if (int.TryParse(Console.ReadLine(), out idade))

                        if (idade < 0 || idade > 150)
                        {
                        Console.WriteLine("Voce digitou uma idade que não abrange nosso sistema.");
                        }
                        else
                        {
                            Console.WriteLine($"A idade digitada foi {idade} anos");
                            s = false;
                        }
                    else
                    {
                        Console.WriteLine("Voce digitou uma idade inválida, Digite novamente");
                        s = false;
                    }
                }
            }
            Console.WriteLine($"A idade foi de {idade} anos ");

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 7

            /*string nome;
            int idade;
            double salario;

            while (true)
            {
                Console.WriteLine("Qual seu nome? ");
                nome = Console.ReadLine();
                if (nome == null || !nome.Any(c => char.IsLetter(c) && c != ' ')) // Esse codigo verifica que nome não é nulo, ou seja, se esta em branco, e verifica se só letras foram usando deixando o final ' ' para que a pessoa possa encrever o nome completo com espaços
                {
                    Console.WriteLine("Voce digitou nome errado, digite novamente");
                    continue;//Continue faz com que o usuario possa novamente inserir um novo valor a variavel
                }
                else
                {
                    break;
                }
            }

                Console.WriteLine("Qual sua idade? ");
                while (!int.TryParse(Console.ReadLine(), out idade) || idade < 0 || idade > 150)//verifica se foi declarada a variavel apenas sendo numeros inteiros maiores que 0 e menores que 150
                {
                    Console.WriteLine("Voce não digitou uma idade invalida.");
                }


                Console.WriteLine("Qual seu salario? ");
                while (!double.TryParse(Console.ReadLine(), out salario) || salario < 0)
                {
                    Console.WriteLine("Você digitou um valor inválido");

                }

                Console.WriteLine($"O seu nome é {nome}, sua idade é {idade} anos, e seu salário é {salario} reais.");
                Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 8

            /*int num;

            while (true)
            {
                Console.WriteLine("Digite um número? ");
                while (!int.TryParse(Console.ReadLine(), out num) || num <= 0)
                {
                    Console.WriteLine("Voce precisa digitar um número inteiro.");
                }

                if (num % 2 == 0)
                {
                    Console.WriteLine("Voce digitou um número inteiro e par!");
                }

                Console.WriteLine("Deseja inserir um novo número? (s/n)");
                string resposta = Console.ReadLine();
                if (resposta == null || resposta != "s")
                {
                    break;
                }
                Console.WriteLine("Comece novamente!");

            }*/

            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 9

            /*int num;
            int naofilhos =0;
            int umaTres = 0;
            int quatroASete = 0;
            int maisDe8 = 0;
            int totalFilhos = 0;

            for(int i =0; i<3; i++)
            {
                Console.WriteLine("Quantos filhos possuem? ");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Você digitou um número inválido. Quantos filhos possuem?");
                }

                    if (num == 0)
                    {
                        naofilhos++;
                    }
                    if (num >= 1 && num <= 3)
                    {
                        umaTres++;
                    }
                    if (num >= 4 && num <= 7)
                    {
                        quatroASete++;
                    }
                    if (num >= 8)
                    {
                        maisDe8++;
                    }

                totalFilhos += num;
            }
            

            Console.WriteLine("A quantidade de casais sem filhos foi de " + naofilhos );
            Console.WriteLine("A quantidade de casais que possuem de um a tres filhos foi de " + umaTres );
            Console.WriteLine("A quantidade de casais que possuem de quatro a sete filhos foi de " + quatroASete );
            Console.WriteLine("A quantidade de casais que possuem mais de oito filhos foi de " + maisDe8 );
            Console.WriteLine("A quantidade total de filhos foi de: "+totalFilhos+" filhos.");

            Console.ReadLine();*/



            //--------------------------------------------------------------------------------------------------------

            // EXERCICIO 10

            string nome;
            string genero;
            int idade;
            int idademenor = 0;
            int idademaior = 0;
            int masculino=0;
            int feminino=0;



            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Qual seu nome?");
                nome= Console.ReadLine();
                if(nome == null || !nome.Any(c => char.IsLetter(c) && c !=' '))
                {
                    Console.WriteLine("Voce digitou um nome inválido. Digite novamente");
                    continue;
                }
                
                Console.WriteLine("Qual seu genero?");
                genero = Console.ReadLine();
                if(genero.ToLower() == "masculino")
                {
                    masculino++;
                } 
                else if (genero.ToLower() == "feminino")
                {
                    feminino++;
                }
                else if(genero.ToLower() != "masculino" && genero.ToLower() != "feminino")
                {
                    Console.WriteLine("Digite masculino ou feminino para genero");
                    continue;
                }

                Console.WriteLine("Qual sua idade? ");
                while(!int.TryParse(Console.ReadLine(), out idade) || idade > 150)
                {
                    Console.WriteLine("Voce digitou uma idade inválida");
                }
                if(idade < 30)
                {
                    idademenor++;
                }
                else if (idademaior > 60)
                {
                    idademaior++;
                }

            }

            Console.WriteLine("A quantidade de pessoas do sexo masculino foi de " + masculino + " pessoas");
            Console.WriteLine("A quantidade de pessoas do sexo feminino foi de " + feminino + " pessoas");
            Console.WriteLine("A quantidade de pessoas com menos de 30 anos foi de " + idademenor + " pessoas");
            Console.WriteLine("A quantidade de pessoas com mais de 60 anos foi de " + idademaior + " pessoas");

            Console.ReadLine();

        }


    }
    
}
