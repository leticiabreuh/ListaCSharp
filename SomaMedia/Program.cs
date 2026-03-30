using System;

class Program
{
    static void Main()

    {
        Console.WriteLine("Quantos números deseja digitar? (3 a 10)");
        int quantidade = int.Parse(Console.ReadLine());

        if(quantidade < 3 || quantidade > 10){
            Console.WriteLine("Qunatidade invália!");
            return;
        }

        int soma = 0;
        for (int i = 1; i <= quantidade; i++)
        {
            Console.WriteLine($"Digite o {i}º valor: ");
            int valor = int.Parse(Console.ReadLine());
            soma += valor;
        }
        double media = (double)soma / quantidade;

         Console.WriteLine("Soma: " + soma);
         Console.WriteLine("Média: " + media);
    }
}