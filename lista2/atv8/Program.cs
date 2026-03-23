namespace atv8;

class Program
{
    static void Main(string[] args)
    {
       double qlitros,faturaTotal;

       /*
        Formula: litros x tarifa
        se litros 0 - 75 tarifa de agua 2,11 e esgoto 1,56 
        se litros 75 - 150 tarifa de agua 4,496 e esgoto 3,327 
        se litros 150 - 225 tarifa de agua 6,968 e esgoto 5,156
        se litros maior que 225 tarifa de agua 9,512 e esgoto 7,039  
        */
        Console.WriteLine("Informe a quantidade de litros: ");
        qlitros = double.Parse(Console.ReadLine());

        double consumo =  qlitros / 1000.0;

        double agua = 305.55;   // taxa fixa
        double esgoto = 226.05; // taxa fixa

        // Faixa 1: 0 - 75
        if (consumo > 0)
        {
            double faixa = consumo;

            if (consumo > 75)
                faixa = 75;

            agua += faixa * 2.11;
            esgoto += faixa * 1.56;
        }

        // Faixa 2: 75 - 150
        if (consumo > 75)
        {
            double faixa = consumo - 75;

            if (faixa > 75)
                faixa = 75;

            agua += faixa * 4.496;
            esgoto += faixa * 3.327;
        }

        // Faixa 3: 150 - 225
        if (consumo > 150)
        {
            double faixa = consumo - 150;

            if (faixa > 75)
                faixa = 75;

            agua += faixa * 6.968;
            esgoto += faixa * 5.156;
        }

        // Faixa 4: acima de 225
        if (consumo > 225)
        {
            double faixa = consumo - 225;

            agua += faixa * 9.512;
            esgoto += faixa * 7.039;
        }

        faturaTotal = agua + esgoto;

        Console.WriteLine("Fatura total: " + faturaTotal.ToString("F2"));


        Console.WriteLine("Pressione Enter para sair.");
        Console.ReadLine();

    }
}
