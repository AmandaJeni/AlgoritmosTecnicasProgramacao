namespace atv13;

using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma letra: ");
        char letra = char.ToLower(Console.ReadLine()[0]);

        switch (letra)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Vogal");
                break;

            default:
                Console.WriteLine("Consoante");
                break;
        }
    }
}