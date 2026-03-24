using System.Diagnostics.Tracing;

namespace atv3;

class Program
{
    static void Main(string[] args)
    {

        /*Escreva um programa que leia do teclado 31 valores reais correspondentes ao índice pluviométrico diário da região da Pampulha durante o mês de janeiro. 
        O programa deve determinar e imprimir o índice pluviométrico médio, o índice pluviométrico máximo e o dia que ele ocorreu.  
        Obs: O índice pluviométrico refere-se à quantidade de chuva por metro quadrado em determinado local.*/
       
       int i = 1, diaMaximo = 1;
       double media, maximo = 0, soma = 0, chuva;
    
    
       while(i <= 31)
       {
            Console.WriteLine("Informe o indíce de chuva na região da Pampulha no dia " + i + ": ");

            chuva = double.Parse(Console.ReadLine());
            soma += chuva; // soma = soma + chuva;

            if(i == 1)
            {
                maximo = chuva;
            }
            else if(chuva > maximo)
            {
                maximo = chuva;
                diaMaximo = i;
            }

           //incrementando os dias.
           i++;

       }
       
       //calculo mensal.
       media = soma / 31;

       Console.WriteLine("Índice Médio: " + media);
       Console.WriteLine("Índice Máximo: " + maximo);
       Console.WriteLine("Ocorreu no dia: " + diaMaximo);

    }
}
