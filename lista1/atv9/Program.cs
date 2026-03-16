namespace atv9;

class Program
{
    static void Main(string[] args)
    {
        // Entrada de dados
        Console.Write("Digite o valor da variável varA: ");
        double varA = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor da variável varB: ");
        double varB = double.Parse(Console.ReadLine());

        // Exibindo valores antes da troca
        Console.WriteLine($"\nValores antes da troca: varA = {varA}, varB = {varB}");

        // Troca de valores usando variável temporária
        double temp = varA;
        varA = varB;
        varB = temp;

        // resultado
        Console.WriteLine($"Valores após a troca: varA = {varA}, varB = {varB}");

       
        Console.ReadLine();
    }
}
