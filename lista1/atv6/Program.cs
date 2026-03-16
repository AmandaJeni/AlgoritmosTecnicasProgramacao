namespace atv6;

class Program
{
    static void Main(string[] args)
    {
        //variaveis
        double num1, num2, num3, num4;

        // Cabeçalho
        Console.WriteLine("======================================");
        Console.WriteLine("       Média Ponderada de 4 números");
        Console.WriteLine("======================================\n");

        // atribuindo valores
        Console.Write("Digite o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        num3 = double.Parse(Console.ReadLine());

        Console.Write("Digite o quarto número: ");
        num4 = double.Parse(Console.ReadLine());

        // Pesos
        int peso1 = 2, peso2 = 1, peso3 = 3, peso4 = 4;

        // Cálculo
        double mediaPonderada = (num1 * peso1 + num2 * peso2 + num3 * peso3 + num4 * peso4)
                                / (peso1 + peso2 + peso3 + peso4);

        // Exibindo o resultado
        Console.WriteLine($"\n A média ponderada é: {mediaPonderada:F2}");

        // Fim
        Console.WriteLine("\n Pressione Enter para sair...");
        Console.ReadLine();

    }
}
