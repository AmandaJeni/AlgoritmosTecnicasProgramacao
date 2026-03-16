namespace atv1;

/*
Escreva um programa que leia um número entre 0 e 5 e imprima o valor lido por extenso (ex: “Cinco”), se o número estiver fora dessa faixa imprima “Valor inválido”.
*/

class Program
{
    static void Main(string[] args)
    {
        //cabeçalho
        Console.WriteLine("=======================================================================");
        Console.WriteLine("                     Lendo números de 1 a 5                            ");
        Console.WriteLine("=======================================================================");
        Console.WriteLine();

        //Entrada 
        Console.WriteLine("Digite um número inteiro entre 0 e 5: ");
        int numero = int.Parse(Console.ReadLine());

        //condição
        if((numero >= 0) && (numero <= 5))
        {   
            if(numero == 0)
            {   
                Console.WriteLine("O número digitado escrito por extenso é: Zero");
            }

            if(numero == 1)
            {   
                Console.WriteLine("O número digitado escrito por extenso é: Um");
            }

            if(numero == 2)
            {   
                Console.WriteLine("O número digitado escrito por extenso é: Dois");

            }

            if(numero == 3)
            {   
                Console.WriteLine("O número digitado escrito por extenso é: Três");

            }

            if(numero == 4)
            {   
                Console.WriteLine("O número digitado escrito por extenso é: Quatro");

            }

            if(numero == 5)
            {   
                Console.WriteLine("O número digitado escrito por extenso é: Cinco");

            }

            //Pulando a Linha
            Console.WriteLine();
            
        }

        else
        {
            Console.WriteLine();
            Console.WriteLine("Valor inválido! O número digitado não se encaixa no padrão solicitado.");

        }


        //Fechando o console
        Console.WriteLine("Pressione a tecla Enter para sair.");
        Console.ReadLine();
    }
}
