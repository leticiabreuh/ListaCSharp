using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Quantos números deseja digitar? (3 a 10)");
        int quantidade = int.Parse(Console.ReadLine());

        if (quantidade < 3 || quantidade > 10)
        {
            Console.WriteLine("Quantidade inválida!");
            return;
        }

        //  tipo      nome da lista
        List<double> numeros = new List<double>();

        // FOR → para ler os números
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine("Digite um número:");
            double valor = double.Parse(Console.ReadLine());
            numeros.Add(valor); // adiona ao final da lista
        }

        double soma = 0;

        // FOREACH → para somar
        //ele serve para percorrer todos itens da lista, como um for
        //       tipo   num recece da lista 
        foreach (double num in numeros)
        //              nome   lista
        {
            soma += num;
        }

        double media = soma / numeros.Count;

        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Média: " + media);
    }
}