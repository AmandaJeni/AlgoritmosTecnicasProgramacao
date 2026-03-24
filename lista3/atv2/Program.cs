namespace atv2;

class Program
{

/*  Escreva um programa que leia dois números inteiros ímpares X e Y, e imprima os números ímpares de X até Y (inclusive). 
    Caso o usuário informe valores inválidos (X e Y não serem ímpares, OU X ser maior que Y) o programa deverá imprimir uma 
    mensagem de erro (Erro! Valores Inválidos). 
    Exemplo: x = 3, y = 11
    Impressão: 3, 5, 7, 9, 11

*/
    static void Main(string[] args)
    {
        int x, y;

        Console.WriteLine("=================================================");
        Console.WriteLine("       Imprimindo valores impares de X a Y       ");
        Console.WriteLine("=================================================\n");

        Console.WriteLine("Observação o valor de X deverá ser menor que o valor de Y.\n");

        Console.WriteLine("Informe um número ímpar para x: ");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe um número ímpar para y: ");
        y = int.Parse(Console.ReadLine());

        if(x <= y && x % 2 == 1 && y % 2 == 1)
        {
            while(x <= y)
            {
                Console.WriteLine(x);
                x += 2; // x = x + 2;
                
            }
            
        }
        else
        {
           Console.WriteLine("Erro! Valores Inválidos");
        }


    }
}
