namespace atv6;

using System;

class Program
{
    static void Main()
    {
        // Leitura dos valores

        Console.WriteLine("Informe o valor de x: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor de y: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor de z: ");
        int z = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe o valor de 1 a 4 para w\n sendo: \n 1 - Média Geométrica \n 2 - Média Ponderada  \n 3 - Média Harmônica  \n 4 - Média aritmética");
        int w = int.Parse(Console.ReadLine());

        int resultado = 0;

        if (w == 1)
        {
            // Média geométrica (aproximação inteira da raiz cúbica)
            int produto = x * y * z;
            resultado = (int)Math.Pow(produto, 1.0 / 3.0);
        }
        else if (w == 2)
        {
            // Média ponderada
            resultado = (x + 2 * y + 3 * z) / 6;
        }
        else if (w == 3)
        {
            // Média harmônica (inteira - truncada)
            resultado = (int)(1.0 / ((1.0 / x) + (1.0 / y) + (1.0 / z)));
        }
        else if (w == 4)
        {
            // Média aritmética
            resultado = (x + y + z) / 3;
        }
        else
        {
            Console.WriteLine("Valor de w inválido.");
            
        }

        Console.WriteLine("Resultado: " + resultado);
    }
}
