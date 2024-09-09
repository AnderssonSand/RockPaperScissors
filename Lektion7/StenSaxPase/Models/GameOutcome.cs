using StenSaxPase.Enums;
namespace Lektion7.StenSaxPase.Models;

public class GameOutcome(RpsMove rpsMove1, RpsMove rpsMove2)
{
    public RpsMove RpsMove1 = rpsMove1;
    public RpsMove RpsMove2 = rpsMove2;

    public RpsMove GetWinningMove()
    {
        throw new NotImplementedException();
    }
}