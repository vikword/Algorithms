using System;
using System.Collections.Generic;

string TwoSum(IReadOnlyList<int> nums, int target)
{
    for (var num = 0; num < nums.Count; num++)
    {
        for (var twoNum = 0; twoNum < nums.Count; twoNum++)
        {
            if (num == twoNum)
            {
                continue;
            }

            if (nums[num] + nums[twoNum] == target)
            {
                return $"[{num}, {twoNum}]";
            }
        }
    }

    return $"0";
}

var nums = new[] { 3, 3 };

Console.WriteLine(TwoSum(nums, 6));