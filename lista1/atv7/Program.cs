namespace atv7;

class Program
{
    static void Main(string[] args)
    {

        // Cabeçalho
        Console.WriteLine("=====================================");
        Console.WriteLine("        Percentual de Votos          ");
        Console.WriteLine("=====================================\n");

        // criando varivel e atribuindo valor
        Console.Write("Digite o total de eleitores: ");
        int tEleitores = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos brancos: ");
        int vBrancos = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos nulos: ");
        int vNulos = int.Parse(Console.ReadLine());

        Console.Write("Digite o número de votos válidos: ");
        int vValidos = int.Parse(Console.ReadLine());

        // Verificação básica
        int sVotos = vBrancos + vNulos + vValidos;
        if (sVotos > tEleitores)
        {
            Console.WriteLine("\nErro: a soma dos votos excede o total de eleitores!");
        }
        else
        {
            // Cálculo 
            double percBrancos = (vBrancos * 100.0) / tEleitores;
            double percNulos = (vNulos * 100.0) / tEleitores;
            double percValidos = (vValidos * 100.0) / tEleitores;

            // Exibindo resultados
            Console.WriteLine($"\nPercentual de votos brancos: {percBrancos:F2}%");
            Console.WriteLine($"Percentual de votos nulos: {percNulos:F2}%");
            Console.WriteLine($"Percentual de votos válidos: {percValidos:F2}%");
        }

        // Fim
        Console.WriteLine("\nPressione Enter para sair...");
        Console.ReadLine();
  
    }
}
