namespace GoatBlue;

/// <summary>
/// Represents a move associated a type
/// P for player.
/// </summary>
public interface IMove<P>
{
    /// <summary>
    /// Get the entity that can do this move.
    /// </summary>
    P Player { get; }
}