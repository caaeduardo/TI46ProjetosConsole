

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosConsole
{
    internal class Lista1
    {

        internal void Exe1()
        {
            Console.WriteLine("1) Escreva um programa que mostre na tela a mensagem \"Olá, Mundo!\"\n");
            {
                Console.WriteLine("Hello, World!!!  =}\n ");
            }
            Console.WriteLine("Fim do exercício 1");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe2()
        {
            Console.WriteLine("2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas para ela:\n");
            {
                Console.Write("Qual é o seu nome? ");
                string nome = Console.ReadLine();
                Console.WriteLine("Olá,   " + nome + ", é um prazer te conhecer!\n");
            }
            Console.WriteLine("Fim do exercício 2");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe3()
        {
            Console.WriteLine("3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no final uma mensagem.\n");
            {
                Console.Write("Nome do Funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"O funcionário {nome} tem um salário de R${salario:F2} em Junho.\n");
            }

            Console.WriteLine("Fim do exercício 3");
            Console.WriteLine("-------------------------------------------------------------");
        }
        internal void Exe4()
        {
            Console.WriteLine("4) Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório\r\nentre eles.\n");
            {

                Console.Write("Digite um valor: \n");
                int valor1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite outro valor: \n");
                int valor2 = Convert.ToInt32(Console.ReadLine());

                int soma = valor1 + valor2;
                Console.WriteLine($"A soma entre {valor1} e {valor2} é igual a {soma}.\n");
            }

            Console.WriteLine("Fim do exercício 4");
            Console.WriteLine("-------------------------------------------------------------");

        }
        internal void Exe5()
        {
            Console.WriteLine("5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a sua média na disciplina.");
            {
                Console.Write("Nota 1: \n");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nota 2: \n");
                double nota2 = Convert.ToDouble(Console.ReadLine());

                double media = (nota1 + nota2) / 2;
                Console.WriteLine($"A média entre {nota1} e {nota2} é igual a {media:F1}.\n");

            }

            Console.WriteLine("Fim do exercício 5");
            Console.WriteLine("-------------------------------------------------------------");


        }
        internal void Exe6() 
        {
            Console.WriteLine("6) Faça um programa que leia um número inteiro e mostre o seu antecessor e seu sucessor.\n");
            {
                Console.Write("Digite um número: \n");
                int numero = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine($"O antecessor de { numero} é { numero - 1}\n");
                Console.WriteLine($"O sucessor de {numero} é {numero + 1}\n");
            }

        }
        internal void Exe7()
        {
            Console.WriteLine("7) Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a\r\nsua terça parte.\n");
            {

                Console.Write("Digite um número: \n");
                double numero = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"O dobro de {numero} é {numero * 2}\n");
                Console.WriteLine($"A terça parte de {numero} é {numero / 3}\n");

            }
        
        }
        internal void Exe8()
        {
            Console.WriteLine("8) Desenvolva um programa que leia uma distância em metros e mostre os valores\r\nrelativos em outras medidas.\n");
            {

                Console.Write("Digite uma distância em metros: \n");
                double metros = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"A distância de {metros}m corresponde a:\n");
                Console.WriteLine($"{metros / 1000}Km\n");
                Console.WriteLine($"{metros / 100}Hm\n");
                Console.WriteLine($"{metros / 10}Dam\n");
                Console.WriteLine($"{metros * 10}dm\n");
                Console.WriteLine($"{metros * 100}cm\n");
                Console.WriteLine($"{metros * 1000}mm\n");
            }
        
        }
        internal void Exe9()
        {
            Console.WriteLine("9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$)\r\ne mostre quantos dólares ela pode comprar. Considere US$1,00 = R$3,45.\n");
            {

                const double taxaConversao = 3.45; // Taxa de câmbio fixa para este exemplo

                Console.Write("Digite quanto dinheiro você tem na carteira (R$): \n");
                double reais = Convert.ToDouble(Console.ReadLine());

                double dolares = reais / taxaConversao;
                Console.WriteLine($"Você pode comprar US${dolares:F2}.\n");
            }
        
        }
        internal void Exe10()
        {
            Console.WriteLine("10) Faça um algoritmo que leia a largura e altura de uma parede, calcule e\r\nmostre a área a ser pintada e a quantidade de tinta necessária para o serviço,\r\nsabendo que cada litro de tinta pinta uma área de 2metros quadrados.\n");
            {
                Console.Write("Digite a largura da parede (m): \n");
                double largura = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a altura da parede (m): \n");
                double altura = Convert.ToDouble(Console.ReadLine());
                double area = largura * altura;
                double litrosTinta = area / 2;

                Console.WriteLine($"A área a ser pintada é de {area:F2}m².\n");
                Console.WriteLine($"Você precisará de {litrosTinta:F2} litros de tinta.\n");
            }
        }
                
    }

}
