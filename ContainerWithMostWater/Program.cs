int MaxArea(IReadOnlyList<int> height)
{
    var left = 0;
    var right = height.Count - 1;
    var maxWater = 0;

    while (left < right)
    {
        maxWater = Math.Max(maxWater, Math.Min(height[left], height[right]) * (right - left));

        if (height[left] > height[right])
            right--;
        else
            left++;
    }

    return maxWater;
}

Console.WriteLine(MaxArea(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));