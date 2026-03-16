namespace atv8;

class Program
{
    static void Main(string[] args)
    {
        // Valor do salário mínimo
        double salarioMinimo = 1516.00;

        // Cabeçalho
        Console.WriteLine("===================================");
        Console.WriteLine("         Salários mínimos          ");
        Console.WriteLine("===================================\n");

        // Entrada de dados
        Console.Write("Digite o valor do seu salário (R$): ");
        double salarioPessoa = double.Parse(Console.ReadLine());

        // Cálculo
        double quantidadeSalariosMinimos = salarioPessoa / salarioMinimo;

        // Exibindo resultado
        Console.WriteLine($"\nEssa pessoa ganha {quantidadeSalariosMinimos:F2} salários mínimos.");

        // Fim
        Console.WriteLine("\nPressione Enter para sair...");
        Console.ReadLine();
    }
}
