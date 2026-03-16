namespace atv10;

class Program
{
    static void Main(string[] args)
    {
        // Cabeçalho
        Console.WriteLine("===================================");
        Console.WriteLine("       Cálculo de uma Fração");
        Console.WriteLine("===================================\n");

        
        Console.Write("Digite o numerador: ");
        double numerador = double.Parse(Console.ReadLine());

        Console.Write("Digite o denominador: ");
        double denominador = double.Parse(Console.ReadLine());

       
        if (denominador == 0)
        {
            Console.WriteLine("\nErro: o denominador não pode ser zero!");
        }
        else
        {
            // Cálculo
            double resultado = numerador / denominador;

            // Exibindo o resultado
            Console.WriteLine($"\nO valor da fração é: {resultado:F2}");
        }

        
        Console.ReadLine();
    }
}
