using Lektion7.StenSaxPase.Models;
using StenSaxPase.Enums;
using StenSaxPase.Interfaces;

IRpsPlayer player1 = new RandomRpsPlayer();
IRpsPlayer player2 = new RandomBiasedRpsPlayer();

List<IRpsPlayer> rpsPlayers = [player1, player2];

for (int i = 1; i <= 10; i++)
{
    RpsMove move1 = player1.GenerateRpsMove();
    RpsMove move2 = player2.GenerateRpsMove();

    GameOutcome gameOutcome = new GameOutcome(move1, move2);

    player1.RegisterOutcome(gameOutcome);
    player2.RegisterOutcome(gameOutcome);

    Console.WriteLine($"----- Spel {i} -----");
    Console.WriteLine($"Spelare 1 gjorde: {move1}");
    Console.WriteLine($"Spelare 2 gjorde: {move2}");
}

