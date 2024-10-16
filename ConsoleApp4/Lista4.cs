using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosConsole
{
    internal class Lista4
    {
        internal void Exe1()
        {

            Console.WriteLine("1 Escreva um programa que solicite um número ao usuário e verifique se ele é par ou ímpar..\n");
            {
                Console.WriteLine("Digite um número");
                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out int numero))
                {
                    Console.WriteLine("O número {0} é par.", numero);
                }
                else
                {
                    Console.WriteLine("O numero {0} é impar.", numero);
                }

            }
            Console.WriteLine("Fim do exercício 1");
            Console.WriteLine("-------------------------------------------------------------");



        }
        internal void Exe2()
        {
            Console.WriteLine("2. Peça ao usuário para inserir sua idade e classifique-o como \"Criança\" (0-12), \"Adolescente\" (13-17), \"Adulto\" (18-64), ou \"Idoso\" (65+).\n");
            {
                Console.WriteLine("Digite sua idade:");
                int idade = Convert.ToInt32(Console.ReadLine());

                if (idade
     >= 0 && idade <= 12)
                {
                    Console.WriteLine("Você é uma criança.");
                }
                else if (idade >= 13 && idade <= 17)
                {
                    Console.WriteLine("Você é um adolescente.");
                }
                else if (idade >= 18 && idade <= 64)
                {
                    Console.WriteLine("Você é um adulto.");
                }
                else if (idade >= 65)
                {
                    Console.WriteLine("Você é um idoso.");
                }
                else
                {
                    Console.WriteLine("Idade inválida. Por favor, digite um número positivo.");
                }
            }
            Console.WriteLine("Fim do exercício 2");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe3()
        {
            Console.WriteLine("3.Crie um programa que receba uma nota (0 a 10) e exiba se o aluno foi \"Aprovado\" (nota maior ou igual a 6), \"Recuperação\" (nota entre 4 e 5.9) ou \"Reprovado\" (nota menor que 4).\n");
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Digite a nota do aluno (0 a 10):");
                    double nota = Convert.ToDouble(Console.ReadLine());

                    if (nota >= 0 && nota <= 10)
                    {
                        if (nota >= 6)
                        {
                            Console.WriteLine("Aprovado");
                        }
                        else if (nota >= 4)
                        {
                            Console.WriteLine("Recuperação");
                        }
                        else
                        {
                            Console.WriteLine("Reprovado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida. Digite um valor entre 0 e 10.");
                    }
                }
            

        }
            Console.WriteLine("Fim do exercício 3");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe4()
        {
            Console.WriteLine("4.Peça ao usuário para informar seu peso e altura e, em seguida, calcule o Índice de Massa Corporal (IMC) e determine sua categoria: \"Abaixo do peso\", \"Peso normal\", \"Sobrepeso\" ou \"Obesidade\".\n");
            {
                static void Main(string[] args)
                {
                    Console.WriteLine("Digite a nota do aluno (0 a 10):");
                    double nota = Convert.ToDouble(Console.ReadLine());

                    if (nota >= 0 && nota <= 10)
                    {
                        if (nota >= 6)
                        {
                            Console.WriteLine("Aprovado");
                        }
                        else if (nota >= 4)
                        {
                            Console.WriteLine("Recuperação");
                        }
                        else
                        {
                            Console.WriteLine("Reprovado");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Nota inválida. Digite um valor entre 0 e 10.");
                    }
                }
            }
        
            Console.WriteLine("Fim do exercício 4");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe5()
        {
            Console.WriteLine("5.Escreva um programa que receba dois números do usuário e exiba qual é o maior, ou informe se os números são iguais.\n");
            {
                Console.WriteLine("Digite o primeiro número:");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o segundo número: ");
    
                double numero2 = Convert.ToDouble(Console.ReadLine());


                if (numero1 > numero2)
                {
                    Console.WriteLine("O primeiro número é maior.");
                }
                else if (numero2 > numero1)
                {
                    Console.WriteLine("O segundo número é maior.");

                }
                else
                {
                    Console.WriteLine("Os números são iguais.");
                }
            }
            Console.WriteLine("Fim do exercício 5");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe6()
        {
            Console.WriteLine("6.Peça ao usuário sua idade e informe se ele é obrigado a votar (18-70 anos), voto facultativo (16-17 ou acima de 70), ou se não pode votar (abaixo de 16 anos).\n");
            {
                Console.Write("Digite o primeiro número: ");
                double numero1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
    
                double numero2 = Convert.ToDouble(Console.ReadLine());

                if (numero1 > numero2)
                {
                    Console.WriteLine($"O primeiro número({ numero1}) é maior que o segundo({ numero2}).");
                }
                else if (numero2 > numero1)
                {
                    Console.WriteLine($"O segundo número ({numero2}) é maior que o primeiro ({numero1}).");
                }
                else
                {
                    Console.WriteLine($"Os números {numero1} e {numero2} são iguais.");
                }
            }
       
            Console.WriteLine("Fim do exercício 6");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe7()
        {
            Console.WriteLine("7.Crie um programa que receba o valor de uma compra e aplique um desconto de 10% caso o valor seja superior a R$100.\n");
            {

 

            {
                Console.WriteLine("Digite o valor da compra: R$");
                double valorCompra = Convert.ToDouble(Console.ReadLine());

                double valorDesconto = 0;
                double valorFinal = valorCompra;

                if (valorCompra > 100)
                {
                    valorDesconto = valorCompra * 0.1; // Calcula o valor do desconto (10%)
                    valorFinal = valorCompra - valorDesconto; // Calcula o valor final com desconto
                }

                Console.WriteLine($"O valor do desconto é: R${valorDesconto:F2}");
                Console.WriteLine($"O valor final da compra é: R${valorFinal:F2}");
            }
        }
            
            
            Console.WriteLine("Fim do exercício 7");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe8()
        {
            Console.WriteLine("8.Peça ao usuário para informar a temperatura em graus Celsius e classifique se está \"Frio\" (abaixo de 15°C), \"Agradável\" (15-25°C), ou \"Quente\" (acima de 25°C).\n");
            {
                Console.WriteLine("Digite a temperatura em graus Celsius:");
                double temperatura = Convert.ToDouble(Console.ReadLine());

                if (temperatura < 15)
                {
                    Console.WriteLine("Está frio.");
                }
                else if (temperatura <= 25)
                {
                    Console.WriteLine("Está agradável.");
                }
                else
                {
                    Console.WriteLine("Está quente.");
                }
            }
            Console.WriteLine("Fim do exercício 8");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe9()
        {
            Console.WriteLine("9.Solicite três números ao usuário e calcule a média. Caso a média seja maior que 7, exiba \"Aprovado\", senão exiba \"Reprovado\".\n");
            {
                Console.WriteLine("Digite a temperatura em graus Celsius:");
                double temperatura = Convert.ToDouble(Console.ReadLine());

                if (temperatura < 15)
                {
                    Console.WriteLine("Está frio.");
                }
                else if (temperatura <= 25)
                {
                    Console.WriteLine("Está agradável.");
                }
                else
                {
                    Console.WriteLine("Está quente.");
                }
            }
            Console.WriteLine("Fim do exercício 9");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe10()
        {
            Console.WriteLine("10.Peça ao usuário que insira um ano e verifique se ele é bissexto (divisível por 4 e não divisível por 100, exceto se for divisível por 400).\n");
            {
                Console.WriteLine("Digite um ano:");
                int ano = Convert.ToInt32(Console.ReadLine());

                if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
                {
                    Console.WriteLine($"{ano} é um ano bissexto.");
                }
                else
                {
                    Console.WriteLine($"{ano} não é um ano bissexto.");

                }
            }
            Console.WriteLine("Fim do exercício 10");
            Console.WriteLine("-------------------------------------------------------------");
        }
  
    }
}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

