namespace atv1;

class Program
{

    //Escreva um programa que imprima uma contagem regressiva de 10 até 1 e depois exiba "Feliz Ano Novo!".
    static void Main(string[] args)
    {
        int i = 10;

        while(i > 0 ){

            Console.WriteLine(i);
            i--;
        }
        
        Console.WriteLine("Feliz Ano Novo!");
        Console.ReadLine();
    }
}
