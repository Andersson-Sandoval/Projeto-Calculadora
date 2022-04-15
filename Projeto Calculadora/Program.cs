using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Calculadora
{
    class Program
    {

        enum Menu { Adição = 1, Subtração, Divisão, Multiplicação, Potencia, Raiz, Sair };
        static void Main(string[] args)

        {
            bool exitBotton = false;

            while (!exitBotton)
            {
                Console.WriteLine("\nSeja bem-vindo ao CALC,Selecione Uma das opções abaixo: \n");
                Console.WriteLine("1-Adição\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potencia\n6-Raiz\n7-Sair");

                Menu Option = (Menu)int.Parse(Console.ReadLine());

                switch (Option)
                {

                    case Menu.Adição:
                        Adição();
                        break;


                    case Menu.Subtração:
                        Subtração();
                        break;

                    case Menu.Divisão:
                        Divisão();
                        break;

                    case Menu.Multiplicação:
                        Multiplicação();
                        break;


                    case Menu.Potencia:
                        Potencia();
                        break;

                    case Menu.Raiz:
                        Raiz();
                        break;

                    case Menu.Sair:
                        exitBotton = true;
                        break;


                    default:
                        Console.WriteLine("Opção Invalida,aperte Enter e utilize uma das opções do menu inicial");
                        Console.ReadLine();
                        break;

                }




              
                Console.Clear();
            }
        }


        static void Adição()
        {

            Console.WriteLine("Nesta opção você consegue fazer soma de dois números");
            Console.WriteLine("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int Result = a + b;
            Console.WriteLine($"O resultado da sua Adição é:  {Result}");
            Console.WriteLine("Aperte Enter para voltar ao Menu inicial");
            Console.ReadLine();
        }

        static void Subtração()
        {

            Console.WriteLine("Nesta opção você consegue fazer a Subtração de dois números");
            Console.WriteLine("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int Result = a - b;
            Console.WriteLine($"O resultado da sua Subtração é:  {Result}");
            Console.WriteLine("Aperte Enter para voltar ao Menu inicial");
            Console.ReadLine();
        }


        static void Divisão()
        {

            Console.WriteLine("Nesta opção você consegue fazer a Divisão de dois números");
            Console.WriteLine("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            float Result = (float)a / (float)b;
            Console.WriteLine($"O resultado da sua Divisão é:  {Result}");
            Console.WriteLine("Aperte Enter para voltar ao Menu inicial");
            Console.ReadLine();
        }


        static void Multiplicação()
        {

            Console.WriteLine("Nesta opção você consegue fazer a Multiplicação de dois números");
            Console.WriteLine("Digite o Primeiro numero: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo numero: ");
            int b = int.Parse(Console.ReadLine());
            int Result = a * b;
            Console.WriteLine($"O resultado da sua Multiplicação é:  {Result}");
            Console.WriteLine("Aperte Enter para voltar ao Menu inicial");
            Console.ReadLine();
        }

        static void Potencia()
        {

            Console.WriteLine("Nesta opção você consegue fazer a Potencia de um número");
            Console.WriteLine("Digite o numero Base: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o  numero expoente: ");
            int b = int.Parse(Console.ReadLine());
            double Result = Math.Pow(a,b) ;
            Console.WriteLine($"O resultado da sua Potencia é:  {Result}");
            Console.WriteLine("Aperte Enter para voltar ao Menu inicial");
            Console.ReadLine();
        }

        static void Raiz()
        {

            Console.WriteLine("Nesta opção você consegue obter a Raiz de um número");
            Console.WriteLine("Digite o numero : ");
            int a = int.Parse(Console.ReadLine());
            double Result = Math.Sqrt(a);
            Console.WriteLine($"A Raiz de {a} é:  {Result}");
            Console.WriteLine("Aperte Enter para voltar ao Menu inicial");
            Console.ReadLine();
        }




    }
}
