int MinPathSum(int[,] grid)
{
    if (grid.GetLength(0) == 0)
    {
        return 0;
    }

    var m = grid.GetLength(0);
    var n = grid.GetLength(1);

    var res = new int[n];
    var sum = 0;
    for (var i = 0; i < n; i++)
    {
        sum += grid[0, i];
        res[i] = sum;
    }

    for (var i = 1; i < m; ++i)
    {
        res[0] = res[0] + grid[i, 0];
        for (var j = 1; j < n; ++j)
        {
            res[j] = Math.Min(res[j], res[j - 1]) + grid[i, j];
        }
    }

    return res[n - 1];
}

Console.WriteLine(MinPathSum(new[,] { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } }));
Console.WriteLine(MinPathSum(new[,]{{1, 2, 3}, {4, 5, 6}}));