using System;

class Program
{
    static void Main()
    {
        // Selecionar quantidade de rodadas
        Console.WriteLine("Quantas rodadas deseja jogar? (1 a 5)");
        int totalRodadas = int.Parse(Console.ReadLine());

        while (totalRodadas < 1 || totalRodadas > 5)
        {
            Console.WriteLine("Quantidade inválida! Digite um número entre 1 e 5:");
            totalRodadas = int.Parse(Console.ReadLine());
        }

        // 2️ Nomes dos jogadores
        Console.WriteLine("Digite o nome do primeiro jogador:");
        string jogador1 = Console.ReadLine();

        Console.WriteLine("Digite o nome do segundo jogador:");
        string jogador2 = Console.ReadLine();

        while (jogador1 == jogador2)
        {
            Console.WriteLine("Os nomes não podem ser iguais. Digite outro nome para o segundo jogador:");
            jogador2 = Console.ReadLine();
        }

        int pontos1 = 0;
        int pontos2 = 0;
        Random random = new Random();
        int rodada = 1;

        // 3 Loop principal de rodadas
        while (rodada <= totalRodadas || pontos1 == pontos2)
        {
            int dado1 = random.Next(1, 7);
            int dado2 = random.Next(1, 7);

            Console.WriteLine($"\nRodada {rodada}:");
            Console.WriteLine($"{jogador1} tirou {dado1}");
            Console.WriteLine($"{jogador2} tirou {dado2}");

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

            Console.WriteLine($"Placar: {jogador1}: {pontos1} | {jogador2}: {pontos2}");
            rodada++;

            // Se todas as rodadas foram jogadas e há empate, continuar jogando
            if (rodada > totalRodadas && pontos1 == pontos2)
            {
                Console.WriteLine("\nEmpate após todas as rodadas! Jogadas extras para desempate...");
            }
        }

        // Resultado final
        Console.WriteLine("\n=== RESULTADO FINAL ===");
        if (pontos1 > pontos2)
            Console.WriteLine($"{jogador1} venceu a partida!");
        else
            Console.WriteLine($"{jogador2} venceu a partida!");
    }
}