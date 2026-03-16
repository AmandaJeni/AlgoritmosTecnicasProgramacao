namespace atv2;

// Escreva um programa que leia 3 idades. Imprima a menor e a maior idade.

class Program
{
    static void Main(string[] args)
    {
        //Cabeçalho
        Console.WriteLine("============================================================================");
        Console.WriteLine("                                 IDADES                                     ");
        Console.WriteLine("============================================================================\n");

        //Entrada de dados
        Console.WriteLine("Informe a primeira idade: ");
        int idade1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a segunda idade: ");
        int idade2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Informe a terceira idade: ");
        int idade3 = int.Parse(Console.ReadLine());

        //declarando variaveis
        int maiorIdade, menorIdade;

        //idade 1 sendo a menor e a idade 2 sendo a maior
        if((idade1 < idade2 && idade1 < idade3) && (idade2 > idade1 && idade2 > idade3))
        {   
            //recebendo o valor
            menorIdade = idade1;
            maiorIdade = idade2;

            //Imprimindo o resultado.
            Console.WriteLine("A menor idade informada é " + menorIdade + " e a maior idade é " + maiorIdade + ".");

        }
         //idade 1 sendo a menor e a idade 3 sendo a maior
        if((idade1 < idade2 && idade1 < idade3) && (idade3 > idade1 && idade3 > idade2))
        {   
            //recebendo o valor
            menorIdade = idade1;
            maiorIdade = idade3;

            //Imprimindo o resultado.
            Console.WriteLine("A menor idade informada é " + menorIdade + " e a maior idade é " + maiorIdade + ".");

        }

        //idade 2 sendo a menor e a idade 1 sendo a maior
        if((idade2 < idade1 && idade2 < idade3) && (idade1 > idade2 && idade1 > idade3))
        {   
            //recebendo o valor
            menorIdade = idade2;
            maiorIdade = idade1;

            //Imprimindo o resultado.
            Console.WriteLine("A menor idade informada é " + menorIdade + " e a maior idade é " + maiorIdade + ".");

        }

        //idade 2 sendo a menor e a idade 3 sendo a maior
        if((idade2 < idade1 && idade2 < idade3) && (idade3 > idade2 && idade3 > idade1))
        {   
            //recebendo o valor
            menorIdade = idade2;
            maiorIdade = idade3;

            //Imprimindo o resultado.
            Console.WriteLine("A menor idade informada é " + menorIdade + " e a maior idade é " + maiorIdade + ".");

        }
        
        //idade 3 sendo a menor e a idade 1 sendo a maior
        if((idade3 < idade1 && idade3 < idade2) && (idade1 > idade2 && idade1 > idade3))
        {   
            //recebendo o valor
            menorIdade = idade3;
            maiorIdade = idade1;

            //Imprimindo o resultado.
            Console.WriteLine("A menor idade informada é " + menorIdade + " e a maior idade é " + maiorIdade + ".");

        }

        //idade 3 sendo a menor e a idade 2 sendo a maior
        if((idade3 < idade1 && idade3 < idade2) && (idade2 > idade3 && idade2 > idade1))
        {   
            //recebendo o valor
            menorIdade = idade3;
            maiorIdade = idade2;

            //Imprimindo o resultado.
            Console.WriteLine("A menor idade informada é " + menorIdade + " e a maior idade é " + maiorIdade + ".");

        }

        else if (idade1 == idade2 && idade1 == idade3)
        { 
            Console.WriteLine("As idades digitadas são iguais.");
        }


        Console.WriteLine();

        //Fechando o console
        Console.WriteLine("Pressione a tecla Enter para sair.");
        Console.ReadLine();

    }
}
