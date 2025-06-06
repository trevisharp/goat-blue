namespace GoatBlue;

/// <summary>
/// A engine that plays the best move of
/// a game based on a State, Player and Move type.
/// </summary>
public interface IEngine<S, M, P>
    where S : IState<M, P>
    where M : IMove
    where P : IPlayer
{
    /// <summary>
    /// Avaliate a state using a tree approuch
    /// for a deep analisys.
    /// </summary>
    float DeepEvaluate(S state);

    /// <summary>
    /// Pick the best move for current player. 
    /// </summary>
    M PickBest(S state);
}