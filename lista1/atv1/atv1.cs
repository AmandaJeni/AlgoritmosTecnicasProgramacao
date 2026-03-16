using System;

// Escreva um programa onde serão fornecidos como entrada de dados dois valores inteiros,
// calcule e imprima a soma, a diferença e o quociente destes números.

internal class Program
{
    static void Main(string[] args)
    {
        // Declarando as variáveis
        int numero1, numero2, resultado, opcao;
        string produto1, produto2;

        // Cabeçalho
        Console.WriteLine("=========================================================================");
        Console.WriteLine("                             Seja Bem vindo                              ");
        Console.WriteLine("=========================================================================\n");

        // Entrada de dados
        Console.WriteLine("Digite o nome do primeiro produto:");
        produto1 = Console.ReadLine();

        Console.WriteLine("\nDigite o valor do produto " + produto1 + ":");
        numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite o nome do segundo produto:");
        produto2 = Console.ReadLine();

        Console.WriteLine("\nDigite o valor do produto " + produto2 + ":");
        numero2 = int.Parse(Console.ReadLine());

        // Menu
        Console.WriteLine("\nDigite o número da operação desejada:");
        Console.WriteLine("1 - Somar o valor dos dois produtos");
        Console.WriteLine("2 - Diferença de valor entre os dois produtos");
        Console.WriteLine("3 - Quociente dos produtos");

        opcao = int.Parse(Console.ReadLine());
        Console.WriteLine();

        // Condição para cálculo
        if (opcao == 1)
        {
            resultado = numero1 + numero2;

            Console.WriteLine("A soma dos valores do produto " + produto1 +
            " e do produto " + produto2 + " é: " + resultado);
        }
        else if (opcao == 2)
        {
            resultado = Math.Abs(numero1 - numero2);

            Console.WriteLine("A diferença entre os valores do produto " +
            produto1 + " e do produto " + produto2 + " é: " + resultado);
        }
        else if (opcao == 3)
        {
            if (numero2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
            else
            {
                resultado = numero1 / numero2;

                Console.WriteLine("O quociente dos valores do produto " +
                produto1 + " e do produto " + produto2 + " é: " + resultado);
            }
        }
        else
        {
            Console.WriteLine("Essa opção não existe.");
        }

        Console.ReadLine();
    }
}