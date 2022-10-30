IEnumerable<int> DailyTemperatures(IReadOnlyList<int> temperatures)
{
    var stack = new int[temperatures.Count];
    var top = -1;
    var ret = new int[temperatures.Count];
    for (var i = 0; i < temperatures.Count; i++)
    {
        while (top > -1 && temperatures[i] > temperatures[stack[top]])
        {
            var idx = stack[top--];
            ret[idx] = i - idx;
        }

        stack[++top] = i;
    }

    return ret;
}

var temperatures = new[] { 73, 74, 75, 71, 69, 72, 76, 73 };
var result = DailyTemperatures(temperatures);

Console.Write("[");
foreach (var day in result)
{
    Console.Write($"{day}, ");
}

Console.Write("]");