using System;
using System.Collections.Generic;

int SingleNumber(IEnumerable<int> a)
{
    var result = 0;
    foreach (var t in a)
    {
        result ^= t;
    }

    return result;
}

Console.WriteLine(SingleNumber(new[] { 4, 4, 1, 2, 1, 2, 3, 3, 5, 0, 0, 5, 9, 8, 9, 8, 6 }));