IEnumerable<IList<int>> Subsets(IEnumerable<int> nums)
{
    var result = new List<IList<int>> { new List<int>() };
    foreach (var num in nums)
    {
        var l = result.Count;
        for (var i = 0; i < l; i++)
        {
            var temp = result[i].ToList();
            temp.Add(num);
            result.Add(temp);
        }
    }

    return result;
}

var collection = Subsets(new[] { 1, 2, 3 });
foreach (var items in collection)
{
    Console.Write("[");
    foreach (var item in items)
    {
        Console.Write($"{item}, ");
    }

    Console.Write("], ");
}