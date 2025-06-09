using System;

namespace GoatBlue.Engines;

/// <summary>
/// A Engine that applies MiniMax algorithm for two players.
/// </summary>
public class DuelMiniMaxEngine<S, M> : IEngine<S, M>
    where S : IState<M>
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