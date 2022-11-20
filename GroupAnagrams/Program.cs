IEnumerable<IList<string>> GroupAnagrams(IReadOnlyCollection<string> strs)
{
    if (strs.Count == 0) return new List<IList<string>>();
    var countDict = new Dictionary<string, IList<string>>();
    foreach (var str in strs)
    {
        var charList = new char[26];
        foreach (var c in str)
        {
            charList[c - 'a']++;
        }

        var key = new string(charList);

        if (!countDict.ContainsKey(key))
        {
            countDict.Add(key, new List<string> { str });
        }
        else
        {
            countDict[key].Add(str);
        }
    }

    return countDict.Values.ToList();
}

foreach (var iAnagram in GroupAnagrams(new[]{"eat", "tea", "tan", "ate", "nat", "bat"}))
{
    foreach (var item in iAnagram)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

foreach (var iAnagram in GroupAnagrams(new[]{""}))
{
    foreach (var item in iAnagram)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

foreach (var iAnagram in GroupAnagrams(new[]{"a"}))
{
    foreach (var item in iAnagram)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}