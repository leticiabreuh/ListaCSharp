using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o nome do primeiro jogador:");
        string jogador1 = Console.ReadLine();

        Console.WriteLine("Digite o nome do segundo jogador:");
        string jogador2 = Console.ReadLine();

        // Garantir que os nomes não sejam iguais
        while (jogador1 == jogador2)
        {
            Console.WriteLine("Os nomes não podem ser iguais. Digite outro nome para o segundo jogador:");
            jogador2 = Console.ReadLine();
        }

        int pontos1 = 0;
        int pontos2 = 0;
        Random random = new Random();

        // 3 rodadas
        for (int rodada = 1; rodada <= 3; rodada++)
        {
            int dado1 = random.Next(1, 7); // gera número aleatório de 1 a 6
            int dado2 = random.Next(1, 7);

            Console.WriteLine($"\nRodada {rodada}:");
            Console.WriteLine($"{jogador1} tirou o número {dado1}");
            Console.WriteLine($"{jogador2} tirou o número {dado2}");

            if (dado1 > dado2)
            {
                pontos1++;
                Console.WriteLine($"{jogador1} venceu a rodada {rodada}!");
            }
            else if (dado2 > dado1)
            {
                pontos2++;
                Console.WriteLine($"{jogador2} venceu a rodada {rodada}!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }

            // Mostrar placar
            Console.WriteLine($"Placar: {jogador1}: {pontos1} | {jogador2}: {pontos2}");
        }

        // Resultado final
        Console.WriteLine("\n=== RESULTADO FINAL ===");
        if (pontos1 > pontos2)
            Console.WriteLine($"{jogador1} venceu a partida!");
        else if (pontos2 > pontos1)
            Console.WriteLine($"{jogador2} venceu a partida!");
        else
            Console.WriteLine("A partida terminou empatada!");
    }
}