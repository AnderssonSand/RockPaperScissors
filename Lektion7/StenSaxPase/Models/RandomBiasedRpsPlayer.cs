using StenSaxPase.Enums;
using StenSaxPase.Interfaces;

namespace Lektion7.StenSaxPase.Models;

public class RandomBiasedRpsPlayer : IRpsPlayer
{
    private Random _random = new();

    public RpsMove GenerateRpsMove()
    {
        int choice = _random.Next(1, 101);
        if (choice > 80)
            return RpsMove.Scissor;
        else if (choice > 30)
            return RpsMove.Paper;
        else
            return RpsMove.Rock;
    }

    public void RegisterOutcome(GameOutcome gameOutcome)
    {
    }
}