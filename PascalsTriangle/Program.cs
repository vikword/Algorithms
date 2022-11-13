IEnumerable<List<int>> Generate(int numRows)
{
    var res = new List<List<int>> { new() { 1 } };


    if (numRows == 1) return res.ToArray();
    for (var i = 1; i < numRows; i++)
    {
        var tmp = new List<int>();
        for (var j = 0; j <= i; j++)
        {
            int num;
            if (j == 0 || j == i)
            {
                num = 1;
            }
            else
            {
                num = res[i - 1][j - 1] + res[i - 1][j];
            }

            tmp.Add(num);
        }

        res.Add(tmp);
    }

    return res.ToArray();
}

var res = Generate(5);
Console.Write("[");
foreach (var items in res)
{
    Console.Write("[");
    foreach (var item in items)
    {
        Console.Write($"{item}, ");
    }

    Console.Write("]");
}

Console.Write("]");