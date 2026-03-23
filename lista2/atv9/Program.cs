namespace atv9;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Informe a Empresa: ");
        string empresa = Console.ReadLine();

        Console.Write("Informe o Funcionário: ");
        string nome = Console.ReadLine();

        Console.Write("Informe o Cargo: ");
        string cargo = Console.ReadLine();

        Console.Write("Informe o Salário bruto: ");
        double salario = double.Parse(Console.ReadLine());

        double inss = 0;

        // Cálculo com IF
        if (salario <= 1412)
            inss = salario * 0.075;

        if (salario > 1412 && salario <= 2666.68)
            inss = salario * 0.09;

        if (salario > 2666.68 && salario <= 4000.03)
            inss = salario * 0.12;

        if (salario > 4000.03)
            inss = salario * 0.14;

        double liquido = salario - inss;

        Console.WriteLine("\n--- Resultado ---");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Salário Bruto: " + salario);
        Console.WriteLine("Desconto INSS: " + inss);
        Console.WriteLine("Salário Líquido: " + liquido);
    }
}