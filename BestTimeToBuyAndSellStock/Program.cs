using System;
using System.Collections.Generic;

int MaxProfit(IReadOnlyList<int> prices)
{
    int maxPrice = 0, maxProfit = 0;
    for (var i = 0; i < prices.Count; i++)
    {
        maxPrice = Math.Max(0, maxPrice + (prices[i] - prices[i - 1 < 0 ? 0 : i - 1]));
        maxProfit = Math.Max(maxPrice, maxProfit);
    }

    return maxProfit;
}

Console.WriteLine(MaxProfit(new[] { 7, 1, 5, 3, 6, 4 }));