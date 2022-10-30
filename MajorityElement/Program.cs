int MajorityElement(int[] nums)
{
    Array.Sort(nums);
    return nums[nums.Length / 2];
}

var nums = new[] { 1, 1, 1, 1, 6, 6, 6, 6, 8, 2, 2, 2, 2, 33, 0, };

Console.WriteLine(MajorityElement(nums));