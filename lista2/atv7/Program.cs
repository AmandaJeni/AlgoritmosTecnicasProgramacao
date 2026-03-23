namespace atv7;

/*
    Escreva um programa que receba os dados distancia, peso e urgente 
    do usuário e imprima o preço do frete nas opções Moto, Van, Caminhão. 
    Caso alguma dessas opções sejam inválidas, imprima "invalido"*/

class Program
{
    static void Main(string[] args)
    {
        
       int distancia, peso, urgente;
       double preco;

       Console.WriteLine("Informe a distancia: ");
       distancia = int.Parse(Console.ReadLine());

       Console.WriteLine("Informe o peso da carga: ");
       peso = int.Parse(Console.ReadLine());

       Console.WriteLine("Informe se há urgência  0 = não, 1 = sim: ");
       urgente = int.Parse(Console.ReadLine());


        // ================= MOTO =================
        if (distancia <= 5 && peso <= 20)
        {
            preco = distancia;

            if (urgente == 1)
                preco = preco * 130 / 100; // +30%

            preco = preco * 120 / 100; // +20% seguro

            Console.WriteLine("Moto: " + preco);
        }
        else
        {
            Console.WriteLine("Moto: invalido");
        }

        // ================= VAN =================
        if (peso <= 1000)
        {
            preco = distancia;

            if (urgente == 1)
                preco = preco * 170 / 100; // +70%

            Console.WriteLine("Van: " + preco);
        }
        else
        {
            Console.WriteLine("Van: invalido");
        }

        // ================= CAMINHÃO =================
        preco = distancia;

        if (urgente == 1)
            preco = preco * 200 / 100; // +100%

        Console.WriteLine("Caminhao: " + preco);
    }
}
