namespace atv10;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um número de 1 a 7: ");
        int numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;

            case 2:
                Console.WriteLine("Segunda-feira");
                break;

            case 3:
                Console.WriteLine("Terça-feira");
                break;

            case 4:
                Console.WriteLine("Quarta-feira");
                break;

            case 5:
                Console.WriteLine("Quinta-feira");
                break;

            case 6:
                Console.WriteLine("Sexta-feira");
                break;

            case 7:
                Console.WriteLine("Sábado");
                break;

            default:
                Console.WriteLine("Dia inválido");
                break;
        }
    }
}