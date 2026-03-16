namespace atv13;

class Program
{
    static void Main(string[] args)
    {
         // Cabeçalho
        Console.WriteLine("=======================================");
        Console.WriteLine("   Cálculo de valor de energia elétrica");
        Console.WriteLine("=======================================\n");

        Console.Write("Digite o valor do salário mínimo (R$): ");
        double salarioMinimo = double.Parse(Console.ReadLine());

        Console.Write("Digite a quantidade de kilowatt consumida: ");
        double kwConsumido = double.Parse(Console.ReadLine());

        // Cálculo
        double valorKwh = (salarioMinimo / 10) / 100; // 1/10 do salário mínimo dividido por 100 kWh
        double valorTotal = kwConsumido * valorKwh;

        //resultado
        Console.WriteLine($"\n(a) Valor de cada kilowatt: R$ {valorKwh:F2}");
        Console.WriteLine($"(b) Valor total a ser pago: R$ {valorTotal:F2}");

        // Fim
        Console.ReadLine();
    }
}
