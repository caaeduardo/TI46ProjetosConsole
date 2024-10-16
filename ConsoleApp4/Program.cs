using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosConsole
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string Verifica;
            do
            {
                menuListas();
                Console.WriteLine("Você deseja continuar as atividades??? (S/N): \n");
                Verifica = Console.ReadLine().ToUpper();

            }

            while (Verifica == "S");



        }

        private static void menuListas()

        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Clear();
            int op = 0;
            Console.WriteLine("                    MENU INICIAR \n| Giovanne      ");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("1 - PRIMEIRA LISTA DE ATIVIDADES");
            Console.WriteLine("2 - SEGUNDA LISTA DE ATIVIDADES");
            Console.WriteLine("3 - TERCEIRA LISTA DE ATIVIDADES");
            Console.WriteLine("4 - QUARTA LISTA DE ATIVIDADES");
            Console.WriteLine("0 - Para Fechar o Shell\n");

            Console.Write("Numero da LISTA: ");
            op = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------------");



            //Switch Case
            switch (op)
            {
                case 0:
                    // Use o comando abaixo para interromper o programa
                    Environment.Exit(0);
                    break;
                //LISTA 1
                case 1:   //Menu da primeira Lista de atividades1
                    Lista1 lista1 = new Lista1();
                    Console.Clear();
                    int opLista1 = 0;
                    Console.WriteLine("MENU INICIAR (LISTA 1) ");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("1 - Primeira atividade ");
                    Console.WriteLine("2 - Segunda atividade");
                    Console.WriteLine("3 - Terceira  atividade");
                    Console.WriteLine("4 - Quarta  atividade");
                    Console.WriteLine("5 - Quinta  atividade");
                    Console.WriteLine("6 - Sexta  atividade");
                    Console.WriteLine("7 - Sétima  atividade");
                    Console.WriteLine("8 - Oitava  atividade");
                    Console.WriteLine("9 - Nona  atividade");
                    Console.WriteLine("10 - Décima  atividade");
                    Console.WriteLine("Digite o numero da atividade: \n");
                    opLista1 = int.Parse(Console.ReadLine());

                    switch (opLista1)
                    {

                        case 1:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe1();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe2();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe3();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe4();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe5();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe6();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe7();
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe8();
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe9();
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista1.Exe10();
                            break;
                        default:
                            Console.WriteLine("Tente outro item da lista");
                            break;

                    }
                    break;

                case 2:
                    //LISTA 2
                    Lista2 lista2 = new Lista2();
                    Console.Clear();
                    int opLista2 = 0;
                    Console.WriteLine(" MENU INICIAR (LISTA 2) ");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("1 - Primeira atividade ");
                    Console.WriteLine("2 - Segunda atividade");
                    Console.WriteLine("3 - Terceira  atividade");
                    Console.WriteLine("4 - Quarta  atividade");
                    Console.WriteLine("5 - Quinta  atividade");
                    Console.WriteLine("6 - Sexta  atividade");
                    Console.WriteLine("7 - Sétima  atividade");
                    Console.WriteLine("8 - Oitava  atividade");
                    Console.WriteLine("9 - Nona  atividade");
                    Console.WriteLine("10 - Décima  atividade");
                    Console.WriteLine("11 - Décima Primeira atividade");
                    Console.WriteLine("Digite o numero da atividade: ");
                    opLista2 = int.Parse(Console.ReadLine());

                    switch (opLista2)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe1();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe2();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe3();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe4();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe5();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe6();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe7();
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe8();
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe9();
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe10();
                            break;
                        case 11:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista2.Exe11();
                            break;
                        default:

                            Console.WriteLine("Tente outro item da lista");
                            break;
                    }
                    break;


                //LISTA 3
                case 3:

                    Lista3 lista3 = new Lista3();
                    Console.Clear();
                    int opLista3 = 0;
                    Console.WriteLine("MENU INICIAR (LISTA 3) ");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("1 - Primeira atividade ");
                    Console.WriteLine("2 - Segunda atividade");
                    Console.WriteLine("3 - Terceira  atividade");
                    Console.WriteLine("4 - Quarta  atividade");
                    Console.WriteLine("5 - Quinta  atividade");
                    Console.WriteLine("6 - Sexta  atividade");
                    Console.WriteLine("Digite o numero da atividade: ");
                    opLista3 = int.Parse(Console.ReadLine());

                    switch (opLista3)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.Exe1();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.Exe2();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.Exe3();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.Exe4();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.Exe5();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista3.Exe6();
                            break;
                        default:
                            Console.WriteLine("Tente outro item da lista");
                            break;

                    }
                    break;
               
                    
                //LISTA 3
                case 4:

                    Lista4 lista4 = new Lista4();
                    Console.Clear();
                    int opLista4 = 0;
                    Console.WriteLine("MENU INICIAR (LISTA 4) ");
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("1 - Primeira atividade ");
                    Console.WriteLine("2 - Segunda atividade");
                    Console.WriteLine("3 - Terceira  atividade");
                    Console.WriteLine("4 - Quarta  atividade");
                    Console.WriteLine("5 - Quinta  atividade");
                    Console.WriteLine("6 - Sexta  atividade");
                    Console.WriteLine("7 - Sétima atividade");
                    Console.WriteLine("8- Oitava atividade");
                    Console.WriteLine("9 - Nona atividade");
                    Console.WriteLine("10 - Décima atividade");
                    Console.WriteLine("Digite o numero da atividade: ");
                    opLista4 = int.Parse(Console.ReadLine());

                    switch (opLista4)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.Exe1();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.Exe2();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.Exe3();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.Exe4();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.Exe5();
                            break;
                        case 6:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.Exe6();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.Exe7();
                            break;
                        case 8:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.Exe8();
                            break;
                        case 9:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.Exe9();
                            break;
                        case 10:
                            Console.Clear();
                            Console.WriteLine("-------------------------------------------------------------");
                            lista4.Exe10();
                            break;
                        default:
                            Console.WriteLine("Tente outro item da lista");
                            break;

                    }
                    break;
            }

        }
    }
}