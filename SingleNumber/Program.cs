﻿int SingleNumber(IReadOnlyList<int> a)
{
    var result = 0;
    foreach (var t in a)
    {
        result ^= t;
    }

    return result;
}

Console.WriteLine(SingleNumber(new[] { 4, 1, 2, 1, 2 }));