namespace atv15;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe um ano: ");
        int ano = int.Parse(Console.ReadLine());

        string resultado = (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
            ? "Ano bissexto"
            : "Não é ano bissexto";

        Console.WriteLine(resultado);
    }
}