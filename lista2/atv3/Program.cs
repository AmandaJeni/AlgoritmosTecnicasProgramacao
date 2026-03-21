using System.Formats.Asn1;

namespace atv3;

/*
Escreva um programa que leia a idade de uma pessoa, o tipo de habilitação que ela possui e o tempo que ela possui carteira de habilitação. 
Verifique e informe se a pessoa possui os requisitos necessários para tirar uma carteira de habilitação do tipo D. Caso ela não possua os requisitos, 
indique em uma mensagem o motivo pelo qual ela não possui permissão.

Requisitos carteira habilitação tipo D:
1. Ter 21 anos completos;
2. Estar habilitado no mínimo há 2 anos na categoria B ou 1 ano na categoria C.
*/

class Program
{
    static void Main(string[] args)
    {

        //Cabeçalho
        Console.WriteLine("===============================================================================");
        Console.WriteLine("                                      Habilitação                              ");
        Console.WriteLine("===============================================================================\n");
        
        //Recebendo a idade
        Console.WriteLine("Informe sua idade: ");
        int idade = int.Parse(Console.ReadLine());

/*
        //Recebendo se ja possui habilitação
        Console.WriteLine("Você ja possui habilitação: ");
        string habilitacao = (Console.ReadLine().ToUpper());

        //especificando os tipos de habilitação
        Console.WriteLine("Especifique qual carteira você possui, sendo Carteira:\n A (motos/triciclos)\n B (carros)\n C (cargas pesadas)\n D (passageiros > 8 lugares)\n E (veículos articulados\n");
        string tHabilitacao = Console.ReadLine().ToUpper();

        //Tempo de Habilitação.
        Console.WriteLine("Informe quantos anos você possui a habilitação: ");
        int tempoHabilitacao = int.Parse(Console.ReadLine());
        */
        
        if(idade >= 21)
        {
            //Recebendo se ja possui habilitação
            Console.WriteLine("Você ja possui habilitação: ");
            string habilitacao = (Console.ReadLine().ToUpper());

            if(habilitacao == "SIM")
            {
                //especificando os tipos de habilitação
                Console.WriteLine("Especifique qual carteira você possui : \n A (motos/triciclos)\n B (carros)\n C (cargas pesadas)\n D (passageiros > 8 lugares)\n E (veículos articulados\n");
                string tHabilitacao = Console.ReadLine().ToUpper();

                //Tempo de Habilitação.
                Console.WriteLine("Informe quantos anos você possui a habilitação: ");
                int tempoHabilitacao = int.Parse(Console.ReadLine());

                if(tHabilitacao == "B" && tempoHabilitacao >= 2)
                {
                    Console.WriteLine("Você possui os requisitos para habilitação tipo D.");     
                }

                else if(tHabilitacao == "C" && tempoHabilitacao >= 1)
                {
                    Console.WriteLine("Você possui os requisitos para habilitação tipo D."); 
                }

                else
                {   
                Console.WriteLine("Você não possui os requisitos mínimos para a habilitação D, pois o tipo de habilitação é diferente de B ou C.");
                }

            }
            else
            {
                Console.WriteLine("Precisa ter habilitação para tirar a habilitação tipo D");
            }
             
            
            
        }
        else
        {
            Console.WriteLine("Você não possui os requisitos para a habilitação D, pois não tem a idade mínima. \n");        
        }
        

        //Fechando o console
        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();
    }
}
