namespace atv11;

class Program
{
    static void Main(string[] args)
    {
        // Cabeçalho
        Console.WriteLine("===================================");
        Console.WriteLine("       Cálculo de Gorjeta");
        Console.WriteLine("===================================\n");

      
        Console.Write("Digite o valor gasto no restaurante (R$): ");
        double despesa = double.Parse(Console.ReadLine());

        Console.Write("Digite o percentual de gorjeta (%): ");
        double percentualGorjeta = double.Parse(Console.ReadLine());

        // Cálculo 
        double valorGorjeta = despesa * percentualGorjeta / 100;
        double total = despesa + valorGorjeta;

        // resultado
        Console.WriteLine($"\nValor da gorjeta: R$ {valorGorjeta:F2}");
        Console.WriteLine($"Valor total a pagar: R$ {total:F2}");

        Console.ReadLine();
    }
}
