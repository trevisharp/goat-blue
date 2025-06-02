using System.Collections.Generic;

namespace GoatBlue;

using Internal;

public class GameState
{
    ulong hash = 0;

    void Move(int player, int piece, int position)
        => hash ^= Zobrist.Table.GetHash(player, piece, position);
}   