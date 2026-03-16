namespace atv12;

class Program
{
    static void Main(string[] args)
    {
         // Cabeçalho
        Console.WriteLine("====================================");
        Console.WriteLine("   Inversão de número de 3 dígitos");
        Console.WriteLine("====================================\n");

        // Entrada de dados
        Console.Write("Digite um número inteiro de 3 dígitos: ");
        int numero = int.Parse(Console.ReadLine());

        // Verifica se o número tem 3 dígitos
        if (numero < 100 || numero > 999)
        {
            Console.WriteLine("Erro: o número deve ter exatamente 3 dígitos.");
        }
        else
        {
            // Separando 
            int centena = numero / 100;           // divisão inteira
            int dezena = (numero / 10) % 10;      // divisão por 10, resto 10
            int unidade = numero % 10;            // resto da divisão por 10

            
            int numeroInvertido = unidade * 100 + dezena * 10 + centena;

            // resultado
            Console.WriteLine($"\nNúmero invertido: {numeroInvertido}");
        }

        Console.ReadLine();
    }
}
