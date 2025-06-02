using System;
using System.Runtime.CompilerServices;

namespace GoatBlue.Internal;

public class Zobrist
{
    const int pieces = 5;
    const int squares = 47;
    const int playerFactor = pieces * squares;
    readonly ulong[] table;

    public Zobrist(int players, int seed = -1)
    {
        table = new ulong[players * pieces * squares];
        if (seed == -1)
            seed = Random.Shared.Next();
        
        var random = new Random(seed);
        for (int i = 0; i < table.Length; i++)
            table[i] = ((ulong)random.Next() << 32) | (uint)random.Next();
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ulong GetHash(int player, int piece, int position)
        => table[player * playerFactor + piece * squares + position];
}