namespace atv14;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a altura (ex: 1.70): ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Digite o sexo (M/F): ");
        char sexo = char.ToUpper(Console.ReadLine()[0]);

        double pesoIdeal = (sexo == 'M') 
            ? (72.7 * altura) - 58 
            : (62.1 * altura) - 44.7;

        Console.WriteLine("Peso ideal: " + pesoIdeal.ToString("F2") + " kg");
    }
}