int SearchInsertPosition(IReadOnlyList<int> nums, int target)
{
    var start = 0;
    var end = nums.Count - 1;
    var ans = 0;

    while (start <= end)
    {
        var mid = start + (end - start) / 2;
        if (nums[mid] == target)
        {
            ans = mid;
            break;
        }

        if (nums[mid] < target)
        {
            ans = mid + 1;
            start = mid + 1;
        }
        else
        {
            end = mid - 1;
        }
    }

    return ans;
}

var nums = new[] { 1, 3, 5, 6 };
Console.WriteLine(SearchInsertPosition(nums, 7));