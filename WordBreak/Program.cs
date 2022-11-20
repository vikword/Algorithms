var dic = new List<string>();

bool WordBreak(string s, IEnumerable<string> wordDict)
{
    if (s == "")
    {
        return true;
    }

    if (dic.Contains(s))
    {
        return false;
    }

    var enumerable = wordDict as string[] ?? wordDict.ToArray();
    foreach (var t in enumerable)
    {
        if (t.Length > s.Length) continue;
        var flag = true;
        var k = 0;
        for (var j = 0; j < t.Length; j++)
        {
            if (s[j] != t[k])
            {
                flag = false;
                break;
            }

            k++;
        }

        if (!flag) continue;
        var res = WordBreak(s[t.Length..], enumerable);
        if (res)
        {
            return res;
        }
    }

    dic.Add(s);
    return false;
}

Console.WriteLine(WordBreak("leetcode", new[] { "leet", "code" }));
Console.WriteLine(WordBreak("applepenapple", new[] { "apple", "pen" }));
Console.WriteLine(WordBreak("catsandog", new[] { "cats", "dog", "sand", "and", "cat" }));