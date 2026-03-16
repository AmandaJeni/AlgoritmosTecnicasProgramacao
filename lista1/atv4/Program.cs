namespace atv4;

class Program
{
    static void Main(string[] args)
    {
       
       //variaveis 
       double bRetangulo, aRetangulo, perimetro, area, diagonal;
        // Cabeçalho
        Console.WriteLine("===========================================");
        Console.WriteLine("      Cálculo de Perímetro, Área e Diagonal");
        Console.WriteLine("===========================================\n");

        // Entrada de dados
        Console.Write("Digite a base do retângulo: ");
        bRetangulo = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        aRetangulo = double.Parse(Console.ReadLine());

        // Cálculos
        perimetro = 2 * (bRetangulo + aRetangulo);
        area = bRetangulo * aRetangulo;
        diagonal = Math.Sqrt(Math.Pow(bRetangulo, 2) + Math.Pow(aRetangulo, 2));

        // Imprimi  resultados
        Console.WriteLine($"\nPerímetro: {perimetro}");
        Console.WriteLine($"Área: {area}");
        Console.WriteLine($"Diagonal: {diagonal:F2}"); // :F2 → limita a 2 casas decimais

        // Finaliza 
        Console.WriteLine("Pressione Enter para sair...");
        Console.ReadLine();

    }
}
