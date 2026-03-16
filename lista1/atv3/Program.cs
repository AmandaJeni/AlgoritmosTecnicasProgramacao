namespace atv3;

class Program
{
    static void Main(string[] args)
    {

        //variaveis
        double lado, perimetro, area, diagonal;

        Console.WriteLine("Digite o lado do quadrado: ");
        lado = double.Parse(Console.ReadLine());
        Console.WriteLine();

        //Calculo.
        perimetro = 4 * lado;
        area = lado * lado;
        diagonal = lado * Math.Sqrt(2);

        //Imprimindo o resultado.
        Console.WriteLine("O Perímetro do quadrado é igual a: " + perimetro);
        Console.WriteLine();
        Console.WriteLine("A Área do quadrado é igual a: " + area);
        Console.WriteLine();
        Console.WriteLine("A diagonal do quadrado é igual a: " + diagonal);

        //Fechar o console.
        Console.ReadLine();
    }
}
