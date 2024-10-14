using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosConsole
{
    internal class Lista2
    {
        internal void Exe1()
        {

            Console.WriteLine("1) Escreva um algoritmo que leia um número e o imprima caso ele seja maior que 20.\n");
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 20)
                {
                    Console.WriteLine("O número é maior que 20.\n");
                }
                Console.WriteLine("Fim do exercício 1");
                Console.WriteLine("-------------------------------------------------------------");



            }
        }
        internal void Exe2()
        {
            Console.WriteLine("2.Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for maior que 10, caso contrário escrever NÃO É MAIOR QUE 10!\n");
            {
                Console.Write("Digite um valor: \n");
                int valor = int.Parse(Console.ReadLine());

                if (valor > 10)
                {
                    Console.WriteLine("É MAIOR QUE 10!\n");
                }
                else
                {
                    Console.WriteLine("NÃO É MAIOR QUE 10!\n");
                }
            }
            Console.WriteLine("Fim do exercício 2");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe3()
        {
            Console.WriteLine("3.Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.\n");
            {
                Console.Write("Digite o valor de A: \n");
                int A = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de B: \n");
                int B = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de C: \n");
                int C = int.Parse(Console.ReadLine());


                if (A + B < C)
                {
                    Console.WriteLine("A soma de A + B é menor que C.\n");
                }
            }
            Console.WriteLine("Fim do exercício 3");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe4()
        {
            Console.WriteLine("4.Construa um algoritmo que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja maior que 10, apresentá-lo.\n");
            {
                Console.Write("Digite o primeiro valor: \n");
                int A = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: \n");
                int B = int.Parse(Console.ReadLine());


                int C = A + B;

                if (C > 10)
                {
                    Console.WriteLine("O resultado da soma é: " + C);
                }
            }
            Console.WriteLine("Fim do exercício 4");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe5()
        {
            Console.WriteLine("5.Construa um algoritmo que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja maior que 10, apresentá-lo.\n");
            {
                Console.Write("Digite o nome: \n");
                string nome = Console.ReadLine();
                Console.Write("Digite o sexo (F/M): \n");
                char sexo = char.Parse(Console.ReadLine());
                Console.Write("Digite o estado civil (CASADA/SOLTEIRA): \n");
                string estadoCivil = Console.ReadLine();

                if (sexo == 'F' && estadoCivil.ToUpper() == "CASADA\n")
                {
                    Console.Write("Tempo de casada (anos): ");
                    int tempoCasada = int.Parse(Console.ReadLine());

                }

            }
            Console.WriteLine("Fim do exercício 5");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe6()
        {
            Console.WriteLine("6.Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.\n");
            {

                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número é par.");
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                }


            }
            Console.WriteLine("Fim do exercício 6");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe7()
        {
            Console.WriteLine("7.Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.\n");
            {

                Console.Write("Digite o valor de A: \n");
                int A = int.Parse(Console.ReadLine());
                Console.Write("Digite o valor de B: \n");
                int B = int.Parse(Console.ReadLine());

                int C;

                if
                    (A == B)
                {
                    C = A + B;
                }
                else
                {
                    C = A * B;
                }

                Console.WriteLine("O resultado é: " + C);


            }
            Console.WriteLine("Fim do exercício 7");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe8()
        {
            Console.WriteLine("8.Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo, imprimindo o resultado.\n");
            {

                Console.Write("Digite um número: \n");
                int numero = int.Parse(Console.ReadLine());

                int resultado;

                if (numero > 1)//não resolvi como enunciado
                {
                    resultado = numero * 2;
                }
                else
                {
                    resultado = numero * 3;
                }

                Console.WriteLine("O resultado é: " + resultado);


            }
            Console.WriteLine("Fim do exercício 8");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe9()
        {
            Console.WriteLine("9.Faça um algoritmo que leia 3 valores retorno do maior para o menor ordenados.\n");
            {

                Console.Write("Digite o primeiro valor: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.Write("Digite o terceiro valor: ");
                int num3 = int.Parse(Console.ReadLine());


                // Utilizando o método Sort() para ordenar em ordem decrescente
                int[] numeros = { num1, num2, num3 };
                Array.Sort(numeros);
                Array.Reverse(numeros);

                Console.WriteLine("Os números em ordem decrescente são:");

                foreach (int numero in numeros)
                {
                    Console.WriteLine(numero);
                }


            }
            Console.WriteLine("Fim do exercício 9");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe10()
        {
            Console.WriteLine("10.Faça um algoritmo que leia 3 valores retorne do menor para o maior ordenados.\n");
            {

                Console.Write("Digite o primeiro valor: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                int num2 = int.Parse(Console.ReadLine());
                Console.Write("Digite o terceiro valor: ");
                int num3 = int.Parse(Console.ReadLine());


                // Utilizando o método Sort() para ordenar em ordem crescente
                int[] numeros = { num1, num2, num3 };
                Array.Sort(numeros);

                Console.WriteLine("Os números em ordem crescente são:");
                foreach (int numero in numeros)
                {
                    Console.WriteLine(numero);
                }


            }
            Console.WriteLine("Fim do exercício 10");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe11()
        {
            Console.WriteLine("11.Ler a hora de início e a hora de fim de um jogo de Xadrez (considere apenas horas inteiras, sem os minutos) e calcule a duração do jogo em horas, sabendo-se que o tempo máximo de duração do jogo é de 24 horas e que o jogo pode iniciar em um dia e terminar no dia seguinte retornar quantas horas estão jogando e quantidade de horas restante ou quantidade de horas excedente.\n");
            {
                //não realizei a continuidade
                Console.Write("Digite a hora de início do jogo: ");
                int inicio = int.Parse(Console.ReadLine());
                Console.Write("Digite a hora de fim do jogo: ");
                int fim = int.Parse(Console.ReadLine());

                int duracao;

                if (fim >= inicio)
                {
                    duracao = fim - inicio;
                }
                else
                {
                    duracao = 24 - inicio + fim;
                }


            }
            Console.WriteLine("Fim do exercício 11");
            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}

