using StenSaxPase.Enums;
using StenSaxPase.Interfaces;

namespace Lektion7.StenSaxPase.Models;

public class RandomRpsPlayer : IRpsPlayer
{
    private Random _random = new();

    public RpsMove GenerateRpsMove()
    {
        RpsMove choice = (RpsMove)_random.Next(0, 3);
        return choice;
    }

    public void RegisterOutcome(GameOutcome gameOutcome)
    {
    }
}


   
