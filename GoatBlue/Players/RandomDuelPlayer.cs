namespace GoatBlue.Players;

/// <summary>
/// Represents a player for a two-game with random events.
/// player.
/// </summary>
public readonly struct RandomDuelPlayer(byte id) : IPlayer
{
    public static readonly RandomDuelPlayer One = new(1);
    public static readonly RandomDuelPlayer Two = new(2);
    public static readonly RandomDuelPlayer Game = new(3);

    readonly byte id = id;
    readonly bool stochastic = id == 3;
    
    public byte Id => id;
    public bool IsStochastic => stochastic;
}