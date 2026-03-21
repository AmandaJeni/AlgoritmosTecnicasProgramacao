namespace atv4;

/*Faça um programa que leia um número e informe se ele é divisível por 3 e por 5 (Exemplo: 15 é divisível por 3 e por 5)*/

class Program
{
    static void Main(string[] args)
    {   
        int numero;

        Console.WriteLine("Digite um número inteiro: ");
        numero = int.Parse(Console.ReadLine());

        if(numero % 3 == 0 && numero % 5 == 0)
        {
            //Console.Clear();
            Console.WriteLine("O número " + numero + " é divisível por 3 e por 5.");
        }
        else
        {
            Console.WriteLine("O número digitado não é divisível por 3 e por 5.");
        }


        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();
    }
}
