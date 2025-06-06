using System.Collections.Generic;

namespace GoatBlue;

/// <summary>
/// A interface for all game state that is
/// associated with a type for represents
/// a move and a type for represents a
/// player.
/// </summary>
public interface IState<M, P>
    where P : IPlayer
    where M : IMove
{
    /// <summary>
    /// Get the entity that can move in this state.
    /// </summary>
    P Player { get; }

    /// <summary>
    /// Do a move.
    /// </summary>
    void Do(M move);

    /// <summary>
    /// Undo a move.
    /// </summary>
    void Undo(M move);

    /// <summary>
    /// Create a copy from this state.
    /// </summary>
    IState<M, P> Copy();

    /// <summary>
    /// Evaluate the probability for the
    /// current player win the game.
    /// </summary>
    float Evaluate();
    
    /// <summary>
    /// Get a enumerator of all avaliable moves.
    /// </summary>
    IEnumerable<IMove> GetMoves();
}