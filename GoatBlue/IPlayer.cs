namespace GoatBlue;

/// <summary>
/// Base type for represent a player that 
/// interacts with the game, thats include 
/// the game itself and stochastic events.
/// </summary>
public interface IPlayer
{
    /// <summary>
    /// Represents a idenitification for the player.
    /// </summary>
    byte Id { get; }

    /// <summary>
    /// Get if this entity is a stochastic entity.
    /// </summary>
    bool IsStochastic { get; }
}