using System;

/* Escreva um programa que pergunte qual o tempo transcorrido em um cronômetro em horas, 
minutos e segundos e transforme (e mostre) todo este tempo em segundos. */



internal class Program
{

    static void Main(string[] args)
    {

        int horas, minutos, segundos, result;

        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine("            Transformando horas e minutos em segundos             ");
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine();

        Console.WriteLine("Informe as horas do tempo decorrido em um cronômetro: ");
        horas = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Informe os minutos do tempo decorrido em um cronômetro: ");
        minutos = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("Informe os segundos do tempo decorrido em um cronômetro: ");
        segundos = int.Parse(Console.ReadLine());
        Console.WriteLine();

        //calculo
        result = (horas * 3600) + (minutos * 60) + segundos;


        //imprimindo o resultado
        Console.WriteLine("O total de segundos decorrido no cronometro é igual a: " + result);


        Console.ReadLine();

    }
}