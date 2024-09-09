using StenSaxPase.Enums;
using Lektion7.StenSaxPase.Models;

namespace StenSaxPase.Interfaces;

public interface IRpsPlayer {
    RpsMove GenerateRpsMove();
    void RegisterOutcome(GameOutcome gameOutcome);
}