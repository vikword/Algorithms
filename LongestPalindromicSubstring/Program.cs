string LongestPalindromicSubstring(string input)
{
    // var count = 0;
    // for (int i = 0, j = input.Length; i < input.Length / 2 + 1; i++, j--)
    // {
    //     if (input[i] == input[j - 1])
    //     {
    //         count++;
    //     }
    //
    //     if (count == input.Length / 2 + 1)
    //     {
    //         return input;
    //     }
    // }
    //
    // for (var i = 0; i < input.Length; i++)
    // {
    //     if (!(i > input.Length) && input[i] == input[i + 1])
    //     {
    //         return $"{input[i]}{input[i + 1]}";
    //     }
    //
    //     if (!(i > input.Length - 1 && i + 2 < input.Length) && input[i] == input[i + 2])
    //     {
    //         return $"{input[i]}{input[i + 1]}{input[i + 2]}";
    //     }
    //
    //     if (!(i > input.Length - 1 || !(i + 3 < input.Length)) && input[i] == input[i + 3] && input[i + 1] == input[i + 2])
    //     {
    //         return $"{input[i]}{input[i + 1]}{input[i + 2]}{input[i + 3]}";
    //     }
    // }
    //
    // return "";

    int n = input.Length, start = 0, end = 0;
    var dp = new bool[n, n];

    for (var len = 0; len < n; len++)
    {
        for (var i = 0; i + len < n; i++)
        {
            dp[i, i + len] = input[i] == input[i + len] && (len < 2 || dp[i + 1, i + len - 1]);
            if (!dp[i, i + len] || len <= end - start)
            {
                continue;
            }

            start = i;
            end = i + len;
        }
    }

    return input.Substring(start, end + 1).Length > 1 ? input.Substring(start, end + 1) : "Not Palindrom";
}

Console.WriteLine(LongestPalindromicSubstring("qwewq"));