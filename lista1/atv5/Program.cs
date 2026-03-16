namespace atv5;

class Program
{
    static void Main(string[] args)
    {

        //variaveis
        double f, c;

          // Cabeçalho
        Console.WriteLine("============================================================");
        Console.WriteLine("              Conversão Fahrenheit → Celsius                ");
        Console.WriteLine("==========================================================\n");
        // \n é usado para pular para a proxima linha em ver de usar o console.writeline();

        // Atribuindo valor
        Console.Write("Digite a temperatura em Fahrenheit: ");
        f = double.Parse(Console.ReadLine());

        // Conversão
        c = (5 * (f - 32)) / 9;

        // Impressao do resultado
        Console.WriteLine($"\nTemperatura em Celsius: {c:F2} °C"); //F2 é usado para limitar casas decimais.

        // Finaliza
        Console.WriteLine("\nPressione Enter para sair...");
        Console.ReadLine();
    }
}
