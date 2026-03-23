namespace atv12;

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===========================");
        Console.WriteLine("===          MENU       ===");
        Console.WriteLine("1 - Centímetros para Metros");
        Console.WriteLine("2 - Metros para Centímetros");
        Console.WriteLine("3 - Milímetros para Metros ");
        Console.WriteLine("4 - Metros para Milímetros ");
        Console.WriteLine("===========================");

        Console.Write("\nEscolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        double valor, resultado;

        switch (opcao)
        {
            case 1:
                Console.Write("Digite o valor em centímetros: ");
                valor = double.Parse(Console.ReadLine());
                resultado = valor / 100;
                Console.WriteLine("Resultado: " + resultado + " metros");
                break;

            case 2:
                Console.Write("Digite o valor em metros: ");
                valor = double.Parse(Console.ReadLine());
                resultado = valor * 100;
                Console.WriteLine("Resultado: " + resultado + " centímetros");
                break;

            case 3:
                Console.Write("Digite o valor em milímetros: ");
                valor = double.Parse(Console.ReadLine());
                resultado = valor / 1000;
                Console.WriteLine("Resultado: " + resultado + " metros");
                break;

            case 4:
                Console.Write("Digite o valor em metros: ");
                valor = double.Parse(Console.ReadLine());
                resultado = valor * 1000;
                Console.WriteLine("Resultado: " + resultado + " milímetros");
                break;

            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}