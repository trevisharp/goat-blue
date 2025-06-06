using System;

namespace GoatBlue.Engines;

/// <summary>
/// A Engine that applies MiniMax algorithm.
/// </summary>
public class MiniMaxEngine<S, M, P> : IEngine<S, M, P>
    where S : IState<M, P>
    where M : IMove
    where P : IPlayer
{
    public int Depth { get; set; } = 4;

    public float DeepEvaluate(S state)
        => MiniMax(Depth, state);

    public M PickBest(S state)
    {
        throw new System.NotImplementedException();
    }

    float MiniMax(int depth, S state)
    {
        if (depth == 0)
            return state.Evaluate();
        
        throw new NotImplementedException();
    }
}