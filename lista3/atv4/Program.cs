namespace atv4;

class Program
{
    static void Main(string[] args)
    {
    /*Escreva um programa que leia um número inteiro n. Em seguida, leia a idade de n pessoas, calcule e imprima (a) a quantidade 
    de pessoas em cada faixa etária e (b) a porcentagem de cada faixa etária em relação ao total de pessoas.
    Faixas etárias:
    •	1 a 15 anos  •	16 a 30 anos •	31 a 45 anos •	46 a 60 anos•	≥ 61 anos */

        int i = 1, idade, pessoas;
        int faixa1 = 0, faixa2 = 0, faixa3 = 0, faixa4 = 0, faixa5 = 0;

        Console.WriteLine("Informe a quantidade de pessoas: ");
        pessoas = int.Parse(Console.ReadLine());

        while(i <= pessoas)
        {
            Console.WriteLine("Informe a idade da " + i + "ª pessoa: ");
            idade = int.Parse(Console.ReadLine());

            //1 a 15 anos
            if(idade >= 1 && idade <= 15 )
            {
                faixa1++;
            }

            //16 a 30 anos
            else if(idade >= 16 && idade <= 30)
            {
                faixa2++;
                
            }

            //31 a 45 anos
            else if(idade >= 31 && idade <= 45)
            {
                faixa3++;
            }

            //46 a 60 anos
            else if(idade >= 46 && idade <= 60)
            {
                faixa4++;
            }

            //≥ 61 anos
            else
            {
                faixa5++;
            }

            //incrementando.
            i++;
        }

            Console.WriteLine("Quantidade de Pessoas na Faixa 1: " + faixa1);
            Console.WriteLine("Quantidade de Pessoas na Faixa 2: " + faixa2);
            Console.WriteLine("Quantidade de Pessoas na Faixa 3: " + faixa3);
            Console.WriteLine("Quantidade de Pessoas na Faixa 4: " + faixa4);
            Console.WriteLine("Quantidade de Pessoas na Faixa 5: " + faixa5);

            Console.WriteLine("Porcentagem de pessoas da Faixa etaria 1: " + (faixa1 * 100 / pessoas));
            Console.WriteLine("Porcentagem de pessoas da Faixa etaria 2: " + (faixa2 * 100 / pessoas));
            Console.WriteLine("Porcentagem de pessoas da Faixa etaria 3: " + (faixa3 * 100 / pessoas));
            Console.WriteLine("Porcentagem de pessoas da Faixa etaria 4: " + (faixa4 * 100 / pessoas));
            Console.WriteLine("Porcentagem de pessoas da Faixa etaria 5: " + (faixa5 * 100 / pessoas));



    }
}
