using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosConsole
{
    internal class Lista3
    {
        internal void Exe1()
        {
            Console.WriteLine("1.Faça um programa que receba 3 valores e retorne a soma deles.\n");
            {
                double valor1, valor2, valor3, resultado;

                // Solicita ao usuário que insira os valores
                Console.Write("Digite o primeiro valor: ");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo valor: ");
                valor2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o terceiro valor: ");
                valor3 = Convert.ToDouble(Console.ReadLine());


                // Calcula a soma
                resultado = valor1 + valor2 + valor3;

                // Exibe o resultado na tela
                Console.WriteLine("A soma dos valores é: " + resultado);
            }
            Console.WriteLine("Fim do exercício 1");
            Console.WriteLine("-------------------------------------------------------------");
        }


        internal void Exe2()
        {
            Console.WriteLine("2.Faça um programa que receba quatro notas e retorne a média.\n");
            {
                double nota1, nota2, nota3, nota4, media;

                Console.Write("Digite a primeira nota: ");
                nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota ");
                nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a terceira nota: ");
                nota3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite a quarta nota ");
                nota4 = Convert.ToDouble(Console.ReadLine());

                media = (nota1 + nota2 + nota3 + nota4) / 4;

                Console.WriteLine("A media é: " + media);
            }
            Console.WriteLine("Fim do exercício 2");
            Console.WriteLine("-------------------------------------------------------------");
        }

        internal void Exe3()
        {
            Console.WriteLine("3.Faça um programa que receba um nome enquanto o nome for diferente de João continuar pedindo o nome\n");
            {
                string nome;

                do
                {
                    Console.Write("Digite um nome (digite 'João' para parar): ");
                    nome = Console.ReadLine();
                } while (nome != "João");

                Console.WriteLine("Você digitou João. O programa será encerrado.");
            }
            Console.WriteLine("Fim do exercício 3");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe4()
        {
            Console.WriteLine("4.\tFaça um programa que retorne à quantidade de números pares existente entre 35 e 98111");
            {
                
        
            int inicio = 35;
            int fim = 98111;
            int contadorPares = 0;

            for (int i = inicio; i <= fim; i++)
            {
                if (i % 2 == 0)
                {
                    contadorPares++;
                }
            }

            Console.WriteLine($"A quantidade de números pares entre {inicio} e {fim} é: {contadorPares}");
            }
            Console.WriteLine("Fim do exercício 4\n");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe5()
        {
            Console.WriteLine("5.\tFaÇa um programa que some todos os números ímpares de 1 até 5000\n");
            
                   
                    {
                        int soma = 0;

                        for (int i = 1; i <= 5000; i += 2)
                        {
                            soma += i;
                        }

                        Console.WriteLine("A soma dos números ímpares de 1 a 5000 é: " + soma);
                    }
            Console.WriteLine("Fim do exercício 5");
            Console.WriteLine("-------------------------------------------------------------");
        }

        internal void Exe6()
        {
            Console.WriteLine("6.Faça um programa que receba um número e usando laços de repetição calcule e mostre a tabuada desse número.\n");
            {

            }
            Console.WriteLine("Fim do exercício 6");
            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}