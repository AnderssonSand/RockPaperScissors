using StenSaxPase.Enums;
using StenSaxPase.Interfaces;
namespace Lektion7.StenSaxPase.Models;

public class MirrorRpsPlayer : IRpsPlayer
{
    private RpsMove _opponentLastMove = RpsMove.Rock;
    private RpsMove _ownLastMove = RpsMove.Paper;

    public RpsMove GenerateRpsMove()
    {
        _ownLastMove = _opponentLastMove;
        return _opponentLastMove;
    }

    public void RegisterOutcome(GameOutcome gameOutcome)
    {
        _opponentLastMove = (gameOutcome.RpsMove1 != _ownLastMove) ? gameOutcome.RpsMove1 : gameOutcome.RpsMove2;
    }
}