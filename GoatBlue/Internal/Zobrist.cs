using System;
using System.Runtime.CompilerServices;

namespace GoatBlue.Internal;

public class Zobrist
{
    static Zobrist currentTable = new Zobrist(2, -1);
    public static Zobrist Table => currentTable;

    public static void Reset(int players, int seed = -1)
        => currentTable = new Zobrist(players, seed);

    const int pieces = 5;
    const int squares = 47;
    const int playerFactor = pieces * squares;
    readonly ulong[] table;

    Zobrist(int players, int seed)
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