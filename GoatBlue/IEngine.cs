namespace GoatBlue;

public interface IEngine<S, M, P>
    where P : IPlayer
    where M : IMove<P>
    where S : IState<M, P>
{
    float DeepEvaluate(S state, P player);

    M PickBest(S state, P player);
}