using System.Collections.Generic;

namespace GoatBlue;

/// <summary>
/// A interface for all game state that is
/// associated with a type for represents a move.
/// </summary>
public interface IState<M>
{
    /// <summary>
    /// Get the id of the current player.
    /// </summary>
    byte GetCurrentPlayer();

    /// <summary>
    /// Get if this state is a stochastic state.
    /// </summary>
    bool IsStochastic();

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
    IState<M> Copy();

    /// <summary>
    /// Evaluate the probability for the
    /// current player win the game.
    /// </summary>
    float Evaluate();
    
    /// <summary>
    /// Get a enumerator of all avaliable moves.
    /// </summary>
    IEnumerable<M> GetMoves();
}