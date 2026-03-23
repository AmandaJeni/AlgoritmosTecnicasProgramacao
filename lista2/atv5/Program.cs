namespace atv5;

class Program
{
    static void Main(string[] args)
    {
        int idade;
        string nome;

        Console.WriteLine("Informe o seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Informe a sua idade: ");
        idade = int.Parse(Console.ReadLine());

        if(idade >= 5 && idade <= 7)
        {
               Console.WriteLine("A sua categoria como nadador é Infantil A.");
        }
        
        else if(idade >= 8 && idade <= 10)
        {
            Console.WriteLine("A sua categoria como nadador é Infantil B.");
        }

         else if(idade >= 11 && idade <= 13)
        {
            Console.WriteLine("A sua categoria como nadador é Juvenil A.");
        }

         else if(idade >= 14 && idade <= 17)
        {
            Console.WriteLine("A sua categoria como nadador é Juvenil B.");
        }

        else
        {
            Console.WriteLine("A sua categoria como nadador é Sênior.");
        }

        Console.WriteLine("Pressione Enter para sair");
        Console.ReadLine();
    }

}
