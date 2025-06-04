namespace GoatBlue.Players;

/// <summary>
/// Represents a player for a two-game
/// player.
/// </summary>
public readonly struct DuelPlayer(byte id) : IPlayer
{
    public static readonly DuelPlayer One = new(1);
    public static readonly DuelPlayer Two = new(2);

    readonly byte id = id;
    public byte Id => id;
    public bool IsStochastic => false;
}