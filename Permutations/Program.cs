using System;
using System.Collections.Generic;

IEnumerable<IList<int>> Permute(IReadOnlyList<int> nums)
{
    var n = nums.Count;

    switch (n)
    {
        case 0:
            return null!;
        case 1:
            return new List<IList<int>> { new List<int> { nums[0] } };
    }

    var nEnd = nums[n - 1];

    var nums1 = new int[n - 1];

    for (var i = 0; i < n - 1; i++)
    {
        nums1[i] = nums[i];
    }

    var l = Permute(nums1);

    IList<IList<int>> r = new List<IList<int>>();


    foreach (var ints in l)
    {
        var p = (List<int>)ints;
        for (var j = 0; j < n - 1; j++)
        {
            var tp = new List<int>(p);
            tp.Insert(j, nEnd);
            r.Add(tp);
        }

        p.Add(nEnd);
        r.Add(p);
    }

    return r;
}

var collection = Permute(new[] { 1, 2, 3 });
foreach (var items in collection)
{
    Console.Write("[");
    foreach (var item in items)
    {
        Console.Write($"{item}, ");
    }

    Console.Write("], ");
}